using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai06
{
    public partial class Client_Global : Form
    {
        public Client_Global()
        {
            InitializeComponent();

            // Thiết lập ListView cho chat
            lv_Message.View = View.Details;
            lv_Message.Columns.Add("Message", -2);
        }

        IPEndPoint iep;
        Socket client;
        private string clientName;
        private bool Running = false;

        //Gửi tin đi
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Name.Text))
            {
                MessageBox.Show("Vui lòng nhập tên", "Lỗi");
                return;
            }

            this.clientName = tb_Name.Text;
            Connection();
        }

        public void Connection()
        {
            iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                client.Connect(iep);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối", "Lỗi");
                return;
            }

            ChatPacket connectPacket = new ChatPacket
            {
                Type = PacketType.Connect,
                Name = this.clientName
            };
            client.Send(Serialize(connectPacket));

            Running = true;
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        public void CloseConnection()
        {
            if (!Running) return;
            Running = false;

            ChatPacket disconnectPacket = new ChatPacket { Type = PacketType.Disconnect };
            try
            {
                client.Send(Serialize(disconnectPacket));
            }
            catch
            {
                MessageBox.Show("Lỗi đóng kết nối", "Lỗi");
            }
            client.Close();
        }

        public void Send()
        {
            if (tb_Message.Text != string.Empty)
            {
                ChatPacket sendPacket = new ChatPacket
                {
                    Type = PacketType.Chat,
                    Message = tb_Message.Text
                };
                client.Send(Serialize(sendPacket));
            }
        }

        public void Receive()
        {
            try
            {
                while (Running)
                {
                    byte[] data = new byte[1024 * 5000];
                    int byteReceived = client.Receive(data);

                    if (byteReceived == 0)
                    {
                        Running = false;
                        break;
                    }
                    byte[] actualData = new byte[byteReceived];
                    Array.Copy(data, actualData, byteReceived);

                    ChatPacket packet = Deserialize<ChatPacket>(actualData);

                    switch (packet.Type)
                    {
                        case PacketType.Chat:
                        case PacketType.Connect:
                        case PacketType.Disconnect:
                            AddMessage(packet.Message);
                            break;
                        case PacketType.UpdateParticipants:
                            UpdateParticipants(packet.Participants);
                            break;
                    }

                }
            }
            catch(Exception ex)
            {
                if (Running)
                {
                    AddMessage("Mất kết nối máy chủ!");
                }
            }
            finally
            {
                Running=false;
                if (client.Connected)
                {
                    client.Close();
                }
            }
        }

        private void UpdateParticipants(List<string> participants)
        {
            if (lb_Participants.InvokeRequired)
            {
                lb_Participants.Invoke(new Action(() => UpdateParticipants(participants)));
            }
            else
            {
                lb_Participants.Items.Clear();
                foreach (string name in participants)
                {
                    lb_Participants.Items.Add(name);
                }
            }
        }

        void AddMessage(string s)
        {
            lv_Message.Items.Add(new ListViewItem() { Text = s });
        }

        byte[] Serialize(object obj)
        {
            return JsonSerializer.SerializeToUtf8Bytes(obj);
        }

        T Deserialize<T>(byte[] data)
        {
            if (data == null || data.Length == 0)
            {
                return default(T);
            }
            return JsonSerializer.Deserialize<T>(data);
        }

        //Đóng kết nối khi tắt form
        private void Client_Global_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseConnection();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            string message = tb_Message.Text;
            Send();
            AddMessage("Me: " + message);
            tb_Message.Clear();
        }
    }
}
