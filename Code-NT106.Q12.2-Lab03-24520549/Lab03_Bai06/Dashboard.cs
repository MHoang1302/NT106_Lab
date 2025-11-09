namespace Lab03_Bai06
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        //Khởi tạo server form toàn cục để kiểm soát chỉ bật 1 form server 1 lần
        Sever sever = null;

        private void btn_Sever_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem form server đã được bật hay chưa, nếu chưa thì bật lên
            if (sever ==null||sever.IsDisposed)
            {
                sever = new Sever();
                sever.Show();
            }
            //Nếu được bật rồi thì chỉ hiển thị form lên 
            else
            {
                sever.BringToFront();
            }
        }

        //Bật client form lên
        private void btn_Client_Click(object sender, EventArgs e)
        {
            Client_Global client = new Client_Global();
            client.Show();
        }
    }
}
