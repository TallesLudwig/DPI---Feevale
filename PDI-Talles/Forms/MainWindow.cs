using PDI_Talles.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDI_Talles.Forms
{
    public partial class MainWindow : Form
    {
        FileController _fileController = new FileController();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void UploadPiture(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.img.Image = _fileController.LoadImg(ofd.FileName);
                originalImage.Visible = true;
            }
        }

        private void GetOriginalImage(object sender, EventArgs e)
        {
            this.img.Image = _fileController.GetOriginalImage();
            this.img1.Image = this.img2.Image = this.img3.Image = this.img4.Image = null;
            this.img.Visible = true;
            this.img1.Visible = this.img2.Visible = this.img3.Visible = this.img4.Visible = false;
        }

        private void Quadrants(object sender, EventArgs e)
        {
            this.img.Visible = false;
            this.img1.Visible = this.img2.Visible = this.img3.Visible = this.img4.Visible = true;

            var slicedImg = _fileController.SliceImg(4);
            this.img1.Image = slicedImg[0];
            this.img2.Image = slicedImg[1];
            this.img3.Image = slicedImg[2];
            this.img4.Image = slicedImg[3];
        }
    }
}
