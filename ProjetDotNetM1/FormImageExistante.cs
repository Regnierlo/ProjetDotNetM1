﻿using System;
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

        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

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
