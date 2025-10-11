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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Lab01
{
    public partial class Lab01_Bai08 : Form
    {
        public Lab01_Bai08()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string food = tb_info.Text;
            tb_list.Text += $"{food}\r\n";
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            string[] foods = tb_list.Text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            if (foods.Length > 0)
            {
                Random random = new Random();
                int food = random.Next(foods.Length);
                string choice = foods[food];
                tb_ans.Text = choice;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập ít nhất 1 món ăn","Thông báo lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
