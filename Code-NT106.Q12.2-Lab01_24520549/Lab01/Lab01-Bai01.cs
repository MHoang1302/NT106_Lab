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
    public partial class Lab01_Bai01 : Form
    {
        public Lab01_Bai01()
        {
            InitializeComponent();
        }

        private void btn_tinh_Click(object sender, EventArgs e)
        {
            int num1, num2, sum;
            if (int.TryParse(tb_num1.Text, out num1) && int.TryParse(tb_num2.Text, out num2))
            {
                sum = num1 + num2;
                tb_ans.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Cảnh báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            tb_num1.Clear();
            tb_num2.Clear();
            tb_ans.Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
