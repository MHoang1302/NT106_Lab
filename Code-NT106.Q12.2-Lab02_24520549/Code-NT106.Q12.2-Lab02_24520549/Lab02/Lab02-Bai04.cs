using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab02
{
    public partial class Lab02_Bai04 : Form
    {
        //Tạo list student và vị trí để hiển thị số thứ tự sinh viên trong danh sách
        private List<Student> students = new List<Student>();
        private int position = 0;
        public Lab02_Bai04()
        {
            InitializeComponent();
        }

        //Tạo class student
        public class Student
        {
            public string Name { get; set; }
            public int ID { get; set; }
            public string Phone { get; set; }
            public double Course1 { get; set; }
            public double Course2 { get; set; }
            public double Course3 { get; set; }
            public double StudentAverage { get; set; }
            public Student(string name, int id, string phone, double course1, double course2, double course3)
            {
                Name = name;
                ID = id;
                Phone = phone;
                Course1 = course1;
                Course2 = course2;
                Course3 = course3;
            }

            public Student() { }

            //Hàm tính điểm trung bình
            public double Average()
            {
                double result = (Course1 + Course2 + Course3) / 3.0;
                return Math.Round(result, 2);
            }

        }


        private void btn_write_Click(object sender, EventArgs e)
        {
            //Kiểm tra danh sách có trống không
            if(students.Count == 0)
            {
                MessageBox.Show("Danh sách học viên trống, vui lòng nhập dữ liệu", "Lỗi");
                return;
            }

            try
            {
                //Tạo options intent để làm json dễ đọc hơn
                //Chuyển đối tượng student sang chuỗi json
                var options = new JsonSerializerOptions { WriteIndented = true };
                string data = JsonSerializer.Serialize(students, options);

                File.WriteAllText("input4.txt", data);
                MessageBox.Show("Ghi thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi file json", "Lỗi");
            }
        }

        //Hàm đọc thông tin học viên
        private void Display(Student st)
        {
            tb_name_read.Text = st.Name;
            tb_id_read.Text = st.ID.ToString();
            tb_phone_read.Text = st.Phone;
            tb_course1_read.Text=st.Course1.ToString();
            tb_course2_read.Text = st.Course2.ToString();
            tb_course3_read.Text = st.Course3.ToString();
            tb_average_read.Text = st.StudentAverage.ToString("F2");

            lb_page.Text= (position+1).ToString(); 
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            //Đọc dữ liệu từ file input
            string data = File.ReadAllText("input4.txt");

            //Chuyển từ chuỗi json sang đối tượng list student
            students = JsonSerializer.Deserialize<List<Student>>(data);

            foreach (var st in students)
            {
                //Tính điểm trung bình của học viên
                st.StudentAverage = st.Average(); 
            }

            //Ghi dữ liệu ra file output
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string output = JsonSerializer.Serialize(students, options);
                File.WriteAllText("output4.txt", output);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ghi file Json", "Lỗi");
            }

;
            try
            {
                //Kiểm tra danh sách học viên rỗng không và sau đó hiển thị thông tin của học viên đầu tiên
                if (students.Count > 0)
                {
                    position = 0;
                    Display(students[position]);
                }
                else
                {
                    MessageBox.Show("File không có dữ liệu để xuất", "Lỗi");
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Không tìm thấy File", "Lỗi");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi đọc File", "Lỗi");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //Thoát ứng dụng
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //Kiểm tra số điện thoại
            if (!Regex.IsMatch(tb_phone_write.Text, @"^0\d{9}$")) 
            {
                MessageBox.Show("Số điện thoại sai định dạng", "Lỗi");
                return;
            }
            //Kiểm tra MSSV
            if (!Regex.IsMatch(tb_id_write.Text, @"\d{8}$"))
            {
                MessageBox.Show("MSSV sai định dạng", "Lỗi");
                return;
            }
            //Kiểm tra điểm số
            if (
                double.Parse(tb_course1_write.Text) < 0 || double.Parse(tb_course1_write.Text) > 10 ||
                double.Parse(tb_course2_write.Text) < 0 || double.Parse(tb_course2_write.Text) > 10 ||
                double.Parse(tb_course3_write.Text) < 0 || double.Parse(tb_course3_write.Text) > 10 
                ) 
            {
                MessageBox.Show("Điểm sai định dạng", "Lỗi");
                return;
            }
            try
            {
                //tạo đối tượng student và khởi tạo giá trị sau đó cho vô list students
                string name = tb_name_write.Text;
                int id = int.Parse(tb_id_write.Text);
                string phone = tb_phone_write.Text;
                double c1 = double.Parse(tb_course1_write.Text);
                double c2 = double.Parse(tb_course2_write.Text);
                double c3 = double.Parse(tb_course3_write.Text);
                Student newstudent = new Student(name, id, phone, c1, c2, c3);
                students.Add(newstudent);

                //thêm thông tin vừa nhập vô richtextbox
                rtb_info.AppendText(tb_name_write.Text + Environment.NewLine);
                rtb_info.AppendText(tb_id_write.Text + Environment.NewLine);
                rtb_info.AppendText(tb_phone_write.Text + Environment.NewLine);
                rtb_info.AppendText(tb_course1_write.Text + Environment.NewLine);
                rtb_info.AppendText(tb_course2_write.Text + Environment.NewLine);
                rtb_info.AppendText(tb_course3_write.Text + Environment.NewLine);
                rtb_info.AppendText(Environment.NewLine);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi thêm dữ liệu", "Lỗi");
            }
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem danh sách rỗng không
            if (students.Count > 0)
            {
                //Kiểm tra xem vị trí của học viên có phải là vị trí đầu tiên không
                if(position > 0)
                {
                    position--;
                    Display(students[position]);
                }
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem danh sách rỗng không
            if (students.Count > 0)
            {
                //Kiểm tra xem vị trí của học viên có phải là vị trí cuối cùng không
                if (position < students.Count - 1)
                {
                    position++;
                    Display(students[position]);
                }
            }
        }
    }
}
