namespace Lab01
{
    partial class Lab01_Bai03
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
            tb_num = new TextBox();
            tb_ans = new TextBox();
            btn_doc = new Button();
            btn_xoa = new Button();
            btn_thoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.SandyBrown;
            label1.Location = new Point(49, 74);
            label1.Name = "label1";
            label1.Size = new Size(323, 28);
            label1.TabIndex = 0;
            label1.Text = "Nhập Vào Số Nguyên Từ 0 Đến 9";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.SandyBrown;
            label2.Location = new Point(49, 228);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 1;
            label2.Text = "Kết Quả";
            // 
            // tb_num
            // 
            tb_num.Font = new Font("Segoe UI", 15F);
            tb_num.Location = new Point(49, 121);
            tb_num.Name = "tb_num";
            tb_num.Size = new Size(299, 34);
            tb_num.TabIndex = 2;
            // 
            // tb_ans
            // 
            tb_ans.Enabled = false;
            tb_ans.Font = new Font("Segoe UI", 15F);
            tb_ans.Location = new Point(49, 283);
            tb_ans.Name = "tb_ans";
            tb_ans.Size = new Size(280, 34);
            tb_ans.TabIndex = 3;
            // 
            // btn_doc
            // 
            btn_doc.Font = new Font("Segoe UI", 14F);
            btn_doc.Location = new Point(588, 96);
            btn_doc.Name = "btn_doc";
            btn_doc.Size = new Size(92, 59);
            btn_doc.TabIndex = 4;
            btn_doc.Text = "Đọc";
            btn_doc.UseVisualStyleBackColor = true;
            btn_doc.Click += btn_doc_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Font = new Font("Segoe UI", 14F);
            btn_xoa.Location = new Point(588, 181);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(92, 59);
            btn_xoa.TabIndex = 5;
            btn_xoa.Text = "Xoá";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Font = new Font("Segoe UI", 14F);
            btn_thoat.Location = new Point(588, 272);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(92, 59);
            btn_thoat.TabIndex = 6;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // Lab01_Bai03
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
            Name = "Lab01_Bai03";
            Text = "Bài 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_num;
        private TextBox tb_ans;
        private Button btn_doc;
        private Button btn_xoa;
        private Button btn_thoat;
    }
}