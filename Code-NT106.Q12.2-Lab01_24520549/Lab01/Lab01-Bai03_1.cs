using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai03_1 : Form
    {
        public Lab01_Bai03_1()
        {
            InitializeComponent();
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


        string[] ChuSo = { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
        string[] Hang = { "", "Nghìn", "Triệu", "Tỷ" };

        private string DocNhom(int n, bool docdaydu = true)
        {
            int tram = n / 100;
            int chuc = (n % 100) / 10;
            int donvi = n % 10;

            string s = "";

            if (tram != 0)
            {
                s += ChuSo[tram] + " Trăm";
            }
            else if (docdaydu && (chuc != 0 || donvi != 0))  
            {
                s += "Không Trăm";

            }

            if (chuc != 0)
            {
                if (chuc == 1)
                    s += " Mười";
                else
                    s += " " + ChuSo[chuc] + " Mươi";
            }
            else if (donvi != 0 && tram != 0)
            {
                s += " Linh";
            }

            if (donvi != 0)
            {
                if (chuc > 1 && chuc != 0 && donvi == 1 ) s += " Mốt";
                else if (chuc == 1 && donvi == 1) s += " Một";
                else if (chuc != 0 && donvi == 5) s += " Lăm";
                else s += " " + ChuSo[donvi];
            }

            return s;
        }

        private string DocSo(string so)
        {
            bool am = false;
            if (so.StartsWith("-"))
            {
                am = true;
                so = so.Substring(1);
            }

            int dai = so.Length;
            int n = 0;
            string ans = "";
            if (dai == 1)
            {
                ans += ChuSo[int.Parse(so)];
            }
            else
            {
                while (dai > 0)
                {
                    int batdau = Math.Max(0, dai - 3);
                    string nhom = so.Substring(batdau, dai - batdau);
                    int nhomso = int.Parse(nhom);
                    if (nhomso != 0)
                    {
                        bool docdaydu = (batdau > 0 && nhomso < 100);
                        ans = DocNhom(nhomso,docdaydu) + " " + Hang[n] + " " + ans;
                    }
                    dai -= 3;
                    n++;
                }
            }

            if (am)
                ans = "Âm " + ans;

            return ans;
        }


        private void btn_doc_Click(object sender, EventArgs e)
        {
            string input = tb_num.Text;
            long ans;
            if ((input.Length < 12 || (input.Length == 13 && input[0] == '-')) && long.TryParse(input, out ans)) 
            {
                tb_ans.Text = DocSo(input);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số đúng định dạng!", "Thông báo lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
