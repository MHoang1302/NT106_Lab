namespace Lab02
{
    partial class Lab02_Bai06
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
            lv_food = new ListView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tb_tenmonan = new TextBox();
            tb_tennguoidonggop = new TextBox();
            tb_quyenhan = new TextBox();
            tb_linkhinhanh = new TextBox();
            btn_themmon = new Button();
            btn_chonmon = new Button();
            btn_xoa = new Button();
            btn_thoat = new Button();
            SuspendLayout();
            // 
            // lv_food
            // 
            lv_food.Location = new Point(413, 94);
            lv_food.Name = "lv_food";
            lv_food.Size = new Size(375, 252);
            lv_food.TabIndex = 0;
            lv_food.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = Color.DarkMagenta;
            label1.Location = new Point(12, 94);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 1;
            label1.Text = "Tên món ăn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.ForeColor = Color.DarkMagenta;
            label2.Location = new Point(12, 178);
            label2.Name = "label2";
            label2.Size = new Size(184, 25);
            label2.TabIndex = 2;
            label2.Text = "Tên người đóng góp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.ForeColor = Color.DarkMagenta;
            label3.Location = new Point(12, 251);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 3;
            label3.Text = "Quyền hạn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label4.ForeColor = Color.DarkMagenta;
            label4.Location = new Point(12, 321);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 4;
            label4.Text = "Link hình ảnh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(279, 31);
            label5.Name = "label5";
            label5.Size = new Size(218, 30);
            label5.TabIndex = 5;
            label5.Text = "Hôm Nay Ăn Gì ????";
            // 
            // tb_tenmonan
            // 
            tb_tenmonan.Font = new Font("Segoe UI", 13F);
            tb_tenmonan.Location = new Point(203, 91);
            tb_tenmonan.Name = "tb_tenmonan";
            tb_tenmonan.Size = new Size(187, 31);
            tb_tenmonan.TabIndex = 6;
            // 
            // tb_tennguoidonggop
            // 
            tb_tennguoidonggop.Font = new Font("Segoe UI", 13F);
            tb_tennguoidonggop.Location = new Point(203, 175);
            tb_tennguoidonggop.Name = "tb_tennguoidonggop";
            tb_tennguoidonggop.Size = new Size(187, 31);
            tb_tennguoidonggop.TabIndex = 7;
            // 
            // tb_quyenhan
            // 
            tb_quyenhan.Font = new Font("Segoe UI", 13F);
            tb_quyenhan.Location = new Point(203, 248);
            tb_quyenhan.Name = "tb_quyenhan";
            tb_quyenhan.Size = new Size(187, 31);
            tb_quyenhan.TabIndex = 8;
            // 
            // tb_linkhinhanh
            // 
            tb_linkhinhanh.Font = new Font("Segoe UI", 13F);
            tb_linkhinhanh.Location = new Point(203, 318);
            tb_linkhinhanh.Name = "tb_linkhinhanh";
            tb_linkhinhanh.Size = new Size(187, 31);
            tb_linkhinhanh.TabIndex = 13;
            // 
            // btn_themmon
            // 
            btn_themmon.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_themmon.Location = new Point(12, 401);
            btn_themmon.Name = "btn_themmon";
            btn_themmon.Size = new Size(153, 44);
            btn_themmon.TabIndex = 14;
            btn_themmon.Text = "Thêm Món Ăn";
            btn_themmon.UseVisualStyleBackColor = true;
            btn_themmon.Click += btn_themmon_Click;
            // 
            // btn_chonmon
            // 
            btn_chonmon.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_chonmon.ForeColor = SystemColors.ControlText;
            btn_chonmon.Location = new Point(214, 401);
            btn_chonmon.Name = "btn_chonmon";
            btn_chonmon.Size = new Size(153, 44);
            btn_chonmon.TabIndex = 15;
            btn_chonmon.Text = "Chọn Món Ăn";
            btn_chonmon.UseVisualStyleBackColor = true;
            btn_chonmon.Click += btn_chonmon_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_xoa.Location = new Point(430, 401);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(153, 44);
            btn_xoa.TabIndex = 16;
            btn_xoa.Text = "Xoá thông tin";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_thoat.Location = new Point(619, 401);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(153, 44);
            btn_thoat.TabIndex = 17;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // Lab02_Bai06
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 589);
            Controls.Add(btn_thoat);
            Controls.Add(btn_xoa);
            Controls.Add(btn_chonmon);
            Controls.Add(btn_themmon);
            Controls.Add(tb_linkhinhanh);
            Controls.Add(tb_quyenhan);
            Controls.Add(tb_tennguoidonggop);
            Controls.Add(tb_tenmonan);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lv_food);
            Name = "Lab02_Bai06";
            Text = "Bài 6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lv_food;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tb_tenmonan;
        private TextBox tb_tennguoidonggop;
        private TextBox tb_quyenhan;
        private TextBox tb_linkhinhanh;
        private Button btn_themmon;
        private Button btn_chonmon;
        private Button btn_xoa;
        private Button btn_thoat;
    }
}