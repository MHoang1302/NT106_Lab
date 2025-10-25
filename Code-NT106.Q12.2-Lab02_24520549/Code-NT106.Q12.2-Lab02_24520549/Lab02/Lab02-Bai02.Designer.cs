namespace Lab02
{
    partial class Lab02_Bai02
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
            rtb_ans = new RichTextBox();
            btn_doc = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tb_name = new TextBox();
            tb_cc = new TextBox();
            tb_wc = new TextBox();
            tb_lc = new TextBox();
            tb_url = new TextBox();
            tb_size = new TextBox();
            btn_thoat = new Button();
            SuspendLayout();
            // 
            // rtb_ans
            // 
            rtb_ans.BackColor = Color.DimGray;
            rtb_ans.Location = new Point(348, 12);
            rtb_ans.Name = "rtb_ans";
            rtb_ans.Size = new Size(554, 418);
            rtb_ans.TabIndex = 6;
            rtb_ans.Text = "";
            // 
            // btn_doc
            // 
            btn_doc.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn_doc.Location = new Point(12, 21);
            btn_doc.Name = "btn_doc";
            btn_doc.Size = new Size(330, 32);
            btn_doc.TabIndex = 7;
            btn_doc.Text = "Read from File";
            btn_doc.UseVisualStyleBackColor = true;
            btn_doc.Click += btn_doc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(12, 82);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 8;
            label1.Text = "File name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(12, 306);
            label2.Name = "label2";
            label2.Size = new Size(131, 21);
            label2.TabIndex = 9;
            label2.Text = "Character count";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(12, 255);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 10;
            label3.Text = "Words count";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(12, 206);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 11;
            label4.Text = "Line count";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(12, 163);
            label5.Name = "label5";
            label5.Size = new Size(40, 21);
            label5.TabIndex = 12;
            label5.Text = "URL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(12, 122);
            label6.Name = "label6";
            label6.Size = new Size(41, 21);
            label6.TabIndex = 13;
            label6.Text = "Size";
            // 
            // tb_name
            // 
            tb_name.ForeColor = Color.RoyalBlue;
            tb_name.Location = new Point(170, 84);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(172, 23);
            tb_name.TabIndex = 14;
            // 
            // tb_cc
            // 
            tb_cc.ForeColor = Color.RoyalBlue;
            tb_cc.Location = new Point(170, 308);
            tb_cc.Name = "tb_cc";
            tb_cc.Size = new Size(172, 23);
            tb_cc.TabIndex = 16;
            // 
            // tb_wc
            // 
            tb_wc.ForeColor = Color.RoyalBlue;
            tb_wc.Location = new Point(170, 257);
            tb_wc.Name = "tb_wc";
            tb_wc.Size = new Size(172, 23);
            tb_wc.TabIndex = 17;
            // 
            // tb_lc
            // 
            tb_lc.ForeColor = Color.RoyalBlue;
            tb_lc.Location = new Point(170, 208);
            tb_lc.Name = "tb_lc";
            tb_lc.Size = new Size(172, 23);
            tb_lc.TabIndex = 18;
            // 
            // tb_url
            // 
            tb_url.ForeColor = Color.RoyalBlue;
            tb_url.Location = new Point(170, 165);
            tb_url.Name = "tb_url";
            tb_url.Size = new Size(172, 23);
            tb_url.TabIndex = 19;
            // 
            // tb_size
            // 
            tb_size.ForeColor = Color.RoyalBlue;
            tb_size.Location = new Point(170, 124);
            tb_size.Name = "tb_size";
            tb_size.Size = new Size(172, 23);
            tb_size.TabIndex = 20;
            // 
            // btn_thoat
            // 
            btn_thoat.BackColor = Color.GreenYellow;
            btn_thoat.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn_thoat.Location = new Point(12, 398);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(330, 32);
            btn_thoat.TabIndex = 21;
            btn_thoat.Text = "Exit";
            btn_thoat.UseVisualStyleBackColor = false;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // Lab02_Bai02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(914, 450);
            Controls.Add(btn_thoat);
            Controls.Add(tb_size);
            Controls.Add(tb_url);
            Controls.Add(tb_lc);
            Controls.Add(tb_wc);
            Controls.Add(tb_cc);
            Controls.Add(tb_name);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_doc);
            Controls.Add(rtb_ans);
            Name = "Lab02_Bai02";
            Text = "Bài 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtb_ans;
        private Button btn_doc;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tb_name;
        private TextBox tb_cc;
        private TextBox tb_wc;
        private TextBox tb_lc;
        private TextBox tb_url;
        private TextBox tb_size;
        private Button btn_thoat;
    }
}