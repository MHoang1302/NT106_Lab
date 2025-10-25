namespace Lab02
{
    partial class Lab02_Bai01
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
            btn_ghi = new Button();
            btn_doc = new Button();
            rtb_ans = new RichTextBox();
            btn_thoat = new Button();
            SuspendLayout();
            // 
            // btn_ghi
            // 
            btn_ghi.BackColor = Color.AliceBlue;
            btn_ghi.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btn_ghi.Location = new Point(35, 182);
            btn_ghi.Name = "btn_ghi";
            btn_ghi.Size = new Size(138, 69);
            btn_ghi.TabIndex = 0;
            btn_ghi.Text = "Ghi File";
            btn_ghi.UseVisualStyleBackColor = false;
            btn_ghi.Click += btn_ghi_Click;
            // 
            // btn_doc
            // 
            btn_doc.BackColor = Color.AliceBlue;
            btn_doc.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btn_doc.Location = new Point(35, 54);
            btn_doc.Name = "btn_doc";
            btn_doc.Size = new Size(138, 69);
            btn_doc.TabIndex = 1;
            btn_doc.Text = "Đọc File";
            btn_doc.UseVisualStyleBackColor = false;
            btn_doc.Click += btn_doc_Click;
            // 
            // rtb_ans
            // 
            rtb_ans.BackColor = Color.AliceBlue;
            rtb_ans.Location = new Point(234, 20);
            rtb_ans.Name = "rtb_ans";
            rtb_ans.Size = new Size(554, 418);
            rtb_ans.TabIndex = 3;
            rtb_ans.Text = "";
            // 
            // btn_thoat
            // 
            btn_thoat.BackColor = Color.AliceBlue;
            btn_thoat.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btn_thoat.Location = new Point(35, 311);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(138, 69);
            btn_thoat.TabIndex = 4;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = false;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // Lab02_Bai01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_thoat);
            Controls.Add(rtb_ans);
            Controls.Add(btn_doc);
            Controls.Add(btn_ghi);
            Name = "Lab02_Bai01";
            Text = "Bài 1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_ghi;
        private Button btn_doc;
        private RichTextBox rtb_ans;
        private Button btn_thoat;
    }
}