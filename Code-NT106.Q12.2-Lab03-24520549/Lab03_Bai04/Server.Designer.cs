namespace Lab03_Bai04
{
    partial class Server
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
            lv_Message = new ListView();
            btn_Listen = new Button();
            SuspendLayout();
            // 
            // lv_Message
            // 
            lv_Message.Location = new Point(12, 72);
            lv_Message.Name = "lv_Message";
            lv_Message.Size = new Size(838, 396);
            lv_Message.TabIndex = 0;
            lv_Message.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Listen
            // 
            btn_Listen.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn_Listen.Location = new Point(728, 31);
            btn_Listen.Name = "btn_Listen";
            btn_Listen.Size = new Size(122, 35);
            btn_Listen.TabIndex = 1;
            btn_Listen.Text = "Listen";
            btn_Listen.UseVisualStyleBackColor = true;
            btn_Listen.Click += btn_Listen_Click;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 480);
            Controls.Add(btn_Listen);
            Controls.Add(lv_Message);
            Name = "Server";
            Text = "Server";
            FormClosing += Server_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private ListView lv_Message;
        private Button btn_Listen;
    }
}