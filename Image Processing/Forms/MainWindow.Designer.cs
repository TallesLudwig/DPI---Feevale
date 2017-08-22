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
            this.quadrants = new System.Windows.Forms.ToolStripMenuItem();
            this.Dividir = new System.Windows.Forms.ToolStripMenuItem();
            this.QuestionA = new System.Windows.Forms.ToolStripMenuItem();
            this.QuestionB = new System.Windows.Forms.ToolStripMenuItem();
            this.QuestionC = new System.Windows.Forms.ToolStripMenuItem();
            this.QuestionD = new System.Windows.Forms.ToolStripMenuItem();
            this.QuestionE = new System.Windows.Forms.ToolStripMenuItem();
            this.img = new System.Windows.Forms.PictureBox();
            this.img1 = new System.Windows.Forms.PictureBox();
            this.img3 = new System.Windows.Forms.PictureBox();
            this.img4 = new System.Windows.Forms.PictureBox();
            this.img2 = new System.Windows.Forms.PictureBox();
            this.panelActions = new System.Windows.Forms.Panel();
            this.secondPanel = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.btnHistogramD = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.lblMediaD = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblMedianaD = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblVarianciaD = new System.Windows.Forms.Label();
            this.lblModaD = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.btnHistogramC = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lblMediaC = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblMedianaC = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblVarianciaC = new System.Windows.Forms.Label();
            this.lblModaC = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnHistogramB = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMediaB = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMedianaB = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblVarianciaB = new System.Windows.Forms.Label();
            this.lblModaB = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).BeginInit();
            this.panelActions.SuspendLayout();
            this.secondPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.quadrants});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(763, 24);
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
            this.originalImage.Name = "originalImage";
            this.originalImage.Size = new System.Drawing.Size(163, 22);
            this.originalImage.Text = "Imagem Original";
            this.originalImage.Click += new System.EventHandler(this.GetOriginalImage);
            // 
            // quadrants
            // 
            this.quadrants.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Dividir,
            this.QuestionA,
            this.QuestionB,
            this.QuestionC,
            this.QuestionD,
            this.QuestionE});
            this.quadrants.Name = "quadrants";
            this.quadrants.Size = new System.Drawing.Size(80, 20);
            this.quadrants.Text = "Quadrantes";
            this.quadrants.Visible = false;
            // 
            // Dividir
            // 
            this.Dividir.Name = "Dividir";
            this.Dividir.Size = new System.Drawing.Size(152, 22);
            this.Dividir.Text = "Dividir";
            this.Dividir.Click += new System.EventHandler(this.Divide);
            // 
            // QuestionA
            // 
            this.QuestionA.Enabled = false;
            this.QuestionA.Name = "QuestionA";
            this.QuestionA.Size = new System.Drawing.Size(152, 22);
            this.QuestionA.Text = "Questao A";
            this.QuestionA.Click += new System.EventHandler(this.QuestionA_Click);
            // 
            // QuestionB
            // 
            this.QuestionB.Enabled = false;
            this.QuestionB.Name = "QuestionB";
            this.QuestionB.Size = new System.Drawing.Size(152, 22);
            this.QuestionB.Text = "Questao B";
            this.QuestionB.Click += new System.EventHandler(this.QuestionB_Click);
            // 
            // QuestionC
            // 
            this.QuestionC.Enabled = false;
            this.QuestionC.Name = "QuestionC";
            this.QuestionC.Size = new System.Drawing.Size(152, 22);
            this.QuestionC.Text = "Questao C";
            this.QuestionC.Click += new System.EventHandler(this.QuestionC_Click);
            // 
            // QuestionD
            // 
            this.QuestionD.Enabled = false;
            this.QuestionD.Name = "QuestionD";
            this.QuestionD.Size = new System.Drawing.Size(152, 22);
            this.QuestionD.Text = "Questao D";
            this.QuestionD.Click += new System.EventHandler(this.QuestionD_Click);
            // 
            // QuestionE
            // 
            this.QuestionE.Enabled = false;
            this.QuestionE.Name = "QuestionE";
            this.QuestionE.Size = new System.Drawing.Size(152, 22);
            this.QuestionE.Text = "Questao E";
            this.QuestionE.Click += new System.EventHandler(this.QuestionE_Click);
            // 
            // img
            // 
            this.img.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.img.Location = new System.Drawing.Point(240, 27);
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
            this.img1.Location = new System.Drawing.Point(240, 27);
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
            this.img3.Location = new System.Drawing.Point(240, 283);
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
            this.img4.Location = new System.Drawing.Point(496, 283);
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
            this.img2.Location = new System.Drawing.Point(496, 27);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(256, 256);
            this.img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.img2.TabIndex = 5;
            this.img2.TabStop = false;
            this.img2.Visible = false;
            // 
            // panelActions
            // 
            this.panelActions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelActions.Controls.Add(this.secondPanel);
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
            this.panelActions.Size = new System.Drawing.Size(222, 512);
            this.panelActions.TabIndex = 6;
            // 
            // secondPanel
            // 
            this.secondPanel.Controls.Add(this.label31);
            this.secondPanel.Controls.Add(this.label30);
            this.secondPanel.Controls.Add(this.label29);
            this.secondPanel.Controls.Add(this.btnHistogramD);
            this.secondPanel.Controls.Add(this.label21);
            this.secondPanel.Controls.Add(this.lblMediaD);
            this.secondPanel.Controls.Add(this.label23);
            this.secondPanel.Controls.Add(this.lblMedianaD);
            this.secondPanel.Controls.Add(this.label25);
            this.secondPanel.Controls.Add(this.lblVarianciaD);
            this.secondPanel.Controls.Add(this.lblModaD);
            this.secondPanel.Controls.Add(this.label28);
            this.secondPanel.Controls.Add(this.btnHistogramC);
            this.secondPanel.Controls.Add(this.label13);
            this.secondPanel.Controls.Add(this.lblMediaC);
            this.secondPanel.Controls.Add(this.label15);
            this.secondPanel.Controls.Add(this.lblMedianaC);
            this.secondPanel.Controls.Add(this.label17);
            this.secondPanel.Controls.Add(this.lblVarianciaC);
            this.secondPanel.Controls.Add(this.lblModaC);
            this.secondPanel.Controls.Add(this.label20);
            this.secondPanel.Controls.Add(this.btnHistogramB);
            this.secondPanel.Controls.Add(this.label5);
            this.secondPanel.Controls.Add(this.lblMediaB);
            this.secondPanel.Controls.Add(this.label7);
            this.secondPanel.Controls.Add(this.lblMedianaB);
            this.secondPanel.Controls.Add(this.label9);
            this.secondPanel.Controls.Add(this.lblVarianciaB);
            this.secondPanel.Controls.Add(this.lblModaB);
            this.secondPanel.Controls.Add(this.label12);
            this.secondPanel.Location = new System.Drawing.Point(-2, 121);
            this.secondPanel.Name = "secondPanel";
            this.secondPanel.Size = new System.Drawing.Size(222, 389);
            this.secondPanel.TabIndex = 79;
            this.secondPanel.Visible = false;
            // 
            // label31
            // 
            this.label31.AccessibleDescription = "";
            this.label31.AccessibleName = "";
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(18, 269);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(79, 13);
            this.label31.TabIndex = 108;
            this.label31.Tag = "";
            this.label31.Text = "Quadrante D";
            // 
            // label30
            // 
            this.label30.AccessibleDescription = "";
            this.label30.AccessibleName = "";
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(18, 133);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(78, 13);
            this.label30.TabIndex = 107;
            this.label30.Tag = "";
            this.label30.Text = "Quadrante C";
            // 
            // label29
            // 
            this.label29.AccessibleDescription = "";
            this.label29.AccessibleName = "";
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(18, 12);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(78, 13);
            this.label29.TabIndex = 106;
            this.label29.Tag = "";
            this.label29.Text = "Quadrante B";
            // 
            // btnHistogramD
            // 
            this.btnHistogramD.AccessibleDescription = "";
            this.btnHistogramD.AccessibleName = "";
            this.btnHistogramD.Location = new System.Drawing.Point(19, 360);
            this.btnHistogramD.Name = "btnHistogramD";
            this.btnHistogramD.Size = new System.Drawing.Size(164, 23);
            this.btnHistogramD.TabIndex = 102;
            this.btnHistogramD.Tag = "";
            this.btnHistogramD.Text = "Histograma";
            this.btnHistogramD.UseVisualStyleBackColor = true;
            this.btnHistogramD.Click += new System.EventHandler(this.HistogramD);
            // 
            // label21
            // 
            this.label21.AccessibleDescription = "";
            this.label21.AccessibleName = "";
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(20, 296);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 13);
            this.label21.TabIndex = 97;
            this.label21.Tag = "";
            this.label21.Text = "Média:";
            // 
            // lblMediaD
            // 
            this.lblMediaD.AccessibleDescription = "";
            this.lblMediaD.AccessibleName = "";
            this.lblMediaD.AutoSize = true;
            this.lblMediaD.Location = new System.Drawing.Point(122, 296);
            this.lblMediaD.Name = "lblMediaD";
            this.lblMediaD.Size = new System.Drawing.Size(41, 13);
            this.lblMediaD.TabIndex = 101;
            this.lblMediaD.Tag = "";
            this.lblMediaD.Text = "label22";
            // 
            // label23
            // 
            this.label23.AccessibleDescription = "";
            this.label23.AccessibleName = "";
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(20, 309);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 13);
            this.label23.TabIndex = 98;
            this.label23.Tag = "";
            this.label23.Text = "Mediana:";
            // 
            // lblMedianaD
            // 
            this.lblMedianaD.AccessibleDescription = "";
            this.lblMedianaD.AccessibleName = "";
            this.lblMedianaD.AutoSize = true;
            this.lblMedianaD.Location = new System.Drawing.Point(122, 309);
            this.lblMedianaD.Name = "lblMedianaD";
            this.lblMedianaD.Size = new System.Drawing.Size(41, 13);
            this.lblMedianaD.TabIndex = 103;
            this.lblMedianaD.Tag = "";
            this.lblMedianaD.Text = "label24";
            // 
            // label25
            // 
            this.label25.AccessibleDescription = "";
            this.label25.AccessibleName = "";
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(20, 322);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(42, 13);
            this.label25.TabIndex = 99;
            this.label25.Tag = "";
            this.label25.Text = "Moda:";
            // 
            // lblVarianciaD
            // 
            this.lblVarianciaD.AccessibleDescription = "";
            this.lblVarianciaD.AccessibleName = "";
            this.lblVarianciaD.AutoSize = true;
            this.lblVarianciaD.Location = new System.Drawing.Point(122, 335);
            this.lblVarianciaD.Name = "lblVarianciaD";
            this.lblVarianciaD.Size = new System.Drawing.Size(41, 13);
            this.lblVarianciaD.TabIndex = 105;
            this.lblVarianciaD.Tag = "";
            this.lblVarianciaD.Text = "label26";
            // 
            // lblModaD
            // 
            this.lblModaD.AccessibleDescription = "";
            this.lblModaD.AccessibleName = "";
            this.lblModaD.AutoSize = true;
            this.lblModaD.Location = new System.Drawing.Point(122, 322);
            this.lblModaD.Name = "lblModaD";
            this.lblModaD.Size = new System.Drawing.Size(41, 13);
            this.lblModaD.TabIndex = 104;
            this.lblModaD.Tag = "";
            this.lblModaD.Text = "label27";
            // 
            // label28
            // 
            this.label28.AccessibleDescription = "";
            this.label28.AccessibleName = "";
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(20, 335);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(64, 13);
            this.label28.TabIndex = 100;
            this.label28.Tag = "";
            this.label28.Text = "Variância:";
            // 
            // btnHistogramC
            // 
            this.btnHistogramC.AccessibleDescription = "";
            this.btnHistogramC.AccessibleName = "";
            this.btnHistogramC.Location = new System.Drawing.Point(19, 231);
            this.btnHistogramC.Name = "btnHistogramC";
            this.btnHistogramC.Size = new System.Drawing.Size(164, 23);
            this.btnHistogramC.TabIndex = 93;
            this.btnHistogramC.Tag = "";
            this.btnHistogramC.Text = "Histograma";
            this.btnHistogramC.UseVisualStyleBackColor = true;
            this.btnHistogramC.Click += new System.EventHandler(this.HistogramC);
            // 
            // label13
            // 
            this.label13.AccessibleDescription = "";
            this.label13.AccessibleName = "";
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 88;
            this.label13.Tag = "";
            this.label13.Text = "Média:";
            // 
            // lblMediaC
            // 
            this.lblMediaC.AccessibleDescription = "";
            this.lblMediaC.AccessibleName = "";
            this.lblMediaC.AutoSize = true;
            this.lblMediaC.Location = new System.Drawing.Point(122, 167);
            this.lblMediaC.Name = "lblMediaC";
            this.lblMediaC.Size = new System.Drawing.Size(41, 13);
            this.lblMediaC.TabIndex = 92;
            this.lblMediaC.Tag = "";
            this.lblMediaC.Text = "label14";
            // 
            // label15
            // 
            this.label15.AccessibleDescription = "";
            this.label15.AccessibleName = "";
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 180);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 89;
            this.label15.Tag = "";
            this.label15.Text = "Mediana:";
            // 
            // lblMedianaC
            // 
            this.lblMedianaC.AccessibleDescription = "";
            this.lblMedianaC.AccessibleName = "";
            this.lblMedianaC.AutoSize = true;
            this.lblMedianaC.Location = new System.Drawing.Point(122, 180);
            this.lblMedianaC.Name = "lblMedianaC";
            this.lblMedianaC.Size = new System.Drawing.Size(41, 13);
            this.lblMedianaC.TabIndex = 94;
            this.lblMedianaC.Tag = "";
            this.lblMedianaC.Text = "label16";
            // 
            // label17
            // 
            this.label17.AccessibleDescription = "";
            this.label17.AccessibleName = "";
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(20, 193);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 90;
            this.label17.Tag = "";
            this.label17.Text = "Moda:";
            // 
            // lblVarianciaC
            // 
            this.lblVarianciaC.AccessibleDescription = "";
            this.lblVarianciaC.AccessibleName = "";
            this.lblVarianciaC.AutoSize = true;
            this.lblVarianciaC.Location = new System.Drawing.Point(122, 206);
            this.lblVarianciaC.Name = "lblVarianciaC";
            this.lblVarianciaC.Size = new System.Drawing.Size(41, 13);
            this.lblVarianciaC.TabIndex = 96;
            this.lblVarianciaC.Tag = "";
            this.lblVarianciaC.Text = "label18";
            // 
            // lblModaC
            // 
            this.lblModaC.AccessibleDescription = "";
            this.lblModaC.AccessibleName = "";
            this.lblModaC.AutoSize = true;
            this.lblModaC.Location = new System.Drawing.Point(122, 193);
            this.lblModaC.Name = "lblModaC";
            this.lblModaC.Size = new System.Drawing.Size(41, 13);
            this.lblModaC.TabIndex = 95;
            this.lblModaC.Tag = "";
            this.lblModaC.Text = "label19";
            // 
            // label20
            // 
            this.label20.AccessibleDescription = "";
            this.label20.AccessibleName = "";
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(20, 206);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 13);
            this.label20.TabIndex = 91;
            this.label20.Tag = "";
            this.label20.Text = "Variância:";
            // 
            // btnHistogramB
            // 
            this.btnHistogramB.AccessibleDescription = "";
            this.btnHistogramB.AccessibleName = "";
            this.btnHistogramB.Location = new System.Drawing.Point(19, 100);
            this.btnHistogramB.Name = "btnHistogramB";
            this.btnHistogramB.Size = new System.Drawing.Size(164, 23);
            this.btnHistogramB.TabIndex = 84;
            this.btnHistogramB.Tag = "";
            this.btnHistogramB.Text = "Histograma";
            this.btnHistogramB.UseVisualStyleBackColor = true;
            this.btnHistogramB.Click += new System.EventHandler(this.HistogramB);
            // 
            // label5
            // 
            this.label5.AccessibleDescription = "";
            this.label5.AccessibleName = "";
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 79;
            this.label5.Tag = "";
            this.label5.Text = "Média:";
            // 
            // lblMediaB
            // 
            this.lblMediaB.AccessibleDescription = "";
            this.lblMediaB.AccessibleName = "";
            this.lblMediaB.AutoSize = true;
            this.lblMediaB.Location = new System.Drawing.Point(122, 36);
            this.lblMediaB.Name = "lblMediaB";
            this.lblMediaB.Size = new System.Drawing.Size(35, 13);
            this.lblMediaB.TabIndex = 83;
            this.lblMediaB.Tag = "";
            this.lblMediaB.Text = "label6";
            // 
            // label7
            // 
            this.label7.AccessibleDescription = "";
            this.label7.AccessibleName = "";
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 80;
            this.label7.Tag = "";
            this.label7.Text = "Mediana:";
            // 
            // lblMedianaB
            // 
            this.lblMedianaB.AccessibleDescription = "";
            this.lblMedianaB.AccessibleName = "";
            this.lblMedianaB.AutoSize = true;
            this.lblMedianaB.Location = new System.Drawing.Point(122, 49);
            this.lblMedianaB.Name = "lblMedianaB";
            this.lblMedianaB.Size = new System.Drawing.Size(35, 13);
            this.lblMedianaB.TabIndex = 85;
            this.lblMedianaB.Tag = "";
            this.lblMedianaB.Text = "label8";
            // 
            // label9
            // 
            this.label9.AccessibleDescription = "";
            this.label9.AccessibleName = "";
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 81;
            this.label9.Tag = "";
            this.label9.Text = "Moda:";
            // 
            // lblVarianciaB
            // 
            this.lblVarianciaB.AccessibleDescription = "";
            this.lblVarianciaB.AccessibleName = "";
            this.lblVarianciaB.AutoSize = true;
            this.lblVarianciaB.Location = new System.Drawing.Point(122, 75);
            this.lblVarianciaB.Name = "lblVarianciaB";
            this.lblVarianciaB.Size = new System.Drawing.Size(41, 13);
            this.lblVarianciaB.TabIndex = 87;
            this.lblVarianciaB.Tag = "";
            this.lblVarianciaB.Text = "label10";
            // 
            // lblModaB
            // 
            this.lblModaB.AccessibleDescription = "";
            this.lblModaB.AccessibleName = "";
            this.lblModaB.AutoSize = true;
            this.lblModaB.Location = new System.Drawing.Point(122, 62);
            this.lblModaB.Name = "lblModaB";
            this.lblModaB.Size = new System.Drawing.Size(41, 13);
            this.lblModaB.TabIndex = 86;
            this.lblModaB.Tag = "";
            this.lblModaB.Text = "label11";
            // 
            // label12
            // 
            this.label12.AccessibleDescription = "";
            this.label12.AccessibleName = "";
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 82;
            this.label12.Tag = "";
            this.label12.Text = "Variância:";
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
            this.btnHistogramA.Click += new System.EventHandler(this.HistogramA);
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
            this.ClientSize = new System.Drawing.Size(763, 564);
            this.Controls.Add(this.panelActions);
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
            this.panelActions.ResumeLayout(false);
            this.panelActions.PerformLayout();
            this.secondPanel.ResumeLayout(false);
            this.secondPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.ToolStripMenuItem originalImage;
        private System.Windows.Forms.ToolStripMenuItem quadrants;
        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.PictureBox img3;
        private System.Windows.Forms.PictureBox img4;
        private System.Windows.Forms.PictureBox img2;
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
        private System.Windows.Forms.Panel secondPanel;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btnHistogramD;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblMediaD;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblMedianaD;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblVarianciaD;
        private System.Windows.Forms.Label lblModaD;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnHistogramC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblMediaC;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblMedianaC;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblVarianciaC;
        private System.Windows.Forms.Label lblModaC;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnHistogramB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMediaB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMedianaB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblVarianciaB;
        private System.Windows.Forms.Label lblModaB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripMenuItem Dividir;
        private System.Windows.Forms.ToolStripMenuItem QuestionA;
        private System.Windows.Forms.ToolStripMenuItem QuestionB;
        private System.Windows.Forms.ToolStripMenuItem QuestionC;
        private System.Windows.Forms.ToolStripMenuItem QuestionD;
        private System.Windows.Forms.ToolStripMenuItem QuestionE;
    }
}