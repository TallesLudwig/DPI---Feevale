namespace PDI_Talles.Forms
{
    partial class Histogram
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Histogram));
            this.chartHistograma = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistograma)).BeginInit();
            this.SuspendLayout();
            // 
            // chartHistograma
            // 
            chartArea1.Name = "ChartArea1";
            this.chartHistograma.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartHistograma.Legends.Add(legend1);
            this.chartHistograma.Location = new System.Drawing.Point(12, 12);
            this.chartHistograma.Name = "chartHistograma";
            this.chartHistograma.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartHistograma.Series.Add(series1);
            this.chartHistograma.Size = new System.Drawing.Size(880, 280);
            this.chartHistograma.TabIndex = 0;
            // 
            // Histogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 308);
            this.Controls.Add(this.chartHistograma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Histogram";
            this.Text = "Histograma";
            this.Load += new System.EventHandler(this.Histograma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartHistograma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistograma;
    }
}