using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lab02_Bai06 : Form
    {
        public Lab02_Bai06()
        {
            InitializeComponent();

            //Load database để hiển thị danh sách đồ ăn
            CheckDB();
        }

        private void btn_themmon_Click(object sender, EventArgs e)
        {
            ThemMon();
        }

        //Hàm kiểm tra database đã được tạo chưa
        private void CheckDB()
        {
            //Chưa được tạo
            if (!File.Exists("HomNayAnGi.db"))
            {
                //Tạo kết nối
                SQLiteConnection.CreateFile("HomNayAnGi.db");
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=HomNayAnGi.db;Version=3"))
                {

                    conn.Open();

                    //Thực hiện truy vấn
                    string cmdstring1 = @"CREATE TABLE NguoiDung
                                        (
	                                        IDNCC INTEGER PRIMARY KEY AUTOINCREMENT,
	                                        HoVaTen NVARCHAR(70),
	                                        QuyenHan VARCHAR(50)
                                        )";
                    using (SQLiteCommand cmd1 = new SQLiteCommand(cmdstring1, conn))
                    {
                        //Tạo bảng
                        cmd1.ExecuteNonQuery();
                    }

                    string cmdstring2 = @"CREATE TABLE MonAn
                                (
	                                IDMA INTEGER PRIMARY KEY AUTOINCREMENT,
	                                TenMonAn NVARCHAR(70),
	                                HinhAnh TEXT,
	                                IDNCC INT REFERENCES  NguoiDung(IDNCC) 
                                )";

                    using (SQLiteCommand cmd2 = new SQLiteCommand(cmdstring2, conn))
                    {
                        //Tạo bảng
                        cmd2.ExecuteNonQuery();
                    }

                    using (SQLiteCommand cmd = new SQLiteCommand("PRAGMA foreign_keys = ON", conn))
                    {
                        //Bật tính năng khóa ngoại
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                //Load Listview
                LoadListView();
            }
            //Có database sẵn rồi
            else
            {
                //Load Listview
                LoadListView();
            }
        }

        private void ThemMon()
        {
            //Khởi tạo giá trị các thông tin
            string Tenmonan = tb_tenmonan.Text.Trim();
            string Tenngthem = tb_tennguoidonggop.Text.Trim();
            string Quyenhan = tb_quyenhan.Text.Trim();
            string Hinhanh = tb_linkhinhanh.Text.Trim();

            //Kiểm tra các ô nhập liệu có lỗi không
            if (string.IsNullOrEmpty(Tenmonan) || string.IsNullOrEmpty(Tenngthem) || string.IsNullOrEmpty(Quyenhan) || string.IsNullOrEmpty(Hinhanh))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi");
                return;

            }

            string connectionstring = "Data Source=HomNayAnGi.db;Version=3";

            //Tạo kết nối
            using (SQLiteConnection conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                //Tạo transaction để đảm bảo rằng nếu 1 truy vấn bị lỗi thì các truy vấn khác sẽ bị hủy để tránh lỗi dữ liệu
                SQLiteTransaction transaction = conn.BeginTransaction();

                try
                {
                    //Kiểm tra xem Người dùng này đã tồn tại chưa
                    int idncc = -1;
                    string checkquery = "SELECT IDNCC FROM NguoiDung WHERE HoVaTen = @Tenngthem AND QuyenHan = @Quyenhan";

                    using (SQLiteCommand cmd = new SQLiteCommand(checkquery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@Tenngthem", Tenngthem);
                        cmd.Parameters.AddWithValue("@Quyenhan", Quyenhan);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            idncc = Convert.ToInt32(result);
                        }
                    }

                    //Chưa tồn tại thì thêm dữ liệu người dùng mới này vào
                    if (idncc == -1)
                    {
                        string insert = "INSERT INTO NguoiDung (HoVaTen, QuyenHan) VALUES (@Tenngthem, @quyenHan); SELECT last_insert_rowid();";
                        using (SQLiteCommand insertcmd = new SQLiteCommand(insert, conn, transaction))
                        {
                            insertcmd.Parameters.AddWithValue("@Tenngthem", Tenngthem);
                            insertcmd.Parameters.AddWithValue("@quyenHan", Quyenhan);
                            idncc = Convert.ToInt32(insertcmd.ExecuteScalar());
                        }
                    }

                    //Thêm thông tin món ăn vô
                    string insertMonAnQuery = "INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES (@Tenmonan, @Hinhanh, @idncc)";
                    using (SQLiteCommand insertCmd = new SQLiteCommand(insertMonAnQuery, conn, transaction))
                    {
                        insertCmd.Parameters.AddWithValue("@Tenmonan", Tenmonan);
                        insertCmd.Parameters.AddWithValue("@Hinhanh", Hinhanh);
                        insertCmd.Parameters.AddWithValue("@idncc", idncc);
                        insertCmd.ExecuteNonQuery();
                    }

                    //Lưu thay đổi
                    transaction.Commit();

                    LoadListView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi truy vấn: " + ex.Message, "Lỗi");
                }
            }
        }

        private void LoadListView()
        {
            //Làm sạch dữ liệu của Listview và thêm thuộc tính món ăn vào
            lv_food.Items.Clear();
            lv_food.View = View.Details;
            lv_food.Columns.Clear();
            lv_food.Columns.Add("Món Ăn", 200);

            string connectionstring = "Data Source=HomNayAnGi.db;Version=3";

            using (SQLiteConnection conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                //Truy vấn lấy tên món ăn
                string query = "SELECT TenMonAn FROM MonAn";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    try
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["TenMonAn"].ToString());
                                lv_food.Items.Add(item);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi truy vấn: " + ex.Message, "Lỗi");
                    }
                }
            }
        }

        private void btn_chonmon_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=HomNayAnGi.db;Version=3";

            //Xóa dữ liệu món ăn vừa chọn trước đó
            tb_kq.Clear();
            if (pb_hinhanh != null)
                pb_hinhanh.Image = null;


            //Truy vấn
            string query = @"
                    SELECT MonAn.TenMonAn,
                           NguoiDung.HoVaTen,
                           MonAn.HinhAnh
                    FROM MonAn
                    INNER JOIN NguoiDung ON MonAn.IDNCC = NguoiDung.IDNCC
                    ORDER BY RANDOM()
                    LIMIT 1";

            using (SQLiteConnection conn = new SQLiteConnection(connectionstring))
            {
                conn.Open();
                try
                {
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                //Khởi tạo giá trị và hiển thị các thuộc tính yêu cầu ra ngoài
                                string monan = reader["TenMonAn"].ToString();
                                string nguoidonggop = reader["HoVaTen"].ToString();
                                string linkanh = reader["HinhAnh"].ToString();

                                tb_kq.Text += $"Món ăn: {monan}\r\n";
                                tb_kq.Text += $"Người đóng góp: {nguoidonggop}\r\n";
                                try
                                {
                                    pb_hinhanh.Load(linkanh);
                                    pb_hinhanh.SizeMode = PictureBoxSizeMode.Zoom;
                                }
                                catch
                                {
                                    pb_hinhanh.Image = null;
                                    MessageBox.Show("Lỗi tải hình ", "Lỗi");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Chưa có món ăn trong danh sách");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi chọn món: {ex.Message}", "Lỗi");
                }
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //Xóa dữ liệu liệu mới nhập ở các thanh textbox
            tb_tenmonan.Clear();
            tb_tennguoidonggop.Clear();
            tb_quyenhan.Clear();
            tb_linkhinhanh.Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            //Thoát ứng dụng
            this.Close();
        }

        private void tb_tenmonan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
