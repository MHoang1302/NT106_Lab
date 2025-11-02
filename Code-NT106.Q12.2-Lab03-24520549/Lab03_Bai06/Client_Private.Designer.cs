namespace Lab03_Bai06
{
    partial class Client_Private
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
            tb_Message = new TextBox();
            btn_Send = new Button();
            SuspendLayout();
            // 
            // lv_Message
            // 
            lv_Message.Location = new Point(12, 12);
            lv_Message.Name = "lv_Message";
            lv_Message.Size = new Size(776, 376);
            lv_Message.TabIndex = 0;
            lv_Message.UseCompatibleStateImageBehavior = false;
            // 
            // tb_Message
            // 
            tb_Message.Location = new Point(12, 406);
            tb_Message.Name = "tb_Message";
            tb_Message.Size = new Size(624, 23);
            tb_Message.TabIndex = 1;
            // 
            // btn_Send
            // 
            btn_Send.Location = new Point(687, 406);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(101, 23);
            btn_Send.TabIndex = 2;
            btn_Send.Text = "Send";
            btn_Send.UseVisualStyleBackColor = true;
            btn_Send.Click += btn_Send_Click;
            // 
            // Client_Private
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Send);
            Controls.Add(tb_Message);
            Controls.Add(lv_Message);
            Name = "Client_Private";
            Text = "Client_Private";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lv_Message;
        private TextBox tb_Message;
        private Button btn_Send;
    }
}