namespace Lab01
{
    partial class Lab01_Bai01
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
            tb_num1 = new TextBox();
            tb_num2 = new TextBox();
            tb_ans = new TextBox();
            btn_tinh = new Button();
            btn_xoa = new Button();
            btn_thoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Salmon;
            label1.Location = new Point(289, 40);
            label1.Name = "label1";
            label1.Size = new Size(263, 28);
            label1.TabIndex = 0;
            label1.Text = "TÍNH TỔNG 2 SỐ NGUYÊN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(76, 108);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 1;
            label2.Text = "Số thứ nhất";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(76, 196);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 2;
            label3.Text = "Số thứ hai";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(76, 315);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 3;
            label4.Text = "Kết quả";
            // 
            // tb_num1
            // 
            tb_num1.Font = new Font("Segoe UI", 13F);
            tb_num1.Location = new Point(207, 111);
            tb_num1.Name = "tb_num1";
            tb_num1.Size = new Size(224, 31);
            tb_num1.TabIndex = 4;
            // 
            // tb_num2
            // 
            tb_num2.Font = new Font("Segoe UI", 13F);
            tb_num2.Location = new Point(207, 196);
            tb_num2.Name = "tb_num2";
            tb_num2.Size = new Size(224, 31);
            tb_num2.TabIndex = 5;
            // 
            // tb_ans
            // 
            tb_ans.Enabled = false;
            tb_ans.Font = new Font("Segoe UI", 13F);
            tb_ans.Location = new Point(207, 318);
            tb_ans.Name = "tb_ans";
            tb_ans.Size = new Size(224, 31);
            tb_ans.TabIndex = 6;
            // 
            // btn_tinh
            // 
            btn_tinh.Location = new Point(207, 248);
            btn_tinh.Name = "btn_tinh";
            btn_tinh.Size = new Size(89, 44);
            btn_tinh.TabIndex = 7;
            btn_tinh.Text = "Tính";
            btn_tinh.UseVisualStyleBackColor = true;
            btn_tinh.Click += btn_tinh_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(379, 248);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(86, 44);
            btn_xoa.TabIndex = 8;
            btn_xoa.Text = "Xoá";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Location = new Point(535, 248);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(81, 44);
            btn_thoat.TabIndex = 9;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // Lab01_Bai01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_thoat);
            Controls.Add(btn_xoa);
            Controls.Add(btn_tinh);
            Controls.Add(tb_ans);
            Controls.Add(tb_num2);
            Controls.Add(tb_num1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab01_Bai01";
            Text = "Bài 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tb_num1;
        private TextBox tb_num2;
        private TextBox tb_ans;
        private Button btn_tinh;
        private Button btn_xoa;
        private Button btn_thoat;
    }
}