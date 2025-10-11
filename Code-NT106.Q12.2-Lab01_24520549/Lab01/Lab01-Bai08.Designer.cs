namespace Lab01
{
    partial class Lab01_Bai08
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
            tb_info = new TextBox();
            tb_list = new TextBox();
            btn_them = new Button();
            btn_tim = new Button();
            btn_xoa = new Button();
            btn_thoat = new Button();
            tb_ans = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = Color.Tomato;
            label1.Location = new Point(32, 45);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập Món Ăn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.ForeColor = Color.LightSalmon;
            label2.Location = new Point(277, 328);
            label2.Name = "label2";
            label2.Size = new Size(218, 25);
            label2.TabIndex = 1;
            label2.Text = "Món Ăn Hôm Nay Ăn Là";
            // 
            // tb_info
            // 
            tb_info.Font = new Font("Segoe UI", 13F);
            tb_info.Location = new Point(169, 45);
            tb_info.Name = "tb_info";
            tb_info.Size = new Size(281, 31);
            tb_info.TabIndex = 2;
            // 
            // tb_list
            // 
            tb_list.Font = new Font("Segoe UI", 13F);
            tb_list.Location = new Point(456, 45);
            tb_list.Multiline = true;
            tb_list.Name = "tb_list";
            tb_list.ScrollBars = ScrollBars.Vertical;
            tb_list.Size = new Size(317, 197);
            tb_list.TabIndex = 3;
            // 
            // btn_them
            // 
            btn_them.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_them.Location = new Point(363, 100);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(87, 39);
            btn_them.TabIndex = 4;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_tim
            // 
            btn_tim.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_tim.Location = new Point(87, 268);
            btn_tim.Name = "btn_tim";
            btn_tim.Size = new Size(87, 39);
            btn_tim.TabIndex = 5;
            btn_tim.Text = "Tìm";
            btn_tim.UseVisualStyleBackColor = true;
            btn_tim.Click += btn_tim_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_xoa.Location = new Point(364, 268);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(87, 39);
            btn_xoa.TabIndex = 6;
            btn_xoa.Text = "Xoá";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_thoat.Location = new Point(640, 268);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(87, 39);
            btn_thoat.TabIndex = 7;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // tb_ans
            // 
            tb_ans.Font = new Font("Segoe UI", 13F);
            tb_ans.Location = new Point(249, 356);
            tb_ans.Name = "tb_ans";
            tb_ans.ReadOnly = true;
            tb_ans.Size = new Size(281, 31);
            tb_ans.TabIndex = 8;
            // 
            // Lab01_Bai08
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tb_ans);
            Controls.Add(btn_thoat);
            Controls.Add(btn_xoa);
            Controls.Add(btn_tim);
            Controls.Add(btn_them);
            Controls.Add(tb_list);
            Controls.Add(tb_info);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab01_Bai08";
            Text = "Bài 8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_info;
        private TextBox tb_list;
        private Button btn_them;
        private Button btn_tim;
        private Button btn_xoa;
        private Button btn_thoat;
        private TextBox tb_ans;
    }
}