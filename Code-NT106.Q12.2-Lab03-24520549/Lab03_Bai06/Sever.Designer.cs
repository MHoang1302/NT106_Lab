namespace Lab03_Bai06
{
    partial class Sever
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
            btn_Listen = new Button();
            lv_Message = new ListView();
            columnHeader1 = new ColumnHeader();
            SuspendLayout();
            // 
            // btn_Listen
            // 
            btn_Listen.Location = new Point(646, 41);
            btn_Listen.Name = "btn_Listen";
            btn_Listen.Size = new Size(142, 38);
            btn_Listen.TabIndex = 0;
            btn_Listen.Text = "Listen";
            btn_Listen.UseVisualStyleBackColor = true;
            btn_Listen.Click += btn_Listen_Click;
            // 
            // lv_Message
            // 
            lv_Message.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            lv_Message.Location = new Point(12, 88);
            lv_Message.Name = "lv_Message";
            lv_Message.Size = new Size(776, 350);
            lv_Message.TabIndex = 1;
            lv_Message.UseCompatibleStateImageBehavior = false;
            lv_Message.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Message";
            columnHeader1.Width = 772;
            // 
            // Sever
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lv_Message);
            Controls.Add(btn_Listen);
            Name = "Sever";
            Text = "Sever";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Listen;
        private ListView lv_Message;
        private ColumnHeader columnHeader1;
    }
}