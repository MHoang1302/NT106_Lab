namespace NT106.Q12._2_Lab03_24520549
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private UDP_Sever form = null;

        private void btn_UdpSever_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem sever form đã được mở chưa, nếu chưa thì mở
            if(form == null || form.IsDisposed)
            {
                form = new UDP_Sever();
                form.Show();
            }
            //Nếu form đã được mở thì cho nó hiện lên đầu
            else
            {
                form.BringToFront();
            }
        }

        private void btn_UdpClient_Click(object sender, EventArgs e)
        {
            //Hiển thị client form
            UDP_Client udp = new UDP_Client();
            udp.Show();
        }
    }
}
