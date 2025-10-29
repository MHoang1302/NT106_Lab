namespace NT106.Q12._2_Lab03_24520549
{
    partial class UDP_Sever
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
            btn_Listen = new Button();
            tb_Port = new TextBox();
            rtb_ReceivedMessages = new RichTextBox();
            btn_EndSever = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 37);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Port";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 81);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 1;
            label2.Text = "Received messages";
            // 
            // btn_Listen
            // 
            btn_Listen.Location = new Point(482, 37);
            btn_Listen.Name = "btn_Listen";
            btn_Listen.Size = new Size(116, 38);
            btn_Listen.TabIndex = 2;
            btn_Listen.Text = "Listen";
            btn_Listen.UseVisualStyleBackColor = true;
            btn_Listen.Click += btn_Listen_Click;
            // 
            // tb_Port
            // 
            tb_Port.Location = new Point(105, 34);
            tb_Port.Name = "tb_Port";
            tb_Port.Size = new Size(150, 23);
            tb_Port.TabIndex = 3;
            // 
            // rtb_ReceivedMessages
            // 
            rtb_ReceivedMessages.Location = new Point(56, 108);
            rtb_ReceivedMessages.Name = "rtb_ReceivedMessages";
            rtb_ReceivedMessages.Size = new Size(682, 335);
            rtb_ReceivedMessages.TabIndex = 4;
            rtb_ReceivedMessages.Text = "";
            // 
            // btn_EndSever
            // 
            btn_EndSever.Location = new Point(622, 37);
            btn_EndSever.Name = "btn_EndSever";
            btn_EndSever.Size = new Size(116, 38);
            btn_EndSever.TabIndex = 5;
            btn_EndSever.Text = "End Sever";
            btn_EndSever.UseVisualStyleBackColor = true;
            btn_EndSever.Click += btn_EndSever_Click;
            // 
            // UDP_Sever
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 470);
            Controls.Add(btn_EndSever);
            Controls.Add(rtb_ReceivedMessages);
            Controls.Add(tb_Port);
            Controls.Add(btn_Listen);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UDP_Sever";
            Text = "UDP Sever";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn_Listen;
        private TextBox tb_Port;
        private RichTextBox rtb_ReceivedMessages;
        private Button btn_EndSever;
    }
}