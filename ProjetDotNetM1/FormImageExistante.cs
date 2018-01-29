using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjetDotNetM1
{
    public partial class FormImageExistante : Form
    {
        public FormImageExistante(Image imageFHR, Image imageNouv)
        {
            InitializeComponent();
            button1.BackgroundImage = imageFHR;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button3.BackgroundImage = imageNouv;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Dispose();
        }
    }
}
