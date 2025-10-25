using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lab02_Bai07 : Form
    {
        public Lab02_Bai07()
        {
            InitializeComponent();
        }

        //Ẩn file richtextbox và picturebox khi mới load trang và khởi tạo các thư mục
        private void Lab02_Bai07_Load(object sender, EventArgs e)
        {
            rtb_info.Visible = false;
            pb_info.Visible = false;
            LoadDrives();
        }

        private void LoadDrives()
        {
            //Dọn dẹp thư mục trước khi load (nếu có)
            tv_folder.Nodes.Clear();

            //Duyệt cái ổ đĩa
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    //Định dạng và chỉnh cho tên ổ đĩa hiện ra dễ nhìn
                    string drivename = $"{drive.VolumeLabel} ({drive.Name.TrimEnd('\\')})";
                    TreeNode driveNode = new TreeNode(drivename);
                    driveNode.Tag = drive.RootDirectory.FullName;

                    //Thêm node để giữ chỗ 
                    driveNode.Nodes.Add("...");

                    tv_folder.Nodes.Add(driveNode);
                }
            }
        }

        //Hiển thị thư mục
        private void tv_folder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = e.Node.Tag.ToString();

            //Kiểm tra đường dẫn file tồn tại không
            if (File.Exists(path))
            {
                ShowContent(path);
            }
        }

        private void ClearContent()
        {
            //Dọn dẹp và ẩn đi richtextbox và picturebox 
            rtb_info.Clear();
            rtb_info.Visible = false;
            pb_info.Visible = false;
        }

        private void ShowContent(string path)
        {
            //Lấy đuối mã file
            string extension = Path.GetExtension(path).ToLower();

            ClearContent();

            //Xét trường hợp nếu là các đuôi file hình ảnh
            if (extension == ".jpg" || extension == ".png" || extension == ".bmp" || extension == ".gif")
            {
                rtb_info.Visible = false;
                pb_info.Visible = true;

                try
                {
                    //Gán đường dẫn file ảnh vô để picturebox hiển thị
                    pb_info.Image = Image.FromFile(path);
                    pb_info.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    pb_info.Visible = false;
                    rtb_info.Visible = true;
                    rtb_info.Text = "Không thể hiện thị file ảnh này\r\n";
                }
            }
            //Xét trường hợp file chữ
            else if (extension == ".txt" || extension == ".log" || extension == ".init" || extension == ".csv" ||
                     extension == ".bat" || extension == ".cmd" || extension == ".json" || extension == ".xml" ||
                     extension == ".css" || extension == ".cs" || extension == ".html" || extension == ".js" ||
                     extension == ".java" || extension == ".cpp" || extension == ".h" || extension == ".py" ||
                     extension == ".md" || extension == ".sql"
                    )
            {
                try
                {
                    //ẩn đi picturebox và hiện richtextbox để hiện thị file chữ
                    rtb_info.Visible = true;
                    pb_info.Visible = false;
                    rtb_info.Text = File.ReadAllText(path);
                }
                catch (Exception ex)
                {
                    pb_info.Visible = false;
                    rtb_info.Visible = true;
                    rtb_info.Text = "Không thể hiện thị file chữ này\r\n";
                }
            }
            else
            {
                MessageBox.Show("Không hỗ trợ đọc loại File này");
            }
        }

        //Xử lí sự kiện trước khi mở rộng node
        private void tv_folder_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode parent = e.Node;

            parent.Nodes.Clear();

            //Lấy đường dẫn thư mục cha
            string path = parent.Tag.ToString();

            try
            {
                //Lấy và hiển thị các folder con
                foreach(var dir in Directory.GetDirectories(path))
                {
                    TreeNode dirNode = new TreeNode(Path.GetFileName(dir));
                    dirNode.Tag = dir;
                    dirNode.Nodes.Add("...");
                    parent.Nodes.Add(dirNode);
                }

                //Lấy và hiển thị các file
                foreach(var file in Directory.GetFiles(path))
                {
                    TreeNode fileNode = new TreeNode(Path.GetFileName(file));
                    fileNode.Tag= file;
                    parent.Nodes.Add(fileNode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi truy cập thư mục");
            }
        }
        

    }
}
