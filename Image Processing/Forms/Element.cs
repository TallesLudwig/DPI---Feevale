using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Image_Processing.Forms
{
    public partial class Element : Form
    {
        public int[,] element = new int[3,3]
        {
            { 0, 0, 0 },
            { 0, 0, 0 },
            { 0, 0, 0 }
        };

        public Element()
        {
            InitializeComponent();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            element = new int[,]
                {
                    { Int32.Parse(this.textBox0.Text), Int32.Parse(this.textBox1.Text), Int32.Parse(this.textBox2.Text) },
                    { Int32.Parse(this.textBox3.Text), Int32.Parse(this.textBox4.Text), Int32.Parse(this.textBox5.Text) },
                    { Int32.Parse(this.textBox6.Text), Int32.Parse(this.textBox7.Text), Int32.Parse(this.textBox8.Text) }

                };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
