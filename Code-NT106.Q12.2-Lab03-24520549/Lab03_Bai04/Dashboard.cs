namespace Lab03_Bai04
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        //Khởi tạo server form toàn cục để kiểm soát chỉ bật 1 form server 1 lần
        Server form = null;

        //Bật client form lên
        private void btn_Client_Click(object sender, EventArgs e)
        {
            Client form = new Client();
            form.Show();
        }


        private void btn_Server_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem form server đã được bật hay chưa, nếu chưa thì bật lên
            if (form== null || form.IsDisposed)
            {
                form= new Server();
                form.Show();
            }
            //Nếu được bật rồi thì chỉ hiển thị form lên 
            else
            {
                form.BringToFront();
            }
        }
    }
}
