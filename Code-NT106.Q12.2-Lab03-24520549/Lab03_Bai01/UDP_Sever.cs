using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106.Q12._2_Lab03_24520549
{
    public partial class UDP_Sever : Form
    {

        private UdpClient udpClient = null; 

        public UDP_Sever()
        {
            InitializeComponent();
        }

        public void severThread()
        {
            int Port;
            //Kiểm tra port xem có hợp lệ không
            if (int.TryParse(tb_Port.Text, out Port)) 
            {
                udpClient = new UdpClient(Port);

                while (true)
                {
                    //Mã hoá tin nhắn nhận được và hiển thị trong 
                    IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, Port);

                    Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                    string data = Encoding.UTF8.GetString(receiveBytes);

                    string mess = RemoteIpEndPoint.Address.ToString() + ": " + data.ToString() + "\r\n";

                    rtb_ReceivedMessages.Text += mess;
                }
            }
            //Báo lỗi nếu port không hợp lệ
            else
            {
                MessageBox.Show("Port không hợp lệ", "Lỗi");
            }
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {

            Thread thdUdpSever = new Thread(new ThreadStart(severThread));
            thdUdpSever.Start();
        }

        private void btn_EndSever_Click(object sender, EventArgs e)
        {
            udpClient.Close();
            udpClient.Dispose();
        }
    }
}
