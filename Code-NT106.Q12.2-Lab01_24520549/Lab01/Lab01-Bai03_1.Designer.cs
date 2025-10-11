namespace Lab01
{
    partial class Lab01_Bai03_1
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
            btn_thoat = new Button();
            btn_xoa = new Button();
            btn_doc = new Button();
            tb_ans = new TextBox();
            tb_num = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_thoat
            // 
            btn_thoat.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn_thoat.Location = new Point(627, 229);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(92, 59);
            btn_thoat.TabIndex = 13;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn_xoa.Location = new Point(627, 138);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(92, 59);
            btn_xoa.TabIndex = 12;
            btn_xoa.Text = "Xoá";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_doc
            // 
            btn_doc.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn_doc.Location = new Point(627, 53);
            btn_doc.Name = "btn_doc";
            btn_doc.Size = new Size(92, 59);
            btn_doc.TabIndex = 11;
            btn_doc.Text = "Đọc";
            btn_doc.UseVisualStyleBackColor = true;
            btn_doc.Click += btn_doc_Click;
            // 
            // tb_ans
            // 
            tb_ans.Font = new Font("Segoe UI", 10F);
            tb_ans.Location = new Point(85, 307);
            tb_ans.Name = "tb_ans";
            tb_ans.ReadOnly = true;
            tb_ans.ScrollBars = ScrollBars.Horizontal;
            tb_ans.Size = new Size(703, 25);
            tb_ans.TabIndex = 10;
            // 
            // tb_num
            // 
            tb_num.Font = new Font("Segoe UI", 15F);
            tb_num.Location = new Point(85, 144);
            tb_num.Name = "tb_num";
            tb_num.Size = new Size(299, 34);
            tb_num.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.SandyBrown;
            label2.Location = new Point(85, 251);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 8;
            label2.Text = "Kết Quả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.SandyBrown;
            label1.Location = new Point(85, 97);
            label1.Name = "label1";
            label1.Size = new Size(218, 28);
            label1.TabIndex = 7;
            label1.Text = "Nhập Vào Số Nguyên ";
            // 
            // Lab01_Bai03_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_thoat);
            Controls.Add(btn_xoa);
            Controls.Add(btn_doc);
            Controls.Add(tb_ans);
            Controls.Add(tb_num);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab01_Bai03_1";
            Text = "Bài 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_thoat;
        private Button btn_xoa;
        private Button btn_doc;
        private TextBox tb_ans;
        private TextBox tb_num;
        private Label label2;
        private Label label1;
    }
}