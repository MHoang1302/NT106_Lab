namespace Lab01
{
    partial class Lab01_Bai07
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
            tb_info = new TextBox();
            btn_tracuu = new Button();
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
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(39, 45);
            label1.Name = "label1";
            label1.Size = new Size(260, 28);
            label1.TabIndex = 0;
            label1.Text = "Nhập Thông Tin Sinh Viên";
            // 
            // tb_info
            // 
            tb_info.Font = new Font("Segoe UI", 15F);
            tb_info.Location = new Point(39, 98);
            tb_info.Name = "tb_info";
            tb_info.Size = new Size(749, 34);
            tb_info.TabIndex = 1;
            // 
            // btn_tracuu
            // 
            btn_tracuu.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btn_tracuu.Location = new Point(60, 154);
            btn_tracuu.Name = "btn_tracuu";
            btn_tracuu.Size = new Size(172, 57);
            btn_tracuu.TabIndex = 3;
            btn_tracuu.Text = "Tra Cứu";
            btn_tracuu.UseVisualStyleBackColor = true;
            btn_tracuu.Click += btn_tracuu_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btn_xoa.Location = new Point(372, 154);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(105, 57);
            btn_xoa.TabIndex = 4;
            btn_xoa.Text = "Xoá";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btn_thoat.Location = new Point(604, 154);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(105, 57);
            btn_thoat.TabIndex = 5;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_ans);
            groupBox1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            groupBox1.ForeColor = Color.MediumBlue;
            groupBox1.Location = new Point(12, 261);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 372);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kết Quả Trả Về";
            // 
            // tb_ans
            // 
            tb_ans.BorderStyle = BorderStyle.None;
            tb_ans.Font = new Font("Segoe UI", 11F);
            tb_ans.Location = new Point(6, 33);
            tb_ans.Multiline = true;
            tb_ans.Name = "tb_ans";
            tb_ans.ReadOnly = true;
            tb_ans.ScrollBars = ScrollBars.Vertical;
            tb_ans.Size = new Size(764, 333);
            tb_ans.TabIndex = 2;
            // 
            // Lab01_Bai07
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 639);
            Controls.Add(groupBox1);
            Controls.Add(btn_thoat);
            Controls.Add(btn_xoa);
            Controls.Add(btn_tracuu);
            Controls.Add(tb_info);
            Controls.Add(label1);
            Name = "Lab01_Bai07";
            Text = "Bài 7";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_info;
        private Button btn_tracuu;
        private Button btn_xoa;
        private Button btn_thoat;
        private GroupBox groupBox1;
        private TextBox tb_ans;
    }
}