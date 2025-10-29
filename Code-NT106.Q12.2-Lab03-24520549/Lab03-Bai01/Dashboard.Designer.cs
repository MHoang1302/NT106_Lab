namespace NT106.Q12._2_Lab03_24520549
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
            btn_UdpSever = new Button();
            btn_UdpClient = new Button();
            SuspendLayout();
            // 
            // btn_UdpSever
            // 
            btn_UdpSever.Location = new Point(12, 31);
            btn_UdpSever.Name = "btn_UdpSever";
            btn_UdpSever.Size = new Size(220, 59);
            btn_UdpSever.TabIndex = 1;
            btn_UdpSever.Text = "UDP Sever";
            btn_UdpSever.UseVisualStyleBackColor = true;
            btn_UdpSever.Click += btn_UdpSever_Click;
            // 
            // btn_UdpClient
            // 
            btn_UdpClient.Location = new Point(383, 31);
            btn_UdpClient.Name = "btn_UdpClient";
            btn_UdpClient.Size = new Size(220, 59);
            btn_UdpClient.TabIndex = 2;
            btn_UdpClient.Text = "UDP Client";
            btn_UdpClient.UseVisualStyleBackColor = true;
            btn_UdpClient.Click += btn_UdpClient_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 124);
            Controls.Add(btn_UdpClient);
            Controls.Add(btn_UdpSever);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_UdpSever;
        private Button btn_UdpClient;
    }
}
