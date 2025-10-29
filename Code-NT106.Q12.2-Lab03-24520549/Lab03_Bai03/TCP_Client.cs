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

namespace Lab03_Bai03
{
    public partial class TCP_Client : Form
    {
        private TcpClient tcpClient;
        private NetworkStream ns;
        private string ip = "127.0.0.1";
        private int port = 8080;

        public TCP_Client()
        {
            InitializeComponent();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try {
                this.tcpClient = new TcpClient();
                IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(ip), port);
                tcpClient.Connect(ipe);
                this.ns = tcpClient.GetStream();
                MessageBox.Show("Kết nối thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối", "Lỗi");
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            try {
                Byte[] data = Encoding.UTF8.GetBytes(rtb_Message.Text);
                this.ns.Write(data, 0, data.Length);
                MessageBox.Show("Gửi thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi gửi dữ liệu", "Lỗi");
            }
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                this.ns.Close();
                this.tcpClient.Close();
                MessageBox.Show("Đóng kết nối thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi huỷ kết nối thất bại", "Lỗi");
            }
        }
    }
}
