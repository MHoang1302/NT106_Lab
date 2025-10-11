namespace Lab02
{
    partial class Lab02_Bai03
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
            btn_doc = new Button();
            btn_tinh = new Button();
            btn_ghi = new Button();
            btn_thoat = new Button();
            rtb_ans = new RichTextBox();
            SuspendLayout();
            // 
            // btn_doc
            // 
            btn_doc.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btn_doc.Location = new Point(29, 39);
            btn_doc.Name = "btn_doc";
            btn_doc.Size = new Size(135, 52);
            btn_doc.TabIndex = 0;
            btn_doc.Text = "Đọc File";
            btn_doc.UseVisualStyleBackColor = true;
            btn_doc.Click += btn_doc_Click;
            // 
            // btn_tinh
            // 
            btn_tinh.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btn_tinh.Location = new Point(29, 127);
            btn_tinh.Name = "btn_tinh";
            btn_tinh.Size = new Size(135, 52);
            btn_tinh.TabIndex = 1;
            btn_tinh.Text = "Tính";
            btn_tinh.UseVisualStyleBackColor = true;
            btn_tinh.Click += btn_tinh_Click;
            // 
            // btn_ghi
            // 
            btn_ghi.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btn_ghi.Location = new Point(29, 222);
            btn_ghi.Name = "btn_ghi";
            btn_ghi.Size = new Size(135, 52);
            btn_ghi.TabIndex = 2;
            btn_ghi.Text = "Ghi File";
            btn_ghi.UseVisualStyleBackColor = true;
            btn_ghi.Click += btn_ghi_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btn_thoat.Location = new Point(29, 314);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(135, 52);
            btn_thoat.TabIndex = 3;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // rtb_ans
            // 
            rtb_ans.Location = new Point(277, 39);
            rtb_ans.Name = "rtb_ans";
            rtb_ans.Size = new Size(511, 377);
            rtb_ans.TabIndex = 4;
            rtb_ans.Text = "";
            // 
            // Lab02_Bai03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtb_ans);
            Controls.Add(btn_thoat);
            Controls.Add(btn_ghi);
            Controls.Add(btn_tinh);
            Controls.Add(btn_doc);
            Name = "Lab02_Bai03";
            Text = "Bài 3";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_doc;
        private Button btn_tinh;
        private Button btn_ghi;
        private Button btn_thoat;
        private RichTextBox rtb_ans;
    }
}