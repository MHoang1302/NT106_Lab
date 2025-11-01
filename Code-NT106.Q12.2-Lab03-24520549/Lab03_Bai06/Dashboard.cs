namespace Lab03_Bai06
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        Sever sever = null;

        private void btn_Sever_Click(object sender, EventArgs e)
        {
            if(sever ==null||sever.IsDisposed)
            {
                sever = new Sever();
                sever.Show();
            }
            else
            {
                sever.BringToFront();
            }
        }

        private void btn_Client_Click(object sender, EventArgs e)
        {
            Client_Global client = new Client_Global();
            client.Show();
        }
    }
}
