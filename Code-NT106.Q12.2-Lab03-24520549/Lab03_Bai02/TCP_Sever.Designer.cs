namespace Lab03_Bai02
{
    partial class TCP_Sever
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
            btn_Listen = new Button();
            rtb_Message = new RichTextBox();
            SuspendLayout();
            // 
            // btn_Listen
            // 
            btn_Listen.Font = new Font("Segoe UI", 12F);
            btn_Listen.Location = new Point(365, 25);
            btn_Listen.Name = "btn_Listen";
            btn_Listen.Size = new Size(95, 31);
            btn_Listen.TabIndex = 0;
            btn_Listen.Text = "Listen";
            btn_Listen.UseVisualStyleBackColor = true;
            btn_Listen.Click += btn_Listen_Click;
            // 
            // rtb_Message
            // 
            rtb_Message.Location = new Point(12, 71);
            rtb_Message.Name = "rtb_Message";
            rtb_Message.Size = new Size(448, 280);
            rtb_Message.TabIndex = 1;
            rtb_Message.Text = "";
            // 
            // TCP_Sever
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 363);
            Controls.Add(rtb_Message);
            Controls.Add(btn_Listen);
            Name = "TCP_Sever";
            Text = "TCP Sever";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Listen;
        private RichTextBox rtb_Message;
    }
}
