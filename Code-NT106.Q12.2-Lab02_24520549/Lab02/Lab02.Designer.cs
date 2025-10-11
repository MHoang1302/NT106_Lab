namespace Lab02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btn_bai1 = new Button();
            btn_bai2 = new Button();
            btn_bai4 = new Button();
            btn_bai7 = new Button();
            btn_bai6 = new Button();
            btn_bai5 = new Button();
            btn_bai3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            label1.ForeColor = Color.RosyBrown;
            label1.Location = new Point(309, 43);
            label1.Name = "label1";
            label1.Size = new Size(188, 65);
            label1.TabIndex = 0;
            label1.Text = "LAB 02";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_bai1
            // 
            btn_bai1.BackColor = Color.FloralWhite;
            btn_bai1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_bai1.Location = new Point(57, 129);
            btn_bai1.Name = "btn_bai1";
            btn_bai1.Size = new Size(179, 67);
            btn_bai1.TabIndex = 1;
            btn_bai1.Text = "Bài 1";
            btn_bai1.UseVisualStyleBackColor = false;
            btn_bai1.Click += btn_bai1_Click;
            // 
            // btn_bai2
            // 
            btn_bai2.BackColor = Color.FloralWhite;
            btn_bai2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_bai2.Location = new Point(57, 236);
            btn_bai2.Name = "btn_bai2";
            btn_bai2.Size = new Size(179, 67);
            btn_bai2.TabIndex = 2;
            btn_bai2.Text = "Bài 2";
            btn_bai2.UseVisualStyleBackColor = false;
            btn_bai2.Click += btn_bai2_Click;
            // 
            // btn_bai4
            // 
            btn_bai4.BackColor = Color.FloralWhite;
            btn_bai4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_bai4.Location = new Point(309, 236);
            btn_bai4.Name = "btn_bai4";
            btn_bai4.Size = new Size(179, 67);
            btn_bai4.TabIndex = 3;
            btn_bai4.Text = "Bài 4";
            btn_bai4.UseVisualStyleBackColor = false;
            btn_bai4.Click += btn_bai4_Click;
            // 
            // btn_bai7
            // 
            btn_bai7.BackColor = Color.FloralWhite;
            btn_bai7.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_bai7.Location = new Point(576, 334);
            btn_bai7.Name = "btn_bai7";
            btn_bai7.Size = new Size(179, 67);
            btn_bai7.TabIndex = 4;
            btn_bai7.Text = "Bài 7";
            btn_bai7.UseVisualStyleBackColor = false;
            btn_bai7.Click += btn_bai7_Click;
            // 
            // btn_bai6
            // 
            btn_bai6.BackColor = Color.FloralWhite;
            btn_bai6.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_bai6.Location = new Point(576, 236);
            btn_bai6.Name = "btn_bai6";
            btn_bai6.Size = new Size(179, 67);
            btn_bai6.TabIndex = 5;
            btn_bai6.Text = "Bài 6";
            btn_bai6.UseVisualStyleBackColor = false;
            btn_bai6.Click += btn_bai6_Click;
            // 
            // btn_bai5
            // 
            btn_bai5.BackColor = Color.FloralWhite;
            btn_bai5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_bai5.Location = new Point(576, 129);
            btn_bai5.Name = "btn_bai5";
            btn_bai5.Size = new Size(179, 67);
            btn_bai5.TabIndex = 6;
            btn_bai5.Text = "Bài 5";
            btn_bai5.UseVisualStyleBackColor = false;
            btn_bai5.Click += btn_bai5_Click;
            // 
            // btn_bai3
            // 
            btn_bai3.BackColor = Color.FloralWhite;
            btn_bai3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_bai3.Location = new Point(57, 334);
            btn_bai3.Name = "btn_bai3";
            btn_bai3.Size = new Size(179, 67);
            btn_bai3.TabIndex = 7;
            btn_bai3.Text = "Bài 3";
            btn_bai3.UseVisualStyleBackColor = false;
            btn_bai3.Click += btn_bai3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_bai3);
            Controls.Add(btn_bai5);
            Controls.Add(btn_bai6);
            Controls.Add(btn_bai7);
            Controls.Add(btn_bai4);
            Controls.Add(btn_bai2);
            Controls.Add(btn_bai1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Lab 02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_bai1;
        private Button btn_bai2;
        private Button btn_bai4;
        private Button btn_bai7;
        private Button btn_bai6;
        private Button btn_bai5;
        private Button btn_bai3;
    }
}
