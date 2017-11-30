using System;
using System.Windows.Forms;
using Image_Processing.Controllers;
using PDI_Talles.Forms;
using Image_Processing.Model;
using System.Drawing;

namespace Image_Processing.Forms
{
    public partial class ThresholdingScale : Form
    {
        private MainWindow mainWindow;
        private ImageModel mainImage;

        public ThresholdingScale(MainWindow main, ImageModel mainImage)
        {
            this.mainWindow = main;
            this.mainImage = mainImage;
            InitializeComponent();
        }

        public ThresholdingScale(MainWindow main, Bitmap mainImage)
        {
            this.mainWindow = main;
            this.mainImage = new ImageModel(mainImage);
            InitializeComponent();
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            try
            {
                int valor = int.Parse(txtValor.Text);
                Limiarization limiarizacao = new Limiarization();
                mainWindow.img.Image = limiarizacao.Run(valor, mainImage.Imagem);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Informe um valor válido");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
