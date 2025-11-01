namespace Lab03_Bai06
{
    partial class Dashboard
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
            btn_Sever = new Button();
            btn_Client = new Button();
            SuspendLayout();
            // 
            // btn_Sever
            // 
            btn_Sever.Font = new Font("Segoe UI", 18F);
            btn_Sever.Location = new Point(12, 51);
            btn_Sever.Name = "btn_Sever";
            btn_Sever.Size = new Size(209, 73);
            btn_Sever.TabIndex = 0;
            btn_Sever.Text = "Sever";
            btn_Sever.UseVisualStyleBackColor = true;
            btn_Sever.Click += btn_Sever_Click;
            // 
            // btn_Client
            // 
            btn_Client.Font = new Font("Segoe UI", 18F);
            btn_Client.Location = new Point(262, 51);
            btn_Client.Name = "btn_Client";
            btn_Client.Size = new Size(209, 73);
            btn_Client.TabIndex = 1;
            btn_Client.Text = "Client";
            btn_Client.UseVisualStyleBackColor = true;
            btn_Client.Click += btn_Client_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 178);
            Controls.Add(btn_Client);
            Controls.Add(btn_Sever);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Sever;
        private Button btn_Client;
    }
}
