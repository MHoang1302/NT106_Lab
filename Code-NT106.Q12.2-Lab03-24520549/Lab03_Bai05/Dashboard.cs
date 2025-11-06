using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai05
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        Server form = null;

        private void btn_Client_Click(object sender, EventArgs e)
        {
            Client form = new Client();
            form.Show();
        }

        private void btn_Server_Click(object sender, EventArgs e)
        {
            if(form ==null || form.IsDisposed)
            {
                form = new Server();
                form.Show();
            }
            else
            {
                form.BringToFront();
            }
        }
    }
}
