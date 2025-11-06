using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai05
{
    public partial class Client : Form
    {
        private TcpClient client;   
        private StreamReader reader;
        private StreamWriter writer;

        private string TenNguoiDung;
        private string QuyenHan;

        public Client()
        {
            InitializeComponent();
            LoadListView();
        }

        private void btn_KetNoi_Click(object sender, EventArgs e)
        {
            string user = tb_NguoiDung.Text;
            string quyenhan = tb_QuyenHan.Text;

            if(string.IsNullOrEmpty(user)||string.IsNullOrEmpty(quyenhan))
            {
                MessageBox.Show("Vui lòng nhập tên và quyền hạn để kết nối với server", "Lỗi");
                return;
            } 

            try
            {
                client = new TcpClient();
                client.Connect("127.0.0.1", 8080);

                NetworkStream ns = client.GetStream();
                reader = new StreamReader(ns, Encoding.UTF8);
                writer = new StreamWriter(ns, Encoding.UTF8) { AutoFlush = true };

                this.TenNguoiDung = user;
                this.QuyenHan = quyenhan;
                MessageBox.Show("Kết nối thành công");

                LoadFood();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối", "Lỗi");
            }
        }

        private void LoadFood()
        {
            writer.WriteLine("GET_FOOD");
            string jsonResponse = reader.ReadLine();

            try
            {
                var list = JsonConvert.DeserializeObject<List<Food>>(jsonResponse);
                lv_Food.Items.Clear();
                foreach(var food in list)
                {
                    ListViewItem item = new ListViewItem(food.TenMon);
                    item.SubItems.Add(food.TenNguoiThem);
                    lv_Food.Items.Add(item);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách", "Lỗi");
            }
        }

        private void btn_NgatKetNoi_Click(object sender, EventArgs e)
        {
            try {
                reader?.Close();
                writer?.Close();
                client?.Close();

                this.TenNguoiDung = null;
                this.QuyenHan = null;

                lv_Food.Items.Clear();
                MessageBox.Show("Ngắt kết nối thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ngắt kết nối", "Lỗi");
            }
        }

        private void LoadListView()
        {
            lv_Food.Items.Clear();
            lv_Food.View = View.Details;
            lv_Food.Columns.Clear();
            lv_Food.Columns.Add("Món ăn", 200);
            lv_Food.Columns.Add("Người đóng góp", 200);
        }

        private void btn_ThemMon_Click(object sender, EventArgs e)
        {
            string tenMon = tb_MonAn.Text;
            string linkAnh = tb_Link.Text;
            if (string.IsNullOrEmpty(tenMon) || string.IsNullOrEmpty(linkAnh))
            {
                MessageBox.Show("Vui lòng nhập thông tin món ăn", "Lỗi");
                return;
            }
            string request = $"ADD_FOOD|{tenMon}|{this.TenNguoiDung}|{this.QuyenHan}|{linkAnh}";

            writer.WriteLine(request);

            string response = reader.ReadLine();

            if (response == "ADD_SUCCESS")
            {
                MessageBox.Show("Thêm món thành công!");
                tb_MonAn.Clear();
                tb_Link.Clear();
                LoadFood();
            }
            else
            {
                MessageBox.Show("Lỗi thêm món: ", "Lỗi");
            }
        }

        private void btn_MonBanThan_Click(object sender, EventArgs e)
        {
            tb_KQ.Clear();
            if (ptb_Anh != null)
            {
                ptb_Anh.Image = null;
            }

            writer.WriteLine($"MY_FOOD|{this.TenNguoiDung}");
            string jsonResponse = reader.ReadLine();
            HandleResponse(jsonResponse);

        }


        private void btn_MonCongDong_Click(object sender, EventArgs e)
        {
            tb_KQ.Clear();
            if (ptb_Anh != null)
            {
                ptb_Anh.Image = null;
            }
            writer.WriteLine($"COMMUNITY_FOOD");
            string jsonResponse = reader.ReadLine();
            HandleResponse(jsonResponse);
        }

        private void HandleResponse(string? jsonResponse)
        {
            try {
                var food = JsonConvert.DeserializeObject<Food>(jsonResponse);

                tb_KQ.Text += $"Món ăn: {food.TenMon}\r\n";
                tb_KQ.Text += $"Người đóng góp: {food.TenNguoiThem}\r\n";

                //Cập nhật ảnh
                if (!string.IsNullOrEmpty(food.LinkAnh))
                {
                    //Tải ảnh từ link
                    ptb_Anh.ImageLocation = food.LinkAnh;
                }
                else
                {
                    // Nếu link rỗng, xóa ảnh
                    ptb_Anh.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi chọn món: {ex.Message} ", "Lỗi");
            }
        }
    }
}
