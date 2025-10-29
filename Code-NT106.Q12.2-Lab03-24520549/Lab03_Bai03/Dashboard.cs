namespace Lab03_Bai03
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        TCP_Sever sever = null;
        private void btn_Client_Click(object sender, EventArgs e)
        {
            TCP_Client client = new TCP_Client();
            client.Show();
        }

        private void btn_Sever_Click(object sender, EventArgs e)
        {
            if(sever == null || sever.IsDisposed)
            {
                sever = new TCP_Sever();
                sever.Show();
            }
            else
            {
                sever.BringToFront();
            }
        }
    }
}
