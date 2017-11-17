using Image_Processing.Controllers;
using Image_Processing.Controllers.Extraction;
using Image_Processing.Controllers.Morphology;
using Image_Processing.Forms;
using Image_Processing.Model;
using System.Linq;
using PDI_Talles.Controllers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PDI_Talles.Forms
{
    public partial class MainWindow : Form
    {
        FileController _fileController = new FileController();
        FunctionsController _functionsController = new FunctionsController();
        Dilation _dilationController = new Dilation();
        Erosion _erosionController = new Erosion();
        Holt _holtController = new Holt();
        SquareExtractionController _squareExtractionController = new SquareExtractionController();
        CircleExtractionController _circleExtractionController = new CircleExtractionController();

        ImageModel mainImage;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void UploadPiture(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var img = _fileController.LoadImg(ofd.FileName);
                this.img.Image = img;

                mainImage = new ImageModel(img);
                mainImage.IniImageModel();
                LabelValuesA(mainImage);

                this.panelActions.Enabled = true;
                this.originalImage.Enabled = true;
                this.funçoesToolStripMenuItem.Visible = true;
                this.filtros.Visible = true;
                this.morphology.Visible = true;
                this.extraçãoDeCaracterísticasToolStripMenuItem.Visible = true;
                originalImage.Visible = true;
            }
        }

        private void GetOriginalImage(object sender, EventArgs e)
        {
            this.img.Image = _fileController.GetOriginalImage();
        }

        private void LabelValuesA(ImageModel img)
        {
            this.lblMediaA.Text = img.Media.ToString();
            this.lblMedianaA.Text = img.Mediana.ToString();
            this.lblVarianciaA.Text = img.Variancia.ToString();
            this.lblModaA.Text = img.Moda.ToString();
        }

        private void Histogram(object sender, EventArgs e)
        {
            Histogram h = new Histogram(mainImage.Histograma);
            h.Show();
        }

        private void HorizontaMirroring_Click(object sender, EventArgs e)
        {
            this.img.Image = _functionsController.HorizontaMirroring(mainImage.Imagem);
        }

        private void VerticalMirroring_Click(object sender, EventArgs e)
        {
            this.img.Image = _functionsController.VerticalMirroring(mainImage.Imagem);
        }

        private void RotateAnticlockwise_Click(object sender, EventArgs e)
        {
            this.img.Image = _functionsController.RotateAnticlockwise(90, mainImage.Imagem);
        }

        private void RotateClockwise_Click(object sender, EventArgs e)
        {
            this.img.Image = _functionsController.RotateClockwise(90, mainImage.Imagem);
        }

        private void Shrink_Click(object sender, EventArgs e)
        {
            this.img.Image = _functionsController.Shrink(mainImage.Imagem);
        }

        private void Stretch_Click(object sender, EventArgs e)
        {
            this.img.Image = _functionsController.Stretch(mainImage.Imagem);
        }

        private void ThresholdingScale_Click(object sender, EventArgs e)
        {
            ThresholdingScale thresholdingScale = new ThresholdingScale(this, mainImage);
            thresholdingScale.Show();
        }

        private void Gaus_Click(object sender, EventArgs e)
        {
            Gaus gaus = new Gaus(mainImage);
            this.img.Image = gaus.RunGaus();
        }

        private void Sobel_Click(object sender, EventArgs e)
        {
            Sobel s = new Sobel();
            this.img.Image = s.Executar(mainImage.Imagem);
        }

        private void Prewitt_Click(object sender, EventArgs e)
        {
            Prewitt p = new Prewitt();
            this.img.Image = p.Executar(mainImage.Imagem);
        }

        private void Dilation_Click(object sender, EventArgs e)
        {
            if (mainImage.Media < 128)
            {
                Erosion();
            }
            else
            {
                Dilation();
            }
        }

        private void Erosion_Click(object sender, EventArgs e)
        {
            if (mainImage.Media < 128)
            {
                Dilation();
            }
            else
            {
                Erosion();
            }
        }

        private void Erosion()
        {
            Element elementWindow = new Element();
            var result = elementWindow.ShowDialog();

            if (result == DialogResult.OK)
            {
                var element = elementWindow.element;
                Bitmap currentIgm = (Bitmap)this.img.Image;
                this.img.Image = _erosionController.Run(currentIgm, element);
            }
        }

        private void Dilation()
        {
            Element elementWindow = new Element();
            var result = elementWindow.ShowDialog();

            if (result == DialogResult.OK)
            {
                var element = elementWindow.element;
                Bitmap currentIgm = (Bitmap)this.img.Image;
                this.img.Image = _dilationController.Run(currentIgm, element);
            }
        }

        private void holtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap currentIgm = (Bitmap)this.img.Image;
            this.img.Image = _holtController.Run(currentIgm);
        }

        private void quadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var square = _squareExtractionController.SquareExtraction(this.img.Image).FirstOrDefault(x => x.isCompleted);
            this.lblAreaSquare.Text = square.GetArea().ToString();
            this.lblPerimeterSquare.Text = square.GetPerimeter().ToString();
            this.squarePanel.Visible = true;
        }

        private void circulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.img.Image = _circleExtractionController.CircleExtraction(this.img.Image);
            var circles = _circleExtractionController.Circles;

            this.Circulo1.ForeColor = circles[0].Color;
            this.Circulo2.ForeColor = circles[1].Color;
            this.Circulo3.ForeColor = circles[2].Color;

            this.CircArea1.Text = circles[0].AreaByPixel.ToString();
            this.CircArea2.Text = circles[1].AreaByPixel.ToString();
            this.CircArea3.Text = circles[2].AreaByPixel.ToString();

            this.CircPerimeter1.Text = circles[0].PerimeterByPixel.ToString();
            this.CircPerimeter2.Text = circles[1].PerimeterByPixel.ToString();
            this.CircPerimeter3.Text = circles[2].PerimeterByPixel.ToString();

            this.CircCircularity1.Text = circles[0].CircularityByPixel.ToString();
            this.CircCircularity2.Text = circles[1].CircularityByPixel.ToString();
            this.CircCircularity3.Text = circles[2].CircularityByPixel.ToString();

            this.circlePanel.Visible = true;
        }

    }
}