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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.img.Image = _fileController.LoadImg(ofd.FileName);
                ////funDeCinzaToolStripMenuItem.Visible = true;
                ////imagemOriginalToolStripMenuItem.Visible = true;
            }
        }
    }
}
