using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace NT106.Q12._2_Lab03_24520549
{
    public partial class UDP_Client : Form
    {
        public UDP_Client()
        {
            InitializeComponent();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            try
            {
                //Khởi tạo udp client
                UdpClient Client = new UdpClient();

                //Mã hoá chuỗi
                Byte[] sendBytes = Encoding.UTF8.GetBytes(rtb_Message.Text);

                //Gửi tin nhắn
                Client.Send(sendBytes, sendBytes.Length, tb_IpRemote.Text, int.Parse(tb_Port.Text));

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi gửi data","Lỗi");
            }
        }
    }
}
