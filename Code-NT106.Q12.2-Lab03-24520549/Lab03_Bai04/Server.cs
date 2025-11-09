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
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab03_Bai04
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            LoadListView();
        }

        TcpListener server;
        Thread serverThread;
        List<TcpClient> clients = new List<TcpClient>();
        bool Running = false;

        Dictionary<string, Dictionary<int, List<string>>> Ve = new Dictionary<string, Dictionary<int, List<string>>>();

        Dictionary<string, int> GiaChuan = new Dictionary<string, int>();

        Dictionary<string, List<string>> PhongChieu = new Dictionary<string, List<string>>();

        Dictionary<string, double> LoaiGhe = new Dictionary<string, double>()
        {
            {"A1",0.25 },{"A5",0.25},{"C1",0.25 },{"C5",0.25},
            {"A2",1 },{"A3",1},{"A4",1 },{"C2",1 },{"C3",1},{"C4",1 },
            {"B2",2 },{"B3",2},{"B4",2 }
        };

        HashSet<string> GheDaDat = new HashSet<string>();

        private void LoadListView()
        {
            lv_Message.Items.Clear();
            lv_Message.View = View.Details;
            lv_Message.Columns.Clear();
            lv_Message.Columns.Add("Message", 400);
        }

        private void StartThread()
        {
            server = new TcpListener(IPAddress.Any, 8080);
            server.Start();

            Ve = JsonSerializer.Deserialize<Dictionary<string, Dictionary<int, List<string>>>>(File.ReadAllText("Input.json"));

            try
            {
                foreach (var info in Ve)
                {
                    string TenPhim = info.Key;
                    int GiaVe = info.Value.Keys.First();
                    List<string> Phong = info.Value.Values.First();
                    GiaChuan[TenPhim] = GiaVe;
                    PhongChieu[TenPhim] = Phong;
                }

                while (Running)
                {
                    TcpClient client = null;
                    try
                    {
                        client = server.AcceptTcpClient();
                    }
                    catch (SocketException)
                    {
                        break;
                    }
                    lock (clients)
                    {
                        clients.Add(client);
                    }

                    AddMessage($"{client.Client.RemoteEndPoint} is connected");

                    NetworkStream ns = client.GetStream();

                    var Data = new
                    {
                        Price = GiaChuan,
                        Room = PhongChieu,
                        Seat_Taken = GheDaDat.ToList(),
                        Seat_Type = LoaiGhe
                    };

                    string Json = JsonSerializer.Serialize(Data);
                    byte[] Sent = Encoding.UTF8.GetBytes(Json);
                    ns.Write(Sent, 0, Sent.Length);

                    Thread clientThread = new Thread(HandleClient);
                    clientThread.Start(client);

                }
            }
            catch (SocketException)
            {
                MessageBox.Show("Lỗi socket", "Lỗi");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
            }
        }

        private void HandleClient(object? obj)
        {
            TcpClient client = (TcpClient)obj;
            NetworkStream ns = client.GetStream();


            byte[] Received = new byte[4096];
            int Bytes_Received;
            try
            {
                while (Running)
                {
                    Bytes_Received = ns.Read(Received, 0, Received.Length);
                    if (Bytes_Received == 0)
                        break;

                    string Message = Encoding.UTF8.GetString(Received, 0, Bytes_Received);
                    var data = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(Message);

                    if (data.ContainsKey("Request") && data["Request"].GetString() == "Đặt vé")
                    {
                        var GheMoi = JsonSerializer.Deserialize<List<string>>(data["New_Chair"].GetRawText());

                        lock (GheDaDat)
                        {
                            foreach (var ghe in GheMoi)
                            {
                                GheDaDat.Add(ghe);
                            }
                            AddMessage($"Cập nhật {GheMoi.Count} ghế từ client");

                            BroadcastUpdate();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (Running)
                {
                    MessageBox.Show($"Lỗi xử lí client: {ex.Message}", "Lỗi");
                }
            }
            finally
            {
                client.Close();
            }
        }

        private void BroadcastUpdate()
        {
            var Update_Data = new
            {
                Request = "Cập nhật ghế",
                Taken_Seated = GheDaDat.ToList()
            };

            string json = JsonSerializer.Serialize(Update_Data);
            byte[] Sent = Encoding.UTF8.GetBytes(json);

            lock (clients)
            {
                foreach (var client in clients.ToList())
                {
                    try
                    {
                        if (client.Connected)
                        {
                            NetworkStream stream = client.GetStream();
                            stream.Write(Sent, 0, Sent.Length);
                        }
                    }
                    catch
                    {
                        clients.Remove(client);
                    }
                }
            }
        }

        private void AddMessage(string message)
        {
            if (lv_Message.InvokeRequired)
            {
                lv_Message.Invoke(new Action<string>(AddMessage), message);
            }
            else
            {
                lv_Message.Items.Add(message);
            }
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            if (!Running)
            {
                Running = true;
                serverThread = new Thread(StartThread);
                serverThread.Start();
            }
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Running)
            {
                Running = false;
                server.Stop();
                lock (clients)
                {
                    foreach (var client in clients)
                    {
                        client.Close();
                    }
                    clients.Clear();
                }
            }
        }
    }
}
