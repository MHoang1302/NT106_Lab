using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab01
{
    public partial class Lab01_Bai05 : Form
    {
        public Lab01_Bai05()
        {
            InitializeComponent();
        }

        private void btn_tinh_Click(object sender, EventArgs e)
        {
            //Xóa dữ liệu trước đó của phần kết quả
            tb_ans.Clear();


            int num1;
            int num2;
            if (int.TryParse(tb_num1.Text, out num1) && int.TryParse(tb_num2.Text, out num2))
            {
                if (cb_choice.Text == "Bảng cửu chương")
                {
                    if (num2 > 0 && num2 > num1)
                    {
                        //Bảng cửu chương
                        int ans = num2 - num1;
                        for (int i = 1; i <= 10; i++)
                        {
                            tb_ans.Text += $"{ans}   *   {i}   =   {ans * i} \r\n";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số B phải lớn hơn 0 và lớn hơn số A", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (cb_choice.Text == "Tính toán giá trị")
                {
                    if (num2 > 0 && num1 > num2)
                    {
                        //Tính giai thừa (A-B)!
                        long factorial = 1;
                        for (int i = num1 - num2; i > 0; i--)
                        {
                            factorial *= i;
                        }
                        tb_ans.Text += $"(A-B)!   =   {factorial} \r\n";

                        //Tính tổng  A^1 + A^2 + A^3 + A^4 + … + A^B
                        long sum = 0;
                        for (int i = 1; i <= num2; i++)
                        {
                            sum += (int)Math.Pow(num1, i);
                        }
                        tb_ans.Text += $"S    =    {sum}";
                    }
                    else
                    {
                        MessageBox.Show("Số B phải lớn hơn 0 và nhỏ hơn số A", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên!","Thông báo lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            tb_num1.Clear();
            tb_num2.Clear();
            cb_choice.Text = string.Empty;
            tb_ans.Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
