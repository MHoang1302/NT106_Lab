using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai06
{
    public partial class Client_Private : Form
    {
        string MyName;
        string FriendName;
        public Action<ChatPacket> SendPrivateMessage;
        public Client_Private(string MyName, string FriendName)
        {
            InitializeComponent();
            //Gán tên người gửi và người nhận sau đó đặt tên khung chat bằng người dùng mà mình tương tác
            this.MyName = MyName;
            this.FriendName = FriendName;
            this.Text = FriendName;

            lv_Message.View = View.Details;
            lv_Message.Columns.Add("Message", -2);

        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            string message = tb_Message.Text;
            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Vui lòng nhập tin nhắn", "Lỗi");
                return;
            }

            //Tạo packet gửi tín hiệu nhắn tin riêng cho sever
            ChatPacket packet = new ChatPacket
            {
                Type = PacketType.PrivateChat,
                TargetName = this.FriendName,
                Message = message
            };
            SendPrivateMessage?.Invoke(packet);

            AddMessage("Me: " + message);
            tb_Message.Clear();
        }

        public void ReceiveMessage(string message, string senderName)
        {
            AddMessage($"{senderName}: {message}");
        }

        //Thêm tin nhắn vô khung chat
        private void AddMessage(string text)
        {
            if (lv_Message.InvokeRequired)
            {
                lv_Message.Invoke(new Action(() => AddMessage(text)));
            }
            else
            {
                lv_Message.Items.Add(new ListViewItem(text));
                lv_Message.EnsureVisible(lv_Message.Items.Count - 1);
            }
        }
    
    }
}
