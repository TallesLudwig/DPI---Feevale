using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PDI_Talles.Forms
{
    public partial class Histogram : Form
    {
        int[] histogram;
        public Histogram(int[] histogram)
        {
            this.histogram = histogram;
            InitializeComponent();
        }

        private void Histograma_Load(object sender, EventArgs e)
        {
            this.chartHistograma.Series.Clear();
            this.chartHistograma.Series.Add("Valores");
            // Add series.
            for (int i = 0; i < 255; i++)
            {
                this.chartHistograma.Series["Valores"].IsXValueIndexed = true;
                this.chartHistograma.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount;
                //this.chartHistograma.ChartAreas[0].AxisX.MaximumAutoSize = 100;
                this.chartHistograma.Series["Valores"].IsVisibleInLegend = false;

                this.chartHistograma.Series["Valores"].Points.AddXY(i, histogram[i]);
            }
        }

    }
}
