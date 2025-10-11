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
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = ("Text files (*.txt)|*.txt");
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            rtb_ans.Text = sr.ReadToEnd();
            sr.Close();
            fs.Close();
        }

        private void btn_ghi_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ("Text files (*.txt)|*.txt");
            string ans = rtb_ans.Text.ToUpper();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    sw.Write(ans);
                }

                MessageBox.Show("Lưu thành công!", "Thông báo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
