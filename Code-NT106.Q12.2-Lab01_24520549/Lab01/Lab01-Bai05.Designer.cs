namespace Lab01
{
    partial class Lab01_Bai05
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
            tb_num1 = new TextBox();
            tb_num2 = new TextBox();
            cb_choice = new ComboBox();
            btn_tinh = new Button();
            btn_xoa = new Button();
            btn_thoat = new Button();
            groupBox1 = new GroupBox();
            tb_ans = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Tomato;
            label1.Location = new Point(54, 54);
            label1.Name = "label1";
            label1.Size = new Size(83, 28);
            label1.TabIndex = 0;
            label1.Text = "Nhập A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.Tomato;
            label2.Location = new Point(432, 54);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 1;
            label2.Text = "Nhập B";
            // 
            // tb_num1
            // 
            tb_num1.Font = new Font("Segoe UI", 15F);
            tb_num1.Location = new Point(143, 48);
            tb_num1.Name = "tb_num1";
            tb_num1.Size = new Size(179, 34);
            tb_num1.TabIndex = 2;
            // 
            // tb_num2
            // 
            tb_num2.Font = new Font("Segoe UI", 15F);
            tb_num2.Location = new Point(520, 48);
            tb_num2.Name = "tb_num2";
            tb_num2.Size = new Size(179, 34);
            tb_num2.TabIndex = 3;
            // 
            // cb_choice
            // 
            cb_choice.Font = new Font("Segoe UI", 15F);
            cb_choice.FormattingEnabled = true;
            cb_choice.Items.AddRange(new object[] { "Bảng cửu chương", "Tính toán giá trị" });
            cb_choice.Location = new Point(285, 138);
            cb_choice.Name = "cb_choice";
            cb_choice.Size = new Size(179, 36);
            cb_choice.TabIndex = 4;
            // 
            // btn_tinh
            // 
            btn_tinh.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btn_tinh.Location = new Point(86, 221);
            btn_tinh.Name = "btn_tinh";
            btn_tinh.Size = new Size(171, 47);
            btn_tinh.TabIndex = 5;
            btn_tinh.Text = "Tính các giá trị";
            btn_tinh.UseVisualStyleBackColor = true;
            btn_tinh.Click += btn_tinh_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btn_xoa.Location = new Point(366, 221);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(117, 47);
            btn_xoa.TabIndex = 6;
            btn_xoa.Text = "Xoá";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btn_thoat.Location = new Point(591, 221);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(117, 47);
            btn_thoat.TabIndex = 7;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_ans);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 323);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 246);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "KẾT QUẢ";
            // 
            // tb_ans
            // 
            tb_ans.BorderStyle = BorderStyle.None;
            tb_ans.Location = new Point(6, 28);
            tb_ans.Multiline = true;
            tb_ans.Name = "tb_ans";
            tb_ans.ReadOnly = true;
            tb_ans.ScrollBars = ScrollBars.Vertical;
            tb_ans.Size = new Size(764, 218);
            tb_ans.TabIndex = 9;
            // 
            // Lab01_Bai05
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 581);
            Controls.Add(groupBox1);
            Controls.Add(btn_thoat);
            Controls.Add(btn_xoa);
            Controls.Add(btn_tinh);
            Controls.Add(cb_choice);
            Controls.Add(tb_num2);
            Controls.Add(tb_num1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab01_Bai05";
            Text = "Bài 5";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_num1;
        private TextBox tb_num2;
        private ComboBox cb_choice;
        private Button btn_tinh;
        private Button btn_xoa;
        private Button btn_thoat;
        private GroupBox groupBox1;
        private TextBox tb_ans;
    }
}