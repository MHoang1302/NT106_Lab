namespace Lab03_Bai05
{
    partial class Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tb_NguoiDung = new TextBox();
            tb_MonAn = new TextBox();
            tb_QuyenHan = new TextBox();
            tb_Link = new TextBox();
            btn_ThemMon = new Button();
            btn_MonBanThan = new Button();
            btn_MonCongDong = new Button();
            btn_KetNoi = new Button();
            btn_NgatKetNoi = new Button();
            groupBox1 = new GroupBox();
            tb_KQ = new TextBox();
            ptb_Anh = new PictureBox();
            lv_Food = new ListView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Anh).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(376, 43);
            label1.Name = "label1";
            label1.Size = new Size(191, 32);
            label1.TabIndex = 0;
            label1.Text = "Hôm Nay Ăn Gì";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(48, 104);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên người dùng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(48, 166);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 2;
            label3.Text = "Tên món ăn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(48, 237);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 3;
            label4.Text = "Quyền hạn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(48, 302);
            label5.Name = "label5";
            label5.Size = new Size(126, 25);
            label5.TabIndex = 4;
            label5.Text = "Link hình ảnh";
            // 
            // tb_NguoiDung
            // 
            tb_NguoiDung.Location = new Point(260, 109);
            tb_NguoiDung.Name = "tb_NguoiDung";
            tb_NguoiDung.Size = new Size(211, 23);
            tb_NguoiDung.TabIndex = 5;
            // 
            // tb_MonAn
            // 
            tb_MonAn.Location = new Point(260, 171);
            tb_MonAn.Name = "tb_MonAn";
            tb_MonAn.Size = new Size(211, 23);
            tb_MonAn.TabIndex = 6;
            // 
            // tb_QuyenHan
            // 
            tb_QuyenHan.Location = new Point(260, 242);
            tb_QuyenHan.Name = "tb_QuyenHan";
            tb_QuyenHan.Size = new Size(211, 23);
            tb_QuyenHan.TabIndex = 7;
            // 
            // tb_Link
            // 
            tb_Link.Location = new Point(260, 307);
            tb_Link.Name = "tb_Link";
            tb_Link.Size = new Size(211, 23);
            tb_Link.TabIndex = 8;
            // 
            // btn_ThemMon
            // 
            btn_ThemMon.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn_ThemMon.Location = new Point(41, 507);
            btn_ThemMon.Name = "btn_ThemMon";
            btn_ThemMon.Size = new Size(145, 35);
            btn_ThemMon.TabIndex = 9;
            btn_ThemMon.Text = "Thêm món";
            btn_ThemMon.UseVisualStyleBackColor = true;
            btn_ThemMon.Click += btn_ThemMon_Click;
            // 
            // btn_MonBanThan
            // 
            btn_MonBanThan.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn_MonBanThan.Location = new Point(305, 507);
            btn_MonBanThan.Name = "btn_MonBanThan";
            btn_MonBanThan.Size = new Size(271, 35);
            btn_MonBanThan.TabIndex = 10;
            btn_MonBanThan.Text = "Chọn món của bản thân";
            btn_MonBanThan.UseVisualStyleBackColor = true;
            btn_MonBanThan.Click += btn_MonBanThan_Click;
            // 
            // btn_MonCongDong
            // 
            btn_MonCongDong.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn_MonCongDong.Location = new Point(654, 507);
            btn_MonCongDong.Name = "btn_MonCongDong";
            btn_MonCongDong.Size = new Size(271, 35);
            btn_MonCongDong.TabIndex = 11;
            btn_MonCongDong.Text = "Chọn món của cộng đồng";
            btn_MonCongDong.UseVisualStyleBackColor = true;
            btn_MonCongDong.Click += btn_MonCongDong_Click;
            // 
            // btn_KetNoi
            // 
            btn_KetNoi.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_KetNoi.Location = new Point(494, 101);
            btn_KetNoi.Name = "btn_KetNoi";
            btn_KetNoi.Size = new Size(111, 34);
            btn_KetNoi.TabIndex = 12;
            btn_KetNoi.Text = "Kết nối";
            btn_KetNoi.UseVisualStyleBackColor = true;
            btn_KetNoi.Click += btn_KetNoi_Click;
            // 
            // btn_NgatKetNoi
            // 
            btn_NgatKetNoi.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_NgatKetNoi.Location = new Point(654, 101);
            btn_NgatKetNoi.Name = "btn_NgatKetNoi";
            btn_NgatKetNoi.Size = new Size(111, 34);
            btn_NgatKetNoi.TabIndex = 13;
            btn_NgatKetNoi.Text = "Ngắt kết nối";
            btn_NgatKetNoi.UseVisualStyleBackColor = true;
            btn_NgatKetNoi.Click += btn_NgatKetNoi_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_KQ);
            groupBox1.Controls.Add(ptb_Anh);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(493, 272);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(438, 229);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "KẾT QUẢ";
            // 
            // tb_KQ
            // 
            tb_KQ.BackColor = SystemColors.Control;
            tb_KQ.BorderStyle = BorderStyle.None;
            tb_KQ.Location = new Point(6, 22);
            tb_KQ.Multiline = true;
            tb_KQ.Name = "tb_KQ";
            tb_KQ.Size = new Size(426, 96);
            tb_KQ.TabIndex = 16;
            // 
            // ptb_Anh
            // 
            ptb_Anh.Location = new Point(167, 124);
            ptb_Anh.Name = "ptb_Anh";
            ptb_Anh.Size = new Size(265, 99);
            ptb_Anh.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_Anh.TabIndex = 15;
            ptb_Anh.TabStop = false;
            // 
            // lv_Food
            // 
            lv_Food.Location = new Point(499, 141);
            lv_Food.Name = "lv_Food";
            lv_Food.Size = new Size(432, 121);
            lv_Food.TabIndex = 15;
            lv_Food.UseCompatibleStateImageBehavior = false;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 578);
            Controls.Add(lv_Food);
            Controls.Add(groupBox1);
            Controls.Add(btn_NgatKetNoi);
            Controls.Add(btn_KetNoi);
            Controls.Add(btn_MonCongDong);
            Controls.Add(btn_MonBanThan);
            Controls.Add(btn_ThemMon);
            Controls.Add(tb_Link);
            Controls.Add(tb_QuyenHan);
            Controls.Add(tb_MonAn);
            Controls.Add(tb_NguoiDung);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Client";
            Text = "Hôm Nay Ăn Gì";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Anh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tb_NguoiDung;
        private TextBox tb_MonAn;
        private TextBox tb_QuyenHan;
        private TextBox tb_Link;
        private Button btn_ThemMon;
        private Button btn_MonBanThan;
        private Button btn_MonCongDong;
        private Button btn_KetNoi;
        private Button btn_NgatKetNoi;
        private GroupBox groupBox1;
        private PictureBox ptb_Anh;
        private TextBox tb_KQ;
        private ListView lv_Food;
    }
}