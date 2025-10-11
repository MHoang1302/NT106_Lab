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
    public partial class Lab02_Bai02 : Form
    {
        public Lab02_Bai02()
        {
            InitializeComponent();
        }

        private void btn_doc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = ("Text files (*.txt)|*.txt");
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string name = ofd.SafeFileName.ToString();
                        tb_name.Text = name;

                        string size = fs.Length.ToString();
                        tb_size.Text = size + " bytes";

                        string url = ofd.FileName.ToString();
                        tb_url.Text = url;

                        int linecnt = 0;
                        int wordcnt = 0;
                        int charcnt = 0;
                        string ?line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            rtb_ans.Text += (line + "\r\n");
                            charcnt += line.Length;
                            linecnt++;
                            string[] words = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                            wordcnt += words.Length;
                        }

                        tb_lc.Text = linecnt.ToString();

                        tb_wc.Text = wordcnt.ToString();

                        tb_cc.Text = charcnt.ToString();
                    }
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
