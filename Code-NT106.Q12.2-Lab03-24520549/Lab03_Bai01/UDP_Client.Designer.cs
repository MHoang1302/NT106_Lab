namespace NT106.Q12._2_Lab03_24520549
{
    partial class UDP_Client
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
            label3 = new Label();
            tb_IpRemote = new TextBox();
            tb_Port = new TextBox();
            btn_Send = new Button();
            rtb_Message = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 45);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "IP Remote host";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 137);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Message";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(394, 45);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 2;
            label3.Text = "Port";
            // 
            // tb_IpRemote
            // 
            tb_IpRemote.Location = new Point(69, 80);
            tb_IpRemote.Name = "tb_IpRemote";
            tb_IpRemote.Size = new Size(301, 23);
            tb_IpRemote.TabIndex = 3;
            // 
            // tb_Port
            // 
            tb_Port.Location = new Point(394, 80);
            tb_Port.Name = "tb_Port";
            tb_Port.Size = new Size(229, 23);
            tb_Port.TabIndex = 4;
            // 
            // btn_Send
            // 
            btn_Send.Location = new Point(69, 326);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(104, 23);
            btn_Send.TabIndex = 6;
            btn_Send.Text = "Send";
            btn_Send.UseVisualStyleBackColor = true;
            btn_Send.Click += btn_Send_Click;
            // 
            // rtb_Message
            // 
            rtb_Message.Location = new Point(69, 166);
            rtb_Message.Name = "rtb_Message";
            rtb_Message.Size = new Size(554, 154);
            rtb_Message.TabIndex = 7;
            rtb_Message.Text = "";
            // 
            // UDP_Client
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 361);
            Controls.Add(rtb_Message);
            Controls.Add(btn_Send);
            Controls.Add(tb_Port);
            Controls.Add(tb_IpRemote);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UDP_Client";
            Text = "UDP_Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tb_IpRemote;
        private TextBox tb_Port;
        private Button btn_Send;
        private RichTextBox rtb_Message;
    }
}