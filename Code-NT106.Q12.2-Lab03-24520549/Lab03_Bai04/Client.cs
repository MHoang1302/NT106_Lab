using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai04
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        TcpClient client;
        NetworkStream ns;
        Thread clientThread;
        bool Running = false;

        HashSet<string> GheDaDat = new HashSet<string>();
        Dictionary<string, int> GiaChuan = new Dictionary<string, int>();
        Dictionary<string, List<string>> PhongChieu = new Dictionary<string, List<string>>();
        Dictionary<string, double> LoaiGhe = new Dictionary<string, double>();
        Dictionary<string, List<string>> GheTheoKhach = new Dictionary<string, List<string>>();

        private void Client_Load(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient("127.0.0.1", 8080);
                ns = client.GetStream();
                clientThread = new Thread(Receive_Data);
                clientThread.Start();
                Running = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối", "Lỗi");
            }
        }

        private void Receive_Data(object? obj)
        {
            try
            {
                byte[] buffer = new byte[1024];
                int Byte_Received = ns.Read(buffer, 0, buffer.Length);

                string Json = Encoding.UTF8.GetString(buffer, 0, Byte_Received);

                var Data = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(Json);

                GheDaDat = JsonSerializer.Deserialize<HashSet<string>>(Data["Seat_Taken"].GetRawText());
                GiaChuan = JsonSerializer.Deserialize<Dictionary<string, int>>(Data["Price"].GetRawText());
                LoaiGhe = JsonSerializer.Deserialize<Dictionary<string, double>>(Data["Seat_Type"].GetRawText());
                PhongChieu = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(Data["Room"].GetRawText());

                this.Invoke(new Action(() =>
                {
                    cb_Phim.DataSource = GiaChuan.Keys.ToList();
                }));
                ListenForUpdates();
            }
            catch (Exception ex)
            {
                if (Running) 
                {
                    MessageBox.Show("Lỗi nhận dữ liệu", "Lỗi");
                }
            }
        }

        private void ListenForUpdates()
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024];
                    int Byte_Received = ns.Read(buffer, 0, buffer.Length);
                    if (Byte_Received == 0)
                        break;

                    string Message = Encoding.UTF8.GetString(buffer, 0, Byte_Received);
                    var Data = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(Message);
                    if (Data.ContainsKey("Request") && Data["Request"].GetString() == "Cập nhật ghế")
                    {
                        var UpdateSeats = JsonSerializer.Deserialize<List<string>>(Data["Taken_Seated"].GetRawText());
                        lock (GheDaDat)
                        {
                            GheDaDat = new HashSet<string>(UpdateSeats);
                        }

                        this.Invoke(new Action(() =>
                        {
                            foreach (int i in Enumerable.Range(0, clb_ghe.Items.Count))
                            {
                                string ghe = clb_ghe.Items[i].ToString();
                                if (GheDaDat.Contains(ghe))
                                {
                                    clb_ghe.SetItemCheckState(i, CheckState.Indeterminate);
                                }
                            }
                        }
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                if (Running)
                {
                    this.Invoke(new Action(() => MessageBox.Show("Lỗi kết nối: " + ex.Message)));
                }
            }
        }

        private void cb_Phong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Phong = cb_Phong.SelectedItem.ToString();
            clb_ghe.Items.Clear();
            foreach (var HangGhe in new[] { "A", "B", "C" })
            {
                for (int i = 1; i <= 5; i++)
                {
                    string Ghe = $"{Phong} - {HangGhe}{i}";
                    int index = clb_ghe.Items.Add(Ghe, false);
                    if (GheDaDat.Contains(Ghe))
                    {
                        clb_ghe.SetItemCheckState(index, CheckState.Indeterminate);
                    }
                }
            }
        }

        private void cb_Phim_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Phim = cb_Phim.SelectedItem.ToString();
            cb_Phong.DataSource = PhongChieu[Phim];
        }

        private void btn_DatVe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_TenKhach.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng");
                return;
            }

            string Khach = tb_TenKhach.Text;

            if (!GheTheoKhach.ContainsKey(Khach))
                GheTheoKhach[Khach] = new List<string>();

            var GheCu = GheTheoKhach[Khach];

            var GheMoi = clb_ghe.CheckedItems.Cast<string>().Where(g => !GheDaDat.Contains(g)).ToList();

            if (GheMoi.Count == 0)
            {
                MessageBox.Show("Chọn ít nhất 1 ghế");
                return;
            }

            var SoPhongg = GheCu.Concat(GheMoi).Select(g => g.Split('-')[0]).Distinct().ToList();

            if (SoPhongg.Count > 1 && GheCu.Count + GheMoi.Count > 2)
            {
                MessageBox.Show("Không thể chọn nhiều hơn 2 vé ở 2 quầy khác nhau");
                return;
            }

            string Phim = cb_Phim.SelectedItem.ToString();

            int Gia_Chuan = GiaChuan[Phim];

            double Tong_Tien = 0;
            List<string> Chi_Tiet_Ve = new List<string>();
            foreach (var Ghe in GheMoi)
            {
                GheTheoKhach[Khach].Add(Ghe);
                GheDaDat.Add(Ghe);

                string tenGhe = Ghe.Split('-')[1];

                double heSo = LoaiGhe.ContainsKey(tenGhe) ? LoaiGhe[tenGhe] : 1;

                double Tien = Gia_Chuan * heSo;

                Tong_Tien += Tien;

                Chi_Tiet_Ve.Add($"{Ghe}");
            }

            try
            {
                var Data_Send = new
                {
                    Request = "Đặt vé",
                    Movie = Phim,
                    New_Chair = GheMoi,
                };

                string Json = JsonSerializer.Serialize(Data_Send);
                byte[] Buffer = Encoding.UTF8.GetBytes(Json);
                ns.Write(Buffer, 0, Buffer.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            tb_KQ.Text = $"Họ tên: {tb_TenKhach.Text}\r\n" +
                                 $"Phim: {Phim}\r\n" +
                                 $"Phòng chiếu: {cb_Phong.SelectedItem}\r\n" +
                                 $"Ghế: {string.Join(", ", Chi_Tiet_Ve)}\r\n" +
                                 $"Tổng tiền: {Tong_Tien}đ\r\n";
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            tb_TenKhach.Clear();
            tb_KQ.Clear();
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            Running = false;
            if (client != null && client.Connected)
            {
               client.Close();
            }
        }
    }
}
