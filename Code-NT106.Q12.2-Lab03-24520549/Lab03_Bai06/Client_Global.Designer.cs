
namespace Lab03_Bai06
{
    partial class Client_Global
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
            tb_Name = new TextBox();
            tb_Message = new TextBox();
            btn_Send = new Button();
            btn_Connect = new Button();
            lb_Participants = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lv_Message = new ListView();
            SuspendLayout();
            // 
            // tb_Name
            // 
            tb_Name.Location = new Point(14, 343);
            tb_Name.Name = "tb_Name";
            tb_Name.Size = new Size(100, 23);
            tb_Name.TabIndex = 1;
            // 
            // tb_Message
            // 
            tb_Message.Location = new Point(12, 403);
            tb_Message.Name = "tb_Message";
            tb_Message.Size = new Size(513, 23);
            tb_Message.TabIndex = 2;
            // 
            // btn_Send
            // 
            btn_Send.Location = new Point(546, 402);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(75, 23);
            btn_Send.TabIndex = 3;
            btn_Send.Text = "Send";
            btn_Send.UseVisualStyleBackColor = true;
            btn_Send.Click += btn_Send_Click;
            // 
            // btn_Connect
            // 
            btn_Connect.Location = new Point(120, 343);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(75, 23);
            btn_Connect.TabIndex = 4;
            btn_Connect.Text = "Connect";
            btn_Connect.UseVisualStyleBackColor = true;
            btn_Connect.Click += btn_Connect_Click;
            // 
            // lb_Participants
            // 
            lb_Participants.FormattingEnabled = true;
            lb_Participants.Location = new Point(668, 42);
            lb_Participants.Name = "lb_Participants";
            lb_Participants.Size = new Size(120, 379);
            lb_Participants.TabIndex = 5;
            lb_Participants.SelectedIndexChanged += lb_Participants_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 325);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 6;
            label1.Text = "Your name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 385);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 7;
            label2.Text = "Message";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(668, 15);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 8;
            label3.Text = "Participants";
            // 
            // lv_Message
            // 
            lv_Message.Location = new Point(12, 42);
            lv_Message.Name = "lv_Message";
            lv_Message.Size = new Size(609, 280);
            lv_Message.TabIndex = 9;
            lv_Message.UseCompatibleStateImageBehavior = false;
            // 
            // Client_Global
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lv_Message);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lb_Participants);
            Controls.Add(btn_Connect);
            Controls.Add(btn_Send);
            Controls.Add(tb_Message);
            Controls.Add(tb_Name);
            Name = "Client_Global";
            Text = "Client";
            FormClosed += Client_Global_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tb_Name;
        private TextBox tb_Message;
        private Button btn_Send;
        private Button btn_Connect;
        private ListBox lb_Participants;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListView lv_Message;
    }
}