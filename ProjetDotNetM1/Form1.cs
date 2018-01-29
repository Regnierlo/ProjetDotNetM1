using System;
using System.Drawing;
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
            textBox_recherche.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            images = new GestionListeImages(progressBar1, dataGridView_listeImage);
        }

        private void MiseÀJourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string saveUrlDos = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            saveUrlDos = Path.Combine(saveUrlDos, "FHRImages");
            int nbFichiersJPG = Directory.GetFiles(saveUrlDos, "*.jpg", SearchOption.AllDirectories).Length;
            if (nbFichiersJPG <= 0)
            {
                Console.WriteLine("Màj non effectuée");
            }
            else
            {
                images = new GestionListeImages(progressBar1, dataGridView_listeImage);
                Console.WriteLine("Màj effectuée");
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
        private void DossierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Console.WriteLine("lecture du dossier réussie");
                string path = folderDialog.SelectedPath;

                GestionListeImport image = new GestionListeImport(ProcessDirectory(path), this.images);
                image.Importer();
            }
        }
        public ArrayList ProcessDirectory(string path)
        {
            ArrayList res = new ArrayList();
            string[] fileEntries = Directory.GetFiles(path);
            foreach (string fileName in fileEntries)
            {
                res.Add(Path.Combine(path, fileName));
            }
            string[] subdirectoryEntries = Directory.GetDirectories(path);
            foreach (string subdirectory in subdirectoryEntries)
            {
                ArrayList resReq = ProcessDirectory(subdirectory);
                foreach (string url in resReq)
                {
                    res.Add(url);
                }
            }
            return res;
        }
        private void FichierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "Images Files (.jpg)|*.jpg",
                Multiselect = true,
                FilterIndex = 1
            };
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Console.WriteLine("lecture du dossier réussie");
                ArrayList imagesList;
                imagesList = new ArrayList();
                foreach (string img in openFileDialog1.FileNames)
                {
                    imagesList.Add(img);
                }
                GestionListeImport image = new GestionListeImport(imagesList, this.images);
                image.Importer();
                images = new GestionListeImages(progressBar1, dataGridView_listeImage);
                Console.WriteLine("Màj effectuée");
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void ParamètresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1_Ensemble.Hide();
            tableLayoutPanel3_Modification.Hide();
            tableLayoutPanel4_Parametre.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("bouton ok");
        }

        private void ModifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1_Ensemble.Hide();
            tableLayoutPanel4_Parametre.Hide();
            tableLayoutPanel3_Modification.Show();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            ConfirmationChangement cg = new ConfirmationChangement();
            DialogResult res = cg.ShowDialog();
            if (res == DialogResult.Abort)
            {
                tableLayoutPanel3_Modification.Hide();
                tableLayoutPanel4_Parametre.Hide();
                tableLayoutPanel1_Ensemble.Show();
            }
        }

        private void ConfirmerBtn_Click(object sender, EventArgs e)
        {

        }
        private void VersionDuLogicielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }

        private void DataGridView_listeImage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AnnulerBtn_Click(object sender, EventArgs e)
        {
            tableLayoutPanel4_Parametre.Hide();
            tableLayoutPanel3_Modification.Hide();
            tableLayoutPanel1_Ensemble.Show();
        }

        
    }
}