namespace Lab03_Bai04
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
            cb_Phim = new ComboBox();
            cb_Phong = new ComboBox();
            btn_DatVe = new Button();
            btn_Xoa = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tb_TenKhach = new TextBox();
            clb_ghe = new CheckedListBox();
            groupBox1 = new GroupBox();
            tb_KQ = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cb_Phim
            // 
            cb_Phim.FormattingEnabled = true;
            cb_Phim.Location = new Point(190, 155);
            cb_Phim.Name = "cb_Phim";
            cb_Phim.Size = new Size(121, 23);
            cb_Phim.TabIndex = 0;
            cb_Phim.SelectedIndexChanged += cb_Phim_SelectedIndexChanged;
            // 
            // cb_Phong
            // 
            cb_Phong.FormattingEnabled = true;
            cb_Phong.Location = new Point(190, 192);
            cb_Phong.Name = "cb_Phong";
            cb_Phong.Size = new Size(121, 23);
            cb_Phong.TabIndex = 1;
            cb_Phong.SelectedIndexChanged += cb_Phong_SelectedIndexChanged;
            // 
            // btn_DatVe
            // 
            btn_DatVe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_DatVe.Location = new Point(634, 111);
            btn_DatVe.Name = "btn_DatVe";
            btn_DatVe.Size = new Size(130, 35);
            btn_DatVe.TabIndex = 2;
            btn_DatVe.Text = "Đặt vé";
            btn_DatVe.UseVisualStyleBackColor = true;
            btn_DatVe.Click += btn_DatVe_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_Xoa.Location = new Point(634, 174);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(130, 37);
            btn_Xoa.TabIndex = 3;
            btn_Xoa.Text = "Xoá thông tin";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.ForeColor = Color.MediumAquamarine;
            label1.Location = new Point(258, 30);
            label1.Name = "label1";
            label1.Size = new Size(310, 46);
            label1.TabIndex = 4;
            label1.Text = "Quản Lý Phòng Vé";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(50, 118);
            label2.Name = "label2";
            label2.Size = new Size(117, 21);
            label2.TabIndex = 5;
            label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(50, 153);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 6;
            label3.Text = "Tên phim";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(50, 190);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 7;
            label4.Text = "Phòng ";
            // 
            // tb_TenKhach
            // 
            tb_TenKhach.Location = new Point(190, 120);
            tb_TenKhach.Name = "tb_TenKhach";
            tb_TenKhach.Size = new Size(121, 23);
            tb_TenKhach.TabIndex = 8;
            // 
            // clb_ghe
            // 
            clb_ghe.FormattingEnabled = true;
            clb_ghe.Location = new Point(12, 244);
            clb_ghe.MultiColumn = true;
            clb_ghe.Name = "clb_ghe";
            clb_ghe.Size = new Size(312, 112);
            clb_ghe.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_KQ);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(368, 244);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 166);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kết quả";
            // 
            // tb_KQ
            // 
            tb_KQ.BackColor = SystemColors.Control;
            tb_KQ.BorderStyle = BorderStyle.None;
            tb_KQ.Location = new Point(6, 28);
            tb_KQ.Multiline = true;
            tb_KQ.Name = "tb_KQ";
            tb_KQ.Size = new Size(384, 132);
            tb_KQ.TabIndex = 11;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(clb_ghe);
            Controls.Add(tb_TenKhach);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_DatVe);
            Controls.Add(cb_Phong);
            Controls.Add(cb_Phim);
            Name = "Client";
            Text = "Quản Lý Phòng Vé";
            FormClosing += Client_FormClosing;
            Load += Client_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_Phim;
        private ComboBox cb_Phong;
        private Button btn_DatVe;
        private Button btn_Xoa;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tb_TenKhach;
        private CheckedListBox clb_ghe;
        private GroupBox groupBox1;
        private TextBox tb_KQ;
    }
}