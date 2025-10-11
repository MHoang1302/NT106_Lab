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
    public partial class Lab01_Bai06 : Form
    {
        public Lab01_Bai06()
        {
            InitializeComponent();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            DateTime birthday;
            if (DateTime.TryParse(tb_ns.Text, out birthday))
            {
                int month = birthday.Month;
                int day = birthday.Day;
                switch (month)
                {
                    case 1:
                        if (day >= 1 && day <= 20)
                            tb_ans.Text = "Cung Ma Kết";
                        else if (day >= 21 && day <= 31)
                            tb_ans.Text = "Cung Bảo Bình";
                        break;

                    case 2:
                        if (day >= 1 && day <= 19)
                            tb_ans.Text = "Cung Bảo Bình";
                        else if (day >= 21 && day <= 29)
                            tb_ans.Text = "Cung Song Ngư";
                        break;

                    case 3:
                        if (day >= 1 && day <= 20)
                            tb_ans.Text = "Cung Song Ngư";
                        else if (day >= 21 && day <= 31)
                            tb_ans.Text = "Cung Bạch Dương";
                        break;

                    case 4:
                        if (day >= 1 && day <= 20)
                            tb_ans.Text = "Cung Bạch Dương";
                        else if (day >= 21 && day <= 30)
                            tb_ans.Text = "Cung Kim Ngưu";
                        break;

                    case 5:
                        if (day >= 1 && day <= 21)
                            tb_ans.Text = "Cung Kim Ngưu";
                        else if (day >= 22 && day <= 31)
                            tb_ans.Text = "Cung Song Tử";
                        break;

                    case 6:
                        if (day >= 1 && day <= 21)
                            tb_ans.Text = "Cung Song Tử";
                        else if (day >= 22 && day <= 30)
                            tb_ans.Text = "Cung Cự Giải";
                        break;

                    case 7:
                        if (day >= 1 && day <= 22)
                            tb_ans.Text = "Cung Cự Giải";
                        else if (day >= 23 && day <= 31)
                            tb_ans.Text = "Cung Sư Tử";
                        break;

                    case 8:
                        if (day >= 1 && day <= 22)
                            tb_ans.Text = "Cung Sư Tử";
                        else if (day >= 23 && day <= 31)
                            tb_ans.Text = "Cung Xử Nữ";
                        break;

                    case 9:
                        if (day >= 1 && day <= 23)
                            tb_ans.Text = "Cung Xử Nữ";
                        else if (day >= 24 && day <= 30)
                            tb_ans.Text = "Cung Thiên Bình";
                        break;

                    case 10:
                        if (day >= 1 && day <= 23)
                            tb_ans.Text = "Cung Thiên Bình";
                        else if (day >= 24 && day <= 31)
                            tb_ans.Text = "Cung Thần Nông";
                        break;

                    case 11:
                        if (day >= 1 && day <= 22)
                            tb_ans.Text = "Cung Thần Nông";
                        else if (day >= 23 && day <= 30)
                            tb_ans.Text = "Cung Nhân Mã";
                        break;

                    case 12:
                        if (day >= 1 && day <= 21)
                            tb_ans.Text = "Cung Nhân Mã";
                        else if (day >= 22 && day <= 31)
                            tb_ans.Text = "Cung Ma Kết";
                        break;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập ngày sinh đúng định dạng!","Thông báo lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            tb_ns.Clear();
            tb_ans.Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
