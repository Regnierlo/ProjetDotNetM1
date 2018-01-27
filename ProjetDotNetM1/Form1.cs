using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ProjetDotNetM1
{
     public partial class Form1 : Form
     {
        GestionListeImages images;

        public Form1()
        {
            InitializeComponent();
            images = new GestionListeImages(progressBar1, dataGridView_listeImage);
        }

        private void miseÀJourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("màj réussi");
        }

        private void dossierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Console.WriteLine("lecture du dossier réussie");
            }
        }

        private void fichierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Images Files (.jpg)|*.jpg";
            openFileDialog1.Multiselect = true;
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Console.WriteLine("lecture du dossier réussie");
                ArrayList imagesList;
                imagesList = new ArrayList();
                foreach (string img in openFileDialog1.FileNames)
                {
                    imagesList.Add(img);
                }
                GestionListeImages images = new GestionListeImages(imagesList);
                images.importer();
            }
        }

        private void paramètresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            images = new GestionListeImages(progressBar1, dataGridView_listeImage);
            Console.WriteLine("Bouton ok");
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1_Ensemble.Hide();
            tableLayoutPanel3_Modification.BringToFront();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ConfirmationChangement cg = new ConfirmationChangement();
            DialogResult res = cg.ShowDialog();
            if (res == DialogResult.Abort)
            {
                tableLayoutPanel3_Modification.Hide();
                tableLayoutPanel1_Ensemble.BringToFront();
            }
        }

        private void confirmerBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
