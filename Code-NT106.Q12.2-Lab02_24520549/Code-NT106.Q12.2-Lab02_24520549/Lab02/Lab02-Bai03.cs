using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lab02_Bai03 : Form
    {
        public Lab02_Bai03()
        {
            InitializeComponent();
        }

        //Đọc file
        private void btn_doc_Click(object sender, EventArgs e)
        {
            string inputfile = "input3.txt";
            try
            {
                using (StreamReader sr = new StreamReader(inputfile))
                {
                    rtb_ans.Text = sr.ReadToEnd();
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Không tìm thấy file", "Thông báo lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc file", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        //Tạo biến biểu hiện trạng thái biểu thức đã được tính toán chưa
        bool DaTinh = false;

        //Hàm tính biểu thức trên 1 dòng
        private double TinhToan(string bieuthuc)
        {
            DaTinh = true;
            bieuthuc = bieuthuc.Replace(" ", ""); //Loại bỏ khoảng trắng
            Stack<double> so = new Stack<double>();
            Stack<char> toantu = new Stack<char>();

            int i = 0;
            while (i < bieuthuc.Length)
            {
                char c = bieuthuc[i];

                if (char.IsDigit(c))
                {
                    string tmp = "";
                    //Kiểm tra xem các kí tự phía sau có phải là số hay dấu chấm động hay không
                    while (i < bieuthuc.Length && (char.IsDigit(bieuthuc[i]) || bieuthuc[i] == '.'))
                    {
                        tmp += bieuthuc[i];
                        i++;
                    }
                    so.Push(double.Parse(tmp));
                    continue;
                }
                else if (c == '(')
                    toantu.Push(c);
                else if (c == ')')
                {
                    //Dừng lại tính toán khi gặp kí tự '('
                    while (toantu.Peek() != '(')
                        TinhStack(so, toantu);
                    toantu.Pop();
                }
                else if ("+-*/".Contains(c))
                {
                    //Nếu độ ưu tiên của toán tử trong stack hiện tại lớn hơn hoặc bằng độ ưu tiên kí tự c thì ta sẽ tính toán trong stack trước
                    while (toantu.Count > 0 && UuTien(toantu.Peek()) >= UuTien(c))
                        TinhStack(so, toantu);
                    toantu.Push(c);
                }
                else
                {
                    MessageBox.Show("Toán tử không hợp lệ", "Lỗi");

                    throw new ArgumentException($"Ký tự '{c}' không hợp lệ.");
                }
                i++;
            }
            //Tính các toán tử còn xót lại trong stack
            while (toantu.Count > 0)
                TinhStack(so, toantu);
            return so.Pop();
        }

        //Hàm tính độ ưu tiên toán tử
        private int UuTien(char op)
        {
            if (op == '+' || op == '-') return 1;
            else if (op == '*' || op == '/') return 2;
            return 0;
        }

        //Hàm tính giá trị bên trong stack
        private void TinhStack(Stack<double> so, Stack<char> toantu)
        {
            double b = so.Pop();
            double a =so.Pop();
            char op = toantu.Pop();

            double ans = 0;
            switch (op)
            {
                case '+':
                    ans = a + b;
                    break;
                case '-':
                    ans = a - b;
                    break;
                case '*':
                    ans = a * b;
                    break;
                case '/':
                    ans = a / b;
                    break;
            }

            //Lưu kết quả mới tính được vô stack
            so.Push(ans);
        }

        //Nút tính
        private void btn_tinh_Click(object sender, EventArgs e)
        {
            string[] dong = rtb_ans.Lines;
            List<string> ans = new List<string>();

            foreach(string bt in dong)
            {
                if (!string.IsNullOrEmpty(bt))
                {
                    double kq = TinhToan(bt);
                    ans.Add($"{bt} = {kq}");
                }
                else
                    ans.Add("");
            }
            rtb_ans.Lines = ans.ToArray();
        }

        private void btn_ghi_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem file đã được tính toán chưa
            if (DaTinh)
            {
                string outputfile = "output3.txt";
                try
                {
                    using (StreamWriter sw = new StreamWriter(outputfile))
                    {
                        sw.Write(rtb_ans.Text);
                    }
                    MessageBox.Show("Lưu thành công", "Thông báo");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi ghi file", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa tính biểu thức", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
