using System;
using System.IO;
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
    public partial class Lab02_Bai01 : Form
    {
        public Lab02_Bai01()
        {
            InitializeComponent();
        }

        private void btn_doc_Click(object sender, EventArgs e)
        {
            rtb_ans.Clear();
            string inputfile = "input1.txt";
            try
            {
                using (StreamReader sr = new StreamReader(inputfile))
                {
                    rtb_ans.Text = sr.ReadToEnd();
                }
             
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Không tìm thấy file", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc file", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ghi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtb_ans.Text))
            {
                MessageBox.Show("File trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string ans = rtb_ans.Text.ToUpper();
                string outputfile = "output1.txt";
                try
                {
                    using (StreamWriter sw = new StreamWriter(outputfile))
                    {
                        sw.Write(ans);
                    }

                    MessageBox.Show("Lưu thành công!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi file", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
