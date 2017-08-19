namespace PDI_Talles.Forms
{
    partial class MainWindow
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
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.originalImage = new System.Windows.Forms.ToolStripMenuItem();
            this.quadrantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.img = new System.Windows.Forms.PictureBox();
            this.img1 = new System.Windows.Forms.PictureBox();
            this.img3 = new System.Windows.Forms.PictureBox();
            this.img4 = new System.Windows.Forms.PictureBox();
            this.img2 = new System.Windows.Forms.PictureBox();
            this.menuStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.quadrantesToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(534, 24);
            this.menuStrip3.TabIndex = 0;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.originalImage});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuItem1.Text = "Start";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = "Upload";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.UploadPiture);
            // 
            // originalImage
            // 
            this.originalImage.Name = "originalImage";
            this.originalImage.Size = new System.Drawing.Size(152, 22);
            this.originalImage.Text = "Original Image";
            this.originalImage.Click += new System.EventHandler(this.GetOriginalImage);
            // 
            // quadrantesToolStripMenuItem
            // 
            this.quadrantesToolStripMenuItem.Name = "quadrantesToolStripMenuItem";
            this.quadrantesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.quadrantesToolStripMenuItem.Text = "Quadrantes";
            this.quadrantesToolStripMenuItem.Click += new System.EventHandler(this.Quadrants);
            // 
            // img
            // 
            this.img.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.img.Location = new System.Drawing.Point(12, 27);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(512, 512);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.img.TabIndex = 1;
            this.img.TabStop = false;
            // 
            // img1
            // 
            this.img1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.img1.Cursor = System.Windows.Forms.Cursors.Default;
            this.img1.Location = new System.Drawing.Point(12, 27);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(256, 256);
            this.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.img1.TabIndex = 2;
            this.img1.TabStop = false;
            this.img1.Visible = false;
            // 
            // img3
            // 
            this.img3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.img3.Location = new System.Drawing.Point(12, 283);
            this.img3.Name = "img3";
            this.img3.Size = new System.Drawing.Size(256, 256);
            this.img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.img3.TabIndex = 3;
            this.img3.TabStop = false;
            this.img3.Visible = false;
            // 
            // img4
            // 
            this.img4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.img4.Location = new System.Drawing.Point(268, 283);
            this.img4.Name = "img4";
            this.img4.Size = new System.Drawing.Size(256, 256);
            this.img4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.img4.TabIndex = 4;
            this.img4.TabStop = false;
            this.img4.Visible = false;
            // 
            // img2
            // 
            this.img2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.img2.Location = new System.Drawing.Point(268, 27);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(256, 256);
            this.img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.img2.TabIndex = 5;
            this.img2.TabStop = false;
            this.img2.Visible = false;
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(534, 551);
            this.Controls.Add(this.img2);
            this.Controls.Add(this.img4);
            this.Controls.Add(this.img3);
            this.Controls.Add(this.img1);
            this.Controls.Add(this.img);
            this.Controls.Add(this.menuStrip3);
            this.MainMenuStrip = this.menuStrip3;
            this.Name = "MainWindow";
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.ToolStripMenuItem originalImage;
        private System.Windows.Forms.ToolStripMenuItem quadrantesToolStripMenuItem;
        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.PictureBox img3;
        private System.Windows.Forms.PictureBox img4;
        private System.Windows.Forms.PictureBox img2;
    }
}