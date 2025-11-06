namespace Lab03_Bai05
{
    partial class Dashboard
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
            btn_Client = new Button();
            btn_Server = new Button();
            SuspendLayout();
            // 
            // btn_Client
            // 
            btn_Client.Font = new Font("Segoe UI", 14F);
            btn_Client.Location = new Point(12, 41);
            btn_Client.Name = "btn_Client";
            btn_Client.Size = new Size(168, 53);
            btn_Client.TabIndex = 0;
            btn_Client.Text = "Client";
            btn_Client.UseVisualStyleBackColor = true;
            btn_Client.Click += btn_Client_Click;
            // 
            // btn_Server
            // 
            btn_Server.Font = new Font("Segoe UI", 14F);
            btn_Server.Location = new Point(228, 41);
            btn_Server.Name = "btn_Server";
            btn_Server.Size = new Size(168, 53);
            btn_Server.TabIndex = 1;
            btn_Server.Text = "Server";
            btn_Server.UseVisualStyleBackColor = true;
            btn_Server.Click += btn_Server_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 127);
            Controls.Add(btn_Server);
            Controls.Add(btn_Client);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Client;
        private Button btn_Server;
    }
}