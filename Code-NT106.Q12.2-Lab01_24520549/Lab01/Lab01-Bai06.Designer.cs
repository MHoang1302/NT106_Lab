namespace Lab01
{
    partial class Lab01_Bai06
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
            tb_ns = new TextBox();
            btn_tim = new Button();
            btn_xoa = new Button();
            btn_thoat = new Button();
            label2 = new Label();
            tb_ans = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.MediumTurquoise;
            label1.Location = new Point(30, 56);
            label1.Name = "label1";
            label1.Size = new Size(379, 28);
            label1.TabIndex = 0;
            label1.Text = "Nhập Ngày Sinh Của Bạn (MM/DD/YY)";
            // 
            // tb_ns
            // 
            tb_ns.Font = new Font("Segoe UI", 15F);
            tb_ns.Location = new Point(415, 50);
            tb_ns.Name = "tb_ns";
            tb_ns.Size = new Size(262, 34);
            tb_ns.TabIndex = 1;
            // 
            // btn_tim
            // 
            btn_tim.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btn_tim.Location = new Point(43, 131);
            btn_tim.Name = "btn_tim";
            btn_tim.Size = new Size(118, 43);
            btn_tim.TabIndex = 2;
            btn_tim.Text = "Tìm Cung";
            btn_tim.UseVisualStyleBackColor = true;
            btn_tim.Click += btn_tim_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btn_xoa.Location = new Point(325, 131);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(118, 43);
            btn_xoa.TabIndex = 3;
            btn_xoa.Text = "Xoá";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btn_thoat.Location = new Point(586, 131);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(118, 43);
            btn_thoat.TabIndex = 4;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.Sienna;
            label2.Location = new Point(30, 247);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 5;
            label2.Text = "KẾT QUẢ";
            // 
            // tb_ans
            // 
            tb_ans.Font = new Font("Segoe UI", 15F);
            tb_ans.Location = new Point(30, 278);
            tb_ans.Name = "tb_ans";
            tb_ans.Size = new Size(262, 34);
            tb_ans.TabIndex = 6;
            // 
            // Lab01_Bai06
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tb_ans);
            Controls.Add(label2);
            Controls.Add(btn_thoat);
            Controls.Add(btn_xoa);
            Controls.Add(btn_tim);
            Controls.Add(tb_ns);
            Controls.Add(label1);
            Name = "Lab01_Bai06";
            Text = "Bài 6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_ns;
        private Button btn_tim;
        private Button btn_xoa;
        private Button btn_thoat;
        private Label label2;
        private TextBox tb_ans;
    }
}