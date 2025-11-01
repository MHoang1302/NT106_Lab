using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai06
{
    public partial class Sever : Form
    {
        private TcpListener server;
        private Dictionary<Socket, string> clients = new Dictionary<Socket, string>();

        public Sever()
        {
            InitializeComponent();

            lv_Message.View = View.Details;
            lv_Message.Columns.Add("Message", -2);
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            // Chạy server trên luồng riêng 
            Thread serverThread = new Thread(StartServer);
            serverThread.IsBackground = true;
            serverThread.Start();

            btn_Listen.Enabled = false;
        }

        private void StartServer()
        {
            try
            {
                server = new TcpListener(IPAddress.Any, 8080);
                server.Start();

                while (true)
                {
                    // Chấp nhận client mới
                    Socket clientSocket = server.AcceptSocket();

                    // Tạo luồng riêng để xử lý client này
                    Thread clientThread = new Thread(() => HandleClient(clientSocket));
                    clientThread.IsBackground = true;
                    clientThread.Start();
                }
            }
            catch (SocketException)
            {
                MessageBox.Show("Server ngừng hoạt động","Lỗi");
            }
        }

        // 3. Xử lý tin nhắn từ một client
        private void HandleClient(Socket client)
        {
            string clientName = null;
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024 * 5000];
                    int receivedBytes = client.Receive(buffer);

                    if (receivedBytes == 0) // Client ngắt kết nối
                    {
                        break;
                    }

                    // Cắt mảng byte
                    byte[] actualData = new byte[receivedBytes];
                    Array.Copy(buffer, actualData, receivedBytes);

                    // Giải nén ra Gói tin
                    ChatPacket packet = Deserialize<ChatPacket>(actualData);

                    switch (packet.Type)
                    {
                        case PacketType.Connect:
                            clientName = packet.Name;
                            // Thêm client vào Dictionary
                            clients.Add(client, clientName);
                            Notification($"'{clientName}' connected from {client.RemoteEndPoint}");
                            // Thông báo cho mọi người
                            Broadcast(PacketType.Connect, $"{clientName} joined the group.", null);
                            // Cập nhật danh sách
                            BroadcastParticipantList();
                            break;

                        // Gói tin chat
                        case PacketType.Chat:
                            string formattedMessage = $"{clientName}: {packet.Message}";
                            Notification(formattedMessage);
                            // Gửi cho các client khác (trừ người gửi)
                            Broadcast(PacketType.Chat, formattedMessage, client);
                            break;

                        // Gói tin ngắt kết nối
                        case PacketType.Disconnect:
                            break;
                    }
                }
            }
            catch
            {

            }
            finally
            {
                // Dọn dẹp khi client thoát
                if (clientName != null)
                {
                    clients.Remove(client);
                    string disconnectMessage = $"{clientName} left the group.";
                    Notification(disconnectMessage);
                    // Thông báo cho mọi người
                    Broadcast(PacketType.Disconnect, disconnectMessage, null);
                    // Cập nhật danh sách
                    BroadcastParticipantList();
                }
                client.Close();
            }
        }

        private void Broadcast(PacketType type, string message, Socket excludeClient)
        {
            // Tạo một danh sách clients an toàn để duyệt
            List<Socket> currentClients = new List<Socket>(clients.Keys);

            ChatPacket packet = new ChatPacket
            {
                Type = type,
                Message = message
            };
            byte[] data = Serialize(packet);

            foreach (Socket client in currentClients)
            {
                if (client != excludeClient) // Không gửi lại cho người gửi (nếu là chat)
                {
                    try
                    {
                        client.Send(data);
                    }
                    catch
                    {
                        // Xử lý nếu client này cũng vừa ngắt kết nối
                    }
                }
            }
        }

        // 5. Gửi danh sách participants đã cập nhật
        private void BroadcastParticipantList()
        {
            List<Socket> currentClients = new List<Socket>(clients.Keys);
            List<string> names = clients.Values.ToList(); // Lấy list tên

            ChatPacket packet = new ChatPacket
            {
                Type = PacketType.UpdateParticipants,
                Participants = names
            };
            byte[] data = Serialize(packet);

            foreach (Socket client in currentClients)
            {
                try
                {
                    client.Send(data);
                }
                catch { }
            }
        }

        // 6. Hiển thị thông báo và tin nhắn
        private void Notification(string message)
        {
            if (lv_Message.InvokeRequired)
            {
                lv_Message.Invoke(new Action(() => Notification(message)));
            }
            else
            {
                lv_Message.Items.Add(new ListViewItem(message));
                lv_Message.EnsureVisible(lv_Message.Items.Count - 1);
            }
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

        // 7. Dọn dẹp khi đóng Form Server
        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<Socket> currentClients = new List<Socket>(clients.Keys);
            foreach (Socket client in currentClients)
            {
                client.Close();
            }
            server?.Stop();
        }


    }
}

