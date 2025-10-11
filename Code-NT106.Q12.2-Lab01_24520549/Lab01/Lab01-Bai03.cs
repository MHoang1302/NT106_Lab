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
    public partial class Lab01_Bai03 : Form
    {
        public Lab01_Bai03()
        {
            InitializeComponent();
        }

        private void btn_doc_Click(object sender, EventArgs e)
        {
            int num ;
            if (int.TryParse(tb_num.Text, out num))
            {
                if (num >= 0 && num <= 9)
                {
                    switch (num)
                    {
                        case 0:
                            tb_ans.Text = "Không";
                            break;
                        case 1:
                            tb_ans.Text = "Một";
                            break;
                        case 2:
                            tb_ans.Text = "Hai";
                            break;
                        case 3:
                            tb_ans.Text = "Ba";
                            break;
                        case 4:
                            tb_ans.Text = "Bốn";
                            break;
                        case 5:
                            tb_ans.Text = "Năm";
                            break;
                        case 6:
                            tb_ans.Text = "Sáu";
                            break;
                        case 7:
                            tb_ans.Text = "Bảy";
                            break;
                        case 8:
                            tb_ans.Text = "Tám";
                            break;
                        case 9:
                            tb_ans.Text = "Chín";
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số trong khoảng cho phép!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            tb_num.Clear();
            tb_ans.Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
