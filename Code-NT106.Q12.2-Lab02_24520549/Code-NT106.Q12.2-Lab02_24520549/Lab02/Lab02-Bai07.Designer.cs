namespace Lab02
{
    partial class Lab02_Bai07
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
            tv_folder = new TreeView();
            gb_content = new GroupBox();
            pb_info = new PictureBox();
            rtb_info = new RichTextBox();
            gb_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_info).BeginInit();
            SuspendLayout();
            // 
            // tv_folder
            // 
            tv_folder.Location = new Point(10, 9);
            tv_folder.Margin = new Padding(3, 2, 3, 2);
            tv_folder.Name = "tv_folder";
            tv_folder.Size = new Size(210, 348);
            tv_folder.TabIndex = 0;
            tv_folder.BeforeExpand += tv_folder_BeforeExpand;
            tv_folder.AfterSelect += tv_folder_AfterSelect;
            // 
            // gb_content
            // 
            gb_content.Controls.Add(pb_info);
            gb_content.Controls.Add(rtb_info);
            gb_content.Location = new Point(225, 9);
            gb_content.Margin = new Padding(3, 2, 3, 2);
            gb_content.Name = "gb_content";
            gb_content.Padding = new Padding(3, 2, 3, 2);
            gb_content.Size = new Size(540, 347);
            gb_content.TabIndex = 1;
            gb_content.TabStop = false;
            gb_content.Text = "File Content";
            // 
            // pb_info
            // 
            pb_info.Location = new Point(5, 20);
            pb_info.Margin = new Padding(3, 2, 3, 2);
            pb_info.Name = "pb_info";
            pb_info.Size = new Size(529, 328);
            pb_info.TabIndex = 2;
            pb_info.TabStop = false;
            // 
            // rtb_info
            // 
            rtb_info.Location = new Point(5, 20);
            rtb_info.Margin = new Padding(3, 2, 3, 2);
            rtb_info.Name = "rtb_info";
            rtb_info.Size = new Size(530, 324);
            rtb_info.TabIndex = 2;
            rtb_info.Text = "";
            // 
            // Lab02_Bai07
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 365);
            Controls.Add(gb_content);
            Controls.Add(tv_folder);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Lab02_Bai07";
            Text = "Bài 7";
            Load += Lab02_Bai07_Load;
            gb_content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_info).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TreeView tv_folder;
        private GroupBox gb_content;
        private PictureBox pb_info;
        private RichTextBox rtb_info;
    }
}