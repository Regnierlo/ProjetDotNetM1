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
using System.IO;

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
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Console.WriteLine("lecture du dossier réussie");
                string path = folderDialog.SelectedPath;

                GestionListeImport image = new GestionListeImport(ProcessDirectory(path), this.images);
                image.importer();
            }
        }
        public  ArrayList ProcessDirectory(string path)
        {
            ArrayList res = new ArrayList();
            string[] fileEntries = Directory.GetFiles(path);
            foreach (string fileName in fileEntries)
            {
                res.Add(Path.Combine(path,fileName));
            }
            string[] subdirectoryEntries = Directory.GetDirectories(path);
            foreach (string subdirectory in subdirectoryEntries)
            {
                ArrayList resReq = ProcessDirectory(subdirectory);
                foreach(string url in resReq)
                {
                    res.Add(url);
                }
            }
            return res;
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
                GestionListeImport image = new GestionListeImport(imagesList,this.images);
                image.importer();
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
            tableLayoutPanel3_Modification.Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ConfirmationChangement cg = new ConfirmationChangement();
            DialogResult res = cg.ShowDialog();
            if (res == DialogResult.Abort)
            {
                tableLayoutPanel3_Modification.Hide();
                tableLayoutPanel1_Ensemble.Show();
            }
        }

        private void confirmerBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
