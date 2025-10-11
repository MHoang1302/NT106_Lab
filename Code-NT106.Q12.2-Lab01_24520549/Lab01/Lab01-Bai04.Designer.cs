namespace Lab01
{
    partial class Lab01_Bai04
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
            panel1 = new Panel();
            clb_seats = new CheckedListBox();
            label5 = new Label();
            label4 = new Label();
            cbb_room = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            btn_mua = new Button();
            cbb_movie = new ComboBox();
            tb_name = new TextBox();
            label1 = new Label();
            btn_xoa = new Button();
            btn_thoat = new Button();
            groupBox1 = new GroupBox();
            tb_kq = new TextBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(clb_seats);
            panel1.Location = new Point(206, 267);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 90);
            panel1.TabIndex = 19;
            // 
            // clb_seats
            // 
            clb_seats.ColumnWidth = 50;
            clb_seats.FormattingEnabled = true;
            clb_seats.Location = new Point(18, 15);
            clb_seats.MultiColumn = true;
            clb_seats.Name = "clb_seats";
            clb_seats.Size = new Size(271, 58);
            clb_seats.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(313, 214);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 18;
            label5.Text = "Screen";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(94, 214);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 17;
            label4.Text = "Ghế";
            // 
            // cbb_room
            // 
            cbb_room.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_room.FormattingEnabled = true;
            cbb_room.Location = new Point(285, 143);
            cbb_room.Name = "cbb_room";
            cbb_room.Size = new Size(143, 29);
            cbb_room.TabIndex = 16;
            cbb_room.SelectedIndexChanged += cbb_room_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(94, 147);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 15;
            label3.Text = "Phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(94, 81);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 14;
            label2.Text = "Phim";
            // 
            // btn_mua
            // 
            btn_mua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_mua.Location = new Point(640, 25);
            btn_mua.Name = "btn_mua";
            btn_mua.Size = new Size(97, 39);
            btn_mua.TabIndex = 13;
            btn_mua.Text = "Mua";
            btn_mua.UseVisualStyleBackColor = true;
            btn_mua.Click += btn_mua_Click;
            // 
            // cbb_movie
            // 
            cbb_movie.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_movie.FormattingEnabled = true;
            cbb_movie.Location = new Point(285, 77);
            cbb_movie.Name = "cbb_movie";
            cbb_movie.Size = new Size(143, 29);
            cbb_movie.TabIndex = 12;
            cbb_movie.SelectedIndexChanged += cbb_movie_SelectedIndexChanged;
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_name.Location = new Point(285, 15);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(143, 29);
            tb_name.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 19);
            label1.Name = "label1";
            label1.Size = new Size(144, 25);
            label1.TabIndex = 10;
            label1.Text = "Tên khách hàng";
            // 
            // btn_xoa
            // 
            btn_xoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_xoa.Location = new Point(640, 88);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(97, 39);
            btn_xoa.TabIndex = 20;
            btn_xoa.Text = "Xoá";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_thoat.Location = new Point(640, 147);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(97, 39);
            btn_thoat.TabIndex = 21;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_kq);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(573, 257);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 171);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN";
            // 
            // tb_kq
            // 
            tb_kq.BackColor = SystemColors.Control;
            tb_kq.BorderStyle = BorderStyle.None;
            tb_kq.Location = new Point(3, 19);
            tb_kq.Multiline = true;
            tb_kq.Name = "tb_kq";
            tb_kq.Size = new Size(191, 146);
            tb_kq.TabIndex = 0;
            // 
            // Lab01_Bai04
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(btn_thoat);
            Controls.Add(btn_xoa);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cbb_room);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_mua);
            Controls.Add(cbb_movie);
            Controls.Add(tb_name);
            Controls.Add(label1);
            Name = "Lab01_Bai04";
            Text = "Bài 4";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label4;
        private ComboBox cbb_room;
        private Label label3;
        private Label label2;
        private Button btn_mua;
        private ComboBox cbb_movie;
        private TextBox tb_name;
        private Label label1;
        private Button btn_xoa;
        private Button btn_thoat;
        private CheckedListBox clb_seats;
        private GroupBox groupBox1;
        private TextBox tb_kq;
    }
}