using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai04 : Form
    {
        public Lab01_Bai04()
        {
            InitializeComponent();


            cbb_movie.Items.AddRange(movies.Select(m => m.Name).ToArray());
            cbb_movie.SelectedIndex = 0;

        }

        public class Movie
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public List<int> Rooms { get; set; }
        }

        private List<Movie> movies = new()
        {
            new Movie{Name = "Đào, phở và piano",Price=45000,Rooms = new List<int>{ 1,2,3} },
            new Movie{Name = "Mai",Price=100000,Rooms = new List<int>{ 2,3} },
            new Movie{Name = "Gặp lại chị bầu",Price=70000,Rooms = new List<int>{ 1} },
            new Movie{Name = "Tarot",Price=90000,Rooms = new List<int>{ 3} }
        };

        public enum SeatType { VeVot, Thuong, VIP };
        private Dictionary<string, SeatType> seatTypeMap = new()
        {
            {"A1",SeatType.VeVot },{"B1",SeatType.VeVot },{"C1",SeatType.VeVot },
            {"A2",SeatType.Thuong },{"B2",SeatType.VIP },{"C2",SeatType.Thuong },
            {"A3",SeatType.Thuong},{"B3",SeatType.VIP},{"C3",SeatType.Thuong},
            {"A4",SeatType.Thuong },{"B4",SeatType.VIP },{"C4",SeatType.Thuong },
            {"A5",SeatType.VeVot},{"B5",SeatType.VeVot},{"C5",SeatType.VeVot}
        };

        private void cbb_movie_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_room.Items.Clear();
            Movie movie = movies[cbb_movie.SelectedIndex];
            foreach (int r in movie.Rooms)
            {
                cbb_room.Items.Add(r.ToString());
            }
            if (movie.Rooms.Count > 0)
            {
                cbb_room.SelectedIndex = 0;
            }

        }

        private Dictionary<string, List<string>> gheDaMua = new();

        private void cbb_room_SelectedIndexChanged(object sender, EventArgs e)
        {
            Movie movie = movies[cbb_movie.SelectedIndex];
            int room = int.Parse(cbb_room.SelectedItem.ToString());
            string key = $"{movie.Name}_{room}";

            if (!gheDaMua.ContainsKey(key)) 
                gheDaMua[key] =new List<string>();

            clb_seats.Items.Clear();

            foreach(var ghe in seatTypeMap.Keys)
            {
                int index = clb_seats.Items.Add(ghe);

                if (gheDaMua[key].Contains(ghe))
                {
                    clb_seats.SetItemChecked(index, true);
                    clb_seats.SetItemCheckState(index, CheckState.Indeterminate);
                }
            }

        }

        private void btn_mua_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            Movie movie = movies[cbb_movie.SelectedIndex];
            int room = int.Parse(cbb_room.SelectedItem.ToString());
            string key = $"{movie.Name}_{room}";
            if (name != string.Empty)
            {
                if (!gheDaMua.ContainsKey(key))
                    gheDaMua[key] = new List<string>();

                var gheChon = clb_seats.CheckedItems.Cast<string>().ToList();

                gheChon.RemoveAll(g => gheDaMua[key].Contains(g));

                if (gheChon.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ghế", "Thông báo lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                gheDaMua[key].AddRange(gheChon);

                double tongTien = gheChon.Sum(g =>
                {
                    SeatType type = seatTypeMap[g];
                    return movie.Price * (type == SeatType.VIP ? 2 : type == SeatType.Thuong ? 1 : 0.25);
                });

                string ans = $"Tên: {name}\r\n" 
                            + $"Phim: {movie.Name}\r\n" 
                            + $"Vé đã chọn: {string.Join(", ",gheChon )}\r\n"
                            + $"Phòng: {room}\r\n"
                            + $"Tổng tiền: {tongTien} \r\n";
                tb_kq.Text = ans;
                cbb_room_SelectedIndexChanged(null, null);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên","Thông báo lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            tb_name.Clear();
            tb_kq.Clear();
        }

    }
}
