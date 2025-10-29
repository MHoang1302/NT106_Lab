using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Lab03_Bai03
{
    public partial class TCP_Sever : Form
    {
        public TCP_Sever()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        void StartUnsafeThread()
        {
            int bytesReceived = 0;

            Byte[] recv = new byte[1024];

            Socket clientSocket;

            Socket listenerSocket=new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);

            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);

            listenerSocket.Bind(iep);

            listenerSocket.Listen(-1);

            clientSocket = listenerSocket.Accept();
            rtb_Message.Text += "Sever started!\r\n";
            rtb_Message.Text += $"Connection accepted from {iep.Address}:{iep.Port}\r\n";

            while (clientSocket.Connected)
            {
                bytesReceived = clientSocket.Receive(recv);

                if (bytesReceived == 0)
                {
                    break;
                }

                string text = Encoding.UTF8.GetString(recv, 0, bytesReceived);
                rtb_Message.Text += ("From client: " + text + "\r\n");
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
