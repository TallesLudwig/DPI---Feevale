using Image_Processing.Model;
using PDI_Talles.Controllers;
using System;
using System.Windows.Forms;

namespace PDI_Talles.Forms
{
    public partial class MainWindow : Form
    {
        FileController _fileController = new FileController();
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
                this.quadrants.Visible = true;
                originalImage.Visible = true;
            }
        }

        private void GetOriginalImage(object sender, EventArgs e)
        {
            this.img.Image = _fileController.GetOriginalImage();
            HideQuadrants();
        }

        private void HideQuadrants()
        {
            this.labelA.Text = "Foto";
            this.secondPanel.Visible = false;
            this.img1.Image = this.img2.Image = this.img3.Image = this.img4.Image = null;
            this.img.Visible = true;
            this.img1.Visible = this.img2.Visible = this.img3.Visible = this.img4.Visible = false;
        }

        private void Divide(object sender, EventArgs e)
        {
            this.labelA.Text = "Quatrante A";
            this.secondPanel.Visible = true;
            this.img.Visible = false;
            this.img1.Visible = this.img2.Visible = this.img3.Visible = this.img4.Visible = true;
            this.QuestionA.Enabled = this.QuestionB.Enabled = this.QuestionC.Enabled = this.QuestionD.Enabled = this.QuestionE.Enabled = true;

            _fileController.SliceImg(mainImage);

            var imgA = mainImage.SlicedImg[0];
            this.img1.Image = imgA.Imagem;
            imgA.IniImageModel();
            LabelValuesA(imgA);

            var imgB = mainImage.SlicedImg[1];
            this.img2.Image = imgB.Imagem;
            imgB.IniImageModel();
            LabelValuesB(imgB);

            var imgC = mainImage.SlicedImg[2];
            this.img3.Image = imgC.Imagem;
            imgC.IniImageModel();
            LabelValuesC(imgC);

            var imgD = mainImage.SlicedImg[3];
            this.img4.Image = imgD.Imagem;
            imgD.IniImageModel();
            LabelValuesD(imgD);
        }

        private void LabelValuesA(ImageModel img)
        {
            this.lblMediaA.Text = img.Media.ToString();
            this.lblMedianaA.Text = img.Mediana.ToString();
            this.lblVarianciaA.Text = img.Variancia.ToString();
            this.lblModaA.Text = img.Moda.ToString();
        }

        private void HistogramA(object sender, EventArgs e)
        {
            var histA = this.secondPanel.Visible ? mainImage.SlicedImg[0] : mainImage;
            Histograma h = new Histograma(histA.Histograma);
            h.Show();
        }

        private void LabelValuesB(ImageModel img)
        {
            this.lblMediaB.Text = img.Media.ToString();
            this.lblMedianaB.Text = img.Mediana.ToString();
            this.lblVarianciaB.Text = img.Variancia.ToString();
            this.lblModaB.Text = img.Moda.ToString();
        }

        private void HistogramB(object sender, EventArgs e)
        {
            Histograma h = new Histograma(mainImage.SlicedImg[1].Histograma);
            h.Show();
        }

        private void LabelValuesC(ImageModel img)
        {
            this.lblMediaC.Text = img.Media.ToString();
            this.lblMedianaC.Text = img.Mediana.ToString();
            this.lblVarianciaC.Text = img.Variancia.ToString();
            this.lblModaC.Text = img.Moda.ToString();
        }

        private void HistogramC(object sender, EventArgs e)
        {
            Histograma h = new Histograma(mainImage.SlicedImg[2].Histograma);
            h.Show();
        }

        private void LabelValuesD(ImageModel img)
        {
            this.lblMediaD.Text = img.Media.ToString();
            this.lblMedianaD.Text = img.Mediana.ToString();
            this.lblVarianciaD.Text = img.Variancia.ToString();
            this.lblModaD.Text = img.Moda.ToString();
        }

        private void HistogramD(object sender, EventArgs e)
        {
            Histograma h = new Histograma(mainImage.SlicedImg[3].Histograma);
            h.Show();
        }

        private void QuestionA_Click(object sender, EventArgs e)
        {
            HideQuadrants();
            this.img.Image = _fileController.ChangeBiggerValues(mainImage.Imagem, mainImage.SlicedImg[1].Media, 255);
        }

        private void QuestionB_Click(object sender, EventArgs e)
        {
            HideQuadrants();
            this.img.Image = _fileController.ChangeBiggerValues(mainImage.Imagem, mainImage.SlicedImg[3].Moda, 200);
        }

        private void QuestionC_Click(object sender, EventArgs e)
        {
            HideQuadrants();
            this.img.Image = _fileController.ChangeBiggerValues(mainImage.Imagem, mainImage.SlicedImg[2].Mediana, 220);
        }

        private void QuestionD_Click(object sender, EventArgs e)
        {
            HideQuadrants();
            this.img.Image = _fileController.ChangeLowerValues(mainImage.Imagem, mainImage.SlicedImg[1].Media, 100);
        }

        private void QuestionE_Click(object sender, EventArgs e)
        {
            HideQuadrants();
            var img = _fileController.ChangeBiggerValues(mainImage.Imagem, mainImage.SlicedImg[1].Media, 0);
            this.img.Image =_fileController.ChangeLowerValues(img, mainImage.SlicedImg[2].Mediana, 255);
        }
    }
}
