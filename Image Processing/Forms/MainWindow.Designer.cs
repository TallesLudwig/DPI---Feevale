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
            this.funçoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.espelhamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rodarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.direitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esquerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reduzirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dobroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtros = new System.Windows.Forms.ToolStripMenuItem();
            this.thresholdingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gausToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prewittToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.img = new System.Windows.Forms.PictureBox();
            this.panelActions = new System.Windows.Forms.Panel();
            this.labelA = new System.Windows.Forms.Label();
            this.btnHistogramA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMediaA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMedianaA = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVarianciaA = new System.Windows.Forms.Label();
            this.lblModaA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.funçoesToolStripMenuItem,
            this.filtros});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(778, 24);
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
            this.toolStripMenuItem3.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItem3.Text = "Upload";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.UploadPiture);
            // 
            // originalImage
            // 
            this.originalImage.Enabled = false;
            this.originalImage.Name = "originalImage";
            this.originalImage.Size = new System.Drawing.Size(163, 22);
            this.originalImage.Text = "Imagem Original";
            this.originalImage.Click += new System.EventHandler(this.GetOriginalImage);
            // 
            // funçoesToolStripMenuItem
            // 
            this.funçoesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.espelhamentoToolStripMenuItem,
            this.rodarToolStripMenuItem,
            this.reduzirToolStripMenuItem,
            this.dobroToolStripMenuItem});
            this.funçoesToolStripMenuItem.Name = "funçoesToolStripMenuItem";
            this.funçoesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.funçoesToolStripMenuItem.Text = "Funçoes";
            this.funçoesToolStripMenuItem.Visible = false;
            // 
            // espelhamentoToolStripMenuItem
            // 
            this.espelhamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem});
            this.espelhamentoToolStripMenuItem.Name = "espelhamentoToolStripMenuItem";
            this.espelhamentoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.espelhamentoToolStripMenuItem.Text = "Espelhamento";
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.HorizontaMirroring_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.VerticalMirroring_Click);
            // 
            // rodarToolStripMenuItem
            // 
            this.rodarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.direitaToolStripMenuItem,
            this.esquerdaToolStripMenuItem});
            this.rodarToolStripMenuItem.Name = "rodarToolStripMenuItem";
            this.rodarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.rodarToolStripMenuItem.Text = "Rodar 90°";
            // 
            // direitaToolStripMenuItem
            // 
            this.direitaToolStripMenuItem.Name = "direitaToolStripMenuItem";
            this.direitaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.direitaToolStripMenuItem.Text = "Direita";
            this.direitaToolStripMenuItem.Click += new System.EventHandler(this.RotateAnticlockwise_Click);
            // 
            // esquerdaToolStripMenuItem
            // 
            this.esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
            this.esquerdaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.esquerdaToolStripMenuItem.Text = "Esquerda";
            this.esquerdaToolStripMenuItem.Click += new System.EventHandler(this.RotateClockwise_Click);
            // 
            // reduzirToolStripMenuItem
            // 
            this.reduzirToolStripMenuItem.Name = "reduzirToolStripMenuItem";
            this.reduzirToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.reduzirToolStripMenuItem.Text = "Reduzir Metade";
            this.reduzirToolStripMenuItem.Click += new System.EventHandler(this.reduzirToolStripMenuItem_Click);
            // 
            // dobroToolStripMenuItem
            // 
            this.dobroToolStripMenuItem.Name = "dobroToolStripMenuItem";
            this.dobroToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.dobroToolStripMenuItem.Text = "Dobro";
            this.dobroToolStripMenuItem.Click += new System.EventHandler(this.dobroToolStripMenuItem_Click);
            // 
            // filtros
            // 
            this.filtros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thresholdingToolStripMenuItem,
            this.gausToolStripMenuItem,
            this.sobelToolStripMenuItem,
            this.prewittToolStripMenuItem});
            this.filtros.Name = "filtros";
            this.filtros.Size = new System.Drawing.Size(51, 20);
            this.filtros.Text = "Filtros";
            this.filtros.Visible = false;
            // 
            // thresholdingToolStripMenuItem
            // 
            this.thresholdingToolStripMenuItem.Name = "thresholdingToolStripMenuItem";
            this.thresholdingToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.thresholdingToolStripMenuItem.Text = "Thresholding";
            this.thresholdingToolStripMenuItem.Click += new System.EventHandler(this.thresholdingToolStripMenuItem_Click);
            // 
            // gausToolStripMenuItem
            // 
            this.gausToolStripMenuItem.Name = "gausToolStripMenuItem";
            this.gausToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.gausToolStripMenuItem.Text = "Gaus";
            this.gausToolStripMenuItem.Click += new System.EventHandler(this.gausToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.sobelToolStripMenuItem.Text = "Sobel";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // prewittToolStripMenuItem
            // 
            this.prewittToolStripMenuItem.Name = "prewittToolStripMenuItem";
            this.prewittToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.prewittToolStripMenuItem.Text = "Prewitt";
            this.prewittToolStripMenuItem.Click += new System.EventHandler(this.prewittToolStripMenuItem_Click);
            // 
            // img
            // 
            this.img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img.Location = new System.Drawing.Point(240, 27);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(512, 512);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img.TabIndex = 1;
            this.img.TabStop = false;
            // 
            // panelActions
            // 
            this.panelActions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelActions.Controls.Add(this.labelA);
            this.panelActions.Controls.Add(this.btnHistogramA);
            this.panelActions.Controls.Add(this.label1);
            this.panelActions.Controls.Add(this.lblMediaA);
            this.panelActions.Controls.Add(this.label2);
            this.panelActions.Controls.Add(this.lblMedianaA);
            this.panelActions.Controls.Add(this.label3);
            this.panelActions.Controls.Add(this.lblVarianciaA);
            this.panelActions.Controls.Add(this.lblModaA);
            this.panelActions.Controls.Add(this.label4);
            this.panelActions.Enabled = false;
            this.panelActions.Location = new System.Drawing.Point(12, 27);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(222, 129);
            this.panelActions.TabIndex = 6;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.Location = new System.Drawing.Point(16, 12);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(32, 13);
            this.labelA.TabIndex = 75;
            this.labelA.Text = "Foto";
            // 
            // btnHistogramA
            // 
            this.btnHistogramA.Location = new System.Drawing.Point(12, 92);
            this.btnHistogramA.Name = "btnHistogramA";
            this.btnHistogramA.Size = new System.Drawing.Size(164, 23);
            this.btnHistogramA.TabIndex = 45;
            this.btnHistogramA.Text = "Histograma";
            this.btnHistogramA.UseVisualStyleBackColor = true;
            this.btnHistogramA.Click += new System.EventHandler(this.Histogram);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Média:";
            // 
            // lblMediaA
            // 
            this.lblMediaA.AutoSize = true;
            this.lblMediaA.Location = new System.Drawing.Point(115, 29);
            this.lblMediaA.Name = "lblMediaA";
            this.lblMediaA.Size = new System.Drawing.Size(46, 13);
            this.lblMediaA.TabIndex = 43;
            this.lblMediaA.Text = "lblMedia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Mediana:";
            // 
            // lblMedianaA
            // 
            this.lblMedianaA.AutoSize = true;
            this.lblMedianaA.Location = new System.Drawing.Point(115, 41);
            this.lblMedianaA.Name = "lblMedianaA";
            this.lblMedianaA.Size = new System.Drawing.Size(58, 13);
            this.lblMedianaA.TabIndex = 44;
            this.lblMedianaA.Text = "lblMediana";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Moda:";
            // 
            // lblVarianciaA
            // 
            this.lblVarianciaA.AutoSize = true;
            this.lblVarianciaA.Location = new System.Drawing.Point(115, 67);
            this.lblVarianciaA.Name = "lblVarianciaA";
            this.lblVarianciaA.Size = new System.Drawing.Size(61, 13);
            this.lblVarianciaA.TabIndex = 47;
            this.lblVarianciaA.Text = "lblVariancia";
            // 
            // lblModaA
            // 
            this.lblModaA.AutoSize = true;
            this.lblModaA.Location = new System.Drawing.Point(115, 54);
            this.lblModaA.Name = "lblModaA";
            this.lblModaA.Size = new System.Drawing.Size(44, 13);
            this.lblModaA.TabIndex = 46;
            this.lblModaA.Text = "lblModa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Variância:";
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(778, 564);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.img);
            this.Controls.Add(this.menuStrip3);
            this.MainMenuStrip = this.menuStrip3;
            this.Name = "MainWindow";
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.panelActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem originalImage;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Button btnHistogramA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMediaA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMedianaA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVarianciaA;
        private System.Windows.Forms.Label lblModaA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem funçoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem espelhamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rodarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem direitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esquerdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reduzirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dobroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtros;
        private System.Windows.Forms.ToolStripMenuItem thresholdingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gausToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prewittToolStripMenuItem;
        public System.Windows.Forms.PictureBox img;
    }
}