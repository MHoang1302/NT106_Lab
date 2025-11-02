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
        private Dictionary<string, Client_Private> privateChat = new Dictionary<string, Client_Private>();

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
            //Tạo ip đích và socket để gửi thông tin
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

            //Tạo packet gửi tín hiệu kết nối đến sever
            ChatPacket connectPacket = new ChatPacket
            {
                Type = PacketType.Connect,
                Name = this.clientName
            };
            client.Send(Serialize(connectPacket));

            //Bất cờ kết nối và tiền hành lắng nghe
            Running = true;
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        public void CloseConnection()
        {
            //Kiểm tra xem cờ kết nối còn bật hay không
            if (!Running) return;
            Running = false;

            //Tạo packet gửi tín hiệu ngắt kết nối
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
                //Tạo packet gửi tín hiệu nhắn tin cho sever
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
                //Nhận tín hiệu từ sever
                while (Running)
                {
                    //Nhận dữ liệu từ sever gửi về và lưu dữ liệu mã hoá dưới dạng byte 
                    byte[] data = new byte[1024 * 5000];
                    int byteReceived = client.Receive(data);

                    //Kiểm tra xem còn kết nối khohong
                    if (byteReceived == 0)
                    {
                        Running = false;
                        break;
                    }
                    //Lưu dữ liệu thật sự và bỏ bớt đi dữ liệu thừa
                    byte[] actualData = new byte[byteReceived];
                    Array.Copy(data, actualData, byteReceived);

                    //Mã hoá gói tin
                    ChatPacket packet = Deserialize<ChatPacket>(actualData);

                    switch (packet.Type)
                    {
                        //Các gói tin chat,connect,disconnect đều thực hiện hiển thị tin nhắn lên
                        case PacketType.Chat:
                        case PacketType.Connect:
                        case PacketType.Disconnect:
                            AddMessage(packet.Message);
                            break;
                        //Tín hiệu cập nhật danh sách người tham gia sever
                        case PacketType.UpdateParticipants:
                            UpdateParticipants(packet.Participants);
                            break;
                        //Tín hiệu yêu cầu chat riêng
                        case PacketType.PrivateChat:
                            // Chuyển việc xử lý qua luồng
                            this.Invoke(new Action(() => HandlePrivateMessage(packet)));
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                if (Running)
                {
                    AddMessage("Mất kết nối máy chủ!");
                }
            }
            finally
            {
                //Dừng chạy và đóng kết nối
                Running = false;
                if (client.Connected)
                {
                    client.Close();
                }
            }
        }

        //Xử lí tin nhắn riêng
        private void HandlePrivateMessage(ChatPacket packet)
        {
            //Lưu tên người gửi
            string senderName = packet.SenderName;

            //Nếu cửa sổ chat đã mở
            if (privateChat.ContainsKey(senderName))
            {
                privateChat[senderName].ReceiveMessage(packet.Message, senderName);
                privateChat[senderName].Focus();
            }
            else
            {
                //Tự động mở cửa sổ chat
                Client_Private privateForm = new Client_Private(this.clientName, senderName);

                
                privateForm.SendPrivateMessage += (pkt) =>
                {
                    try { if (Running) client.Send(Serialize(pkt)); } catch { }
                };
                privateForm.FormClosed += (s, args) =>
                {
                    privateChat.Remove(senderName);
                };

                privateChat.Add(senderName, privateForm);
                privateForm.Show();

                // Gửi tin nhắn cho cửa sổ vừa mở
                privateForm.ReceiveMessage(packet.Message, senderName);
            }
        }

        //Cập nhật danh sách người dùng
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

        //Ấn nút gửi tin nhắn
        private void btn_Send_Click(object sender, EventArgs e)
        {
            string message = tb_Message.Text;
            Send();
            AddMessage("Me: " + message);
            tb_Message.Clear();
        }

        private void lb_Participants_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Chọn người muốn nhắn tin
            if (lb_Participants.SelectedItem == null) return;
            string targetName = lb_Participants.SelectedItem.ToString();

            //Không xử lí trường hợp nhắn với chính mình
            if (targetName == this.clientName) return;

            // Nếu đã mở cửa sổ chat riêng thì sẽ focus hiện lên form chat thôi
            if (privateChat.ContainsKey(targetName))
            {
                privateChat[targetName].Focus();
            }
            else
            {
                //Tạo mới cửa sổ chat riêng
                Client_Private privateForm = new Client_Private(this.clientName, targetName);

                //Khi form private gửi tin nhắn
                privateForm.SendPrivateMessage += (packet) =>
                {
                    try
                    {
                        //Form client global sẽ gửi packet đi tới sever
                        if (Running) client.Send(Serialize(packet));
                    }
                    catch { }
                };

                //Khi form private tắt
                privateForm.FormClosed += (s, args) =>
                {
                    //Xóa khỏi Dictionary
                    privateChat.Remove(targetName);
                };

                // Lưu lại
                privateChat.Add(targetName, privateForm);
                privateForm.Show();
            }
        }
    }
}
