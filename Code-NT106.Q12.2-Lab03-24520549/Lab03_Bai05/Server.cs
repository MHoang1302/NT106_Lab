using Newtonsoft.Json;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Diagnostics.Eventing.Reader;

namespace Lab03_Bai05
{
    public partial class Server : Form
    {
        private TcpListener server;
        private string connectionstring = "Data Source=HomNayAnGi.db;Version=3";

        public Server()
        {
            InitializeComponent();
            LoadListView();
        }

        private void LoadListView()
        {
            lv_Message.View = View.Details;
            lv_Message.Columns.Clear();
            lv_Message.Columns.Add("Thông báo", 400);
        }


        private void btn_Listen_Click(object sender, EventArgs e)
        {
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.IsBackground = true;
            serverThread.Start();
        }

        private void StartUnsafeThread()
        {
            try
            {
                server = new TcpListener(IPAddress.Any, 8080);
                server.Start();

                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    AddMessage($"{client.Client.RemoteEndPoint} is connected");

                    Thread clientThread = new Thread(() => HandleClient(client));
                    clientThread.IsBackground = true;
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối", "Lỗi");
            }
        }

        private void HandleClient(TcpClient client)
        {
            string user = null;
            string quyenhan = null;
            string info = client.Client.RemoteEndPoint.ToString();

            try
            {

                using (NetworkStream ns = client.GetStream())
                using (StreamReader reader = new StreamReader(ns, Encoding.UTF8))
                using (StreamWriter writer = new StreamWriter(ns, Encoding.UTF8) { AutoFlush = true })
                {
                    while (client.Connected)
                    {
                        string request = reader.ReadLine();
                        if (request == null) break; ;

                        string response = HandleRequest(request);

                        writer.WriteLine(response);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                client.Close();
                AddMessage($"{info} is disconnected");
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

        private string HandleRequest(string request)
        {
            string[] parts = request.Split('|');
            string cmd = parts[0];
            switch (cmd)
            {
                case "GET_FOOD":
                    return GetAllFood();


                case "ADD_FOOD":
                    AddFood(parts[1], parts[2], parts[3], parts[4]);
                    return "ADD_SUCCESS";

                case "MY_FOOD":
                    string tennguoidung = parts[1];
                    return RandomFood(tennguoidung);

                case "COMMUNITY_FOOD":
                    return RandomFood(null);
                default:
                    return "ERROR: Unknown command";
            }
        }

        private string GetOrAddUser(string ten, string quyenhan)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                string idncc = null;

                string query = "SELECT IDNCC FROM NguoiDung WHERE HoVaTen = @hoVaTen AND QuyenHan=@quyenHan";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@hoVaTen", ten);
                    cmd.Parameters.AddWithValue("@quyenHan", quyenhan);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        idncc = result.ToString();
                        return idncc;
                    }
                }

                string insert = "INSERT INTO NguoiDung (HoVaTen,QuyenHan) VALUES(@hoVaTen,@quyenHan); SELECT last_insert_rowid();";
                using (SQLiteCommand cmd = new SQLiteCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@hoVaTen", ten);
                    cmd.Parameters.AddWithValue("@quyenHan", quyenhan);
                    idncc = cmd.ExecuteScalar().ToString();
                    return idncc;
                }
            }
        }

        private string RandomFood(string tennguoidung)
        {
            using(SQLiteConnection conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                string query;
                if (string.IsNullOrEmpty(tennguoidung))
                {
                    query = "SELECT TenMonAn,HoVaTen,HinhAnh FROM MonAn JOIN NguoiDung ON MonAn.IDNCC=NguoiDung.IDNCC ORDER BY RANDOM() LIMIT 1";
                }
                else
                {
                    query = "SELECT TenMonAn,HoVaTen,HinhAnh FROM MonAn JOIN NguoiDung ON MonAn.IDNCC=NguoiDung.IDNCC WHERE NguoiDung.HoVaTen=@tennguoidung ORDER BY RANDOM() LIMIT 1";
                }
                using(SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    if(!string.IsNullOrEmpty(tennguoidung))
                    {
                        cmd.Parameters.AddWithValue("@tennguoidung", tennguoidung);
                    }
                    using(SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            var food = new Food
                            {
                                TenMon = reader["TenMonAn"].ToString(),
                                TenNguoiThem = reader["HoVaTen"].ToString(),
                                LinkAnh = reader["HinhAnh"].ToString()
                            };
                            return JsonConvert.SerializeObject(food);
                        }
                        else
                        {
                            return "ERROR: No food found";
                        }
                    }
                    
                }
            }
        }

        private void AddFood(string monan, string nguoithem, string quyenhan, string linkanh)
        {
            try
            {
                string idncc = GetOrAddUser(nguoithem, quyenhan);
                using (SQLiteConnection conn = new SQLiteConnection(connectionstring))
                {
                    conn.Open();
                    string query = "INSERT INTO MonAn (TenMonAn,HinhAnh,IDNCC) VALUES(@tenmon,@hinhanh,@idncc)";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@tenmon", monan);
                        cmd.Parameters.AddWithValue("@hinhanh", linkanh);
                        cmd.Parameters.AddWithValue("@idncc", idncc);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm món", "Lỗi");
            }
        }

        private string GetAllFood()
        {
            var list = new List<Food>();
            using (SQLiteConnection conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                string query = "SELECT TenMonAn,HoVaTen,HinhAnh FROM MonAn JOIN NguoiDung ON MonAn.IDNCC=NguoiDung.IDNCC";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using(SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Food
                            {
                                TenMon = reader["TenMonAn"].ToString(),
                                TenNguoiThem = reader["HoVaTen"].ToString(),
                                LinkAnh = reader["HinhAnh"].ToString()
                            });
                        }
                    }
                    return JsonConvert.SerializeObject(list);
                }
            }
        } 
    }
} 
