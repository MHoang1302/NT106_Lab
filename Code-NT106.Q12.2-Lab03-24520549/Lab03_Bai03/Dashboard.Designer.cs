
namespace Lab03_Bai03
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
            btn_Sever.Location = new Point(12, 12);
            btn_Sever.Name = "btn_Sever";
            btn_Sever.Size = new Size(369, 29);
            btn_Sever.TabIndex = 0;
            btn_Sever.Text = "Open TCP Sever";
            btn_Sever.UseVisualStyleBackColor = true;
            btn_Sever.Click += this.btn_Sever_Click;
            // 
            // btn_Client
            // 
            btn_Client.Location = new Point(12, 69);
            btn_Client.Name = "btn_Client";
            btn_Client.Size = new Size(369, 29);
            btn_Client.TabIndex = 1;
            btn_Client.Text = "Open new TCP Client";
            btn_Client.UseVisualStyleBackColor = true;
            btn_Client.Click += this.btn_Client_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 110);
            Controls.Add(btn_Client);
            Controls.Add(btn_Sever);
            Name = "Dashboard";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Sever;
        private Button btn_Client;
    }
}
