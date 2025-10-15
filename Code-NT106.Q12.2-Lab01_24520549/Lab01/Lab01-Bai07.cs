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
    public partial class Lab01_Bai07 : Form
    {
        public Lab01_Bai07()
        {
            InitializeComponent();
        }

        private void btn_tracuu_Click(object sender, EventArgs e)
        {
            //Xoá dữ liệu trước đấy
            tb_ans.Clear();

            //Tách thông tin từ text box thành chuỗi
            string ans = tb_info.Text;
            string[] data = ans.Split(new char[] { ',' });

            //Khởi tạo giá trị
            string name = data[0];
            int pass = 0, notpass = 0;
            double sum = 0;
            List<double> dsdiem = new List<double>();

            //Xử lí tên
            if (!name.All(c => char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("Nhập sai Format", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_info.Clear();
                tb_info.Focus();
                return;
            }
            else
            {
                tb_ans.Text += $"Tên: {name}\r\n";
            }


            //Xử lí dữ liệu điểm
            for (int i = 1; i < data.Length; i++)
            {
                double score;
                if (!double.TryParse(data[i].Trim(), out score))
                {
                    if (score < 0 && score > 10)
                    {
                        MessageBox.Show("Nhập sai Format", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tb_ans.Clear();
                        tb_info.Focus();
                        return;
                    }
                }
                else
                {
                    tb_ans.Text += $"Môn {i}: {score}\r\n";

                    if (score >= 5.0) pass++;
                    else notpass++;

                    sum += score;
                    dsdiem.Add(score);
                }
            }
            double avg = sum / dsdiem.Count;
            double avground = Math.Round(avg, 2);   

            //Hiển thị thông tin
            tb_ans.Text += $"Điểm Trung Bình: {avg}\r\n";
            tb_ans.Text += $"Điểm Cao Nhất: {dsdiem.Max()}\r\n";
            tb_ans.Text += $"Điểm Thấp Nhất: {dsdiem.Min()}\r\n";
            tb_ans.Text += $"Đậu: {pass}\r\n";
            tb_ans.Text += $"Rớt: {notpass}\r\n";

            string xeploai = XepLoai(avg, dsdiem);

            tb_ans.Text += $"Xếp loại: {xeploai}\r\n";
        }

        //Xếp loại
        private string XepLoai(double avg, List<double> dsdiem)
        {
            if (avg >= 8 && dsdiem.All(d => d >= 6.5f)) return "Giỏi";
            if (avg >= 6.5 && dsdiem.All(d => d >= 5f)) return "Khá";
            if (avg >= 5 && dsdiem.All(d => d >= 3.5f)) return "Trung bình";
            if (avg >= 3.5 && dsdiem.All(d => d >= 2f)) return "Yếu";
            return "Kém";
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            tb_info.Clear();
            tb_ans.Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
