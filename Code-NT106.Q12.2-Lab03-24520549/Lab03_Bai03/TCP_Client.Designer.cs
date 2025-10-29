namespace Lab03_Bai03
{
    partial class TCP_Client
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
            rtb_Message = new RichTextBox();
            btn_Connect = new Button();
            btn_Send = new Button();
            btn_Disconnect = new Button();
            SuspendLayout();
            // 
            // rtb_Message
            // 
            rtb_Message.Location = new Point(12, 47);
            rtb_Message.Name = "rtb_Message";
            rtb_Message.Size = new Size(601, 188);
            rtb_Message.TabIndex = 0;
            rtb_Message.Text = "";
            // 
            // btn_Connect
            // 
            btn_Connect.Location = new Point(640, 47);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(148, 38);
            btn_Connect.TabIndex = 1;
            btn_Connect.Text = "Connect";
            btn_Connect.UseVisualStyleBackColor = true;
            btn_Connect.Click += btn_Connect_Click;
            // 
            // btn_Send
            // 
            btn_Send.Location = new Point(640, 124);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(148, 38);
            btn_Send.TabIndex = 2;
            btn_Send.Text = "Send";
            btn_Send.UseVisualStyleBackColor = true;
            btn_Send.Click += btn_Send_Click;
            // 
            // btn_Disconnect
            // 
            btn_Disconnect.Location = new Point(640, 197);
            btn_Disconnect.Name = "btn_Disconnect";
            btn_Disconnect.Size = new Size(148, 38);
            btn_Disconnect.TabIndex = 3;
            btn_Disconnect.Text = "Disconnect";
            btn_Disconnect.UseVisualStyleBackColor = true;
            btn_Disconnect.Click += btn_Disconnect_Click;
            // 
            // TCP_Client
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 247);
            Controls.Add(btn_Disconnect);
            Controls.Add(btn_Send);
            Controls.Add(btn_Connect);
            Controls.Add(rtb_Message);
            Name = "TCP_Client";
            Text = "TCP_Client";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtb_Message;
        private Button btn_Connect;
        private Button btn_Send;
        private Button btn_Disconnect;
    }
}