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
    public partial class Lab01_Bai02 : Form
    {
        public Lab01_Bai02()
        {
            InitializeComponent();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            float num1, num2, num3;
            if (float.TryParse(tb_num1.Text, out num1) && float.TryParse(tb_num2.Text, out num2) && float.TryParse(tb_num3.Text, out num3))
            {
                float nummin = Math.Min(Math.Min(num1, num2), num3);
                float nummax = Math.Max(Math.Max(num1, num2), num3);


                tb_ans1.Text = nummax.ToString();
                tb_ans2.Text = nummin.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng dữ liệu số", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            tb_num1.Clear();
            tb_num2.Clear();
            tb_num3.Clear();
            tb_ans1.Clear();
            tb_ans2.Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
