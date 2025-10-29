using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Lab03_Bai02
{
    public partial class TCP_Sever : Form
    {
        public TCP_Sever()
        {
            InitializeComponent();
        }

        Socket clientSocket = null;
        Socket listenerSocket = null;
        void StartUnsafeThread()
        {
            int bytesReceived = 0;

            byte[] recv = new byte[1];



            listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipepSever = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);

            listenerSocket.Bind(ipepSever);

            listenerSocket.Listen(-1);

            clientSocket = listenerSocket.Accept();
            rtb_Message.Text += $"Telnet is running on {ipepSever.Address}:{ipepSever.Port}\r\n";

            while (clientSocket.Connected)
            {
                string text = "";
                do
                {
                    bytesReceived += clientSocket.Receive(recv);
                    text += Encoding.ASCII.GetString(recv);
                } while (text[text.Length - 1] != '\n');
                rtb_Message.Text += (text + "\r\n");
            }
            listenerSocket.Close();
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {

            Thread severThread = new Thread(new ThreadStart(StartUnsafeThread));
            severThread.Start();
        }
    }
}
