using System;
using System.Drawing;
using System.Windows.Forms;

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

        /// <summary>
        /// Garde celle actuellement dans le dossier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        /// <summary>
        /// Ecrase l'ancienne image avec la nouvelle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
            this.Dispose();
        }

        /// <summary>
        /// Ajoute la nouvelle avec numéro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Dispose();
        }
    }
}
