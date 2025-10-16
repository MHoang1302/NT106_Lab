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
        }

        private void btn_themmon_Click(object sender, EventArgs e)
        {
            CheckDB();
        }

        private void CheckDB()
        {
            if (!File.Exists("HomNayAnGi.db"))
            {
                SQLiteConnection.CreateFile("HomNayAnGi.db");
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=HomNayAnGi.db;Version=3"))
                {
                    conn.Open();
                    string cmdstring1 = @"CREATE TABLE NguoiDung
                                        (
	                                        IDNCC INT PRIMARY KEY,
	                                        HoVaTen NVARCHAR(50),
	                                        QuyenHan NVARCHAR(20)
                                        )";
                    using(SQLiteCommand cmd1 = new SQLiteCommand(cmdstring1, conn))
                    {
                        cmd1.ExecuteNonQuery();
                    }

                    string cmdstring2 =@"CREATE TABLE MonAn
                                (
	                                IDMA INT PRIMARY KEY,
	                                TenMonAn NVARCHAR(30),
	                                HinhAnh TEXT,
	                                IDNCC INT FOREIGN KEY REFERENCES NguoiDung(IDNCC)
                                )";

                    using(SQLiteCommand cmd2 =new SQLiteCommand(cmdstring2, conn))
                    {
                        cmd2.ExecuteNonQuery();
                    }

                    using (SQLiteCommand cmd = new SQLiteCommand("PRAGMA foreign_keys = ON", conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                LoadListView();
            }
            else
            {
                LoadListView();
            }
        }

        private void LoadListView()
        {
            lv_food.View = View.Details;
            lv_food.Columns.Clear();
            lv_food.Columns.Add("Món Ăn", 200);
            lv_food.Items.Clear();

            string connectionstring = "Data Source=HomNayAnGi.db;Version=3";
            string query = "SELECT TenMonAn FROM MonAn";

            using (SQLiteConnection conn = new SQLiteConnection(connectionstring))
            {
                using(SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    try
                    {
                        conn.Open();

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string monan = reader["TenMonAn"].ToString();
                                ListViewItem item = new ListViewItem(monan);
                                lv_food.Items.Add(item);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi truy vấn" + ex.Message);
                    }
                }
            }
        }

        private void btn_chonmon_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            tb_tenmonan.Clear();
            tb_tennguoidonggop.Clear();
            tb_quyenhan.Clear();
            tb_linkhinhanh.Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
