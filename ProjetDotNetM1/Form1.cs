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
            mise_a_jour();
            afficheImage();
        }
        public void afficheImage()
        {
            foreach(GestionImage img in images.ListeImg)
            {
                FileStream fs = new FileStream(img.ImgUrl, FileMode.Open);
                Image image = Image.FromStream(fs);
                int larg = tableLayoutPanel6.Controls.Container.Width / 5;
                double hautD = (double)image.Height/(double)image.Width * (double)tableLayoutPanel6.Controls.Container.Width/5;
                int haut = (int)hautD;
                PictureBox pic = new PictureBox() { Image = new Bitmap(image, new Size(larg, haut)) };
                pic.Dock = DockStyle.Fill;
                    tableLayoutPanel6.Controls.Add(pic,0,0);
                tableLayoutPanel6.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            }
    
            
        }
        private void mise_a_jour()
        {
            string saveUrlDos = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            saveUrlDos = Path.Combine(saveUrlDos, "FHRImages");
            int nbFichiersJPG = Directory.GetFiles(saveUrlDos, "*.jpg", SearchOption.AllDirectories).Length - 1;
                images = new GestionListeImages(progressBar1);
        }
        private void miseÀJourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string saveUrlDos = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            saveUrlDos = Path.Combine(saveUrlDos, "FHRImages");
            int nbFichiersJPG = Directory.GetFiles(saveUrlDos, "*.jpg", SearchOption.AllDirectories).Length - 1;
            if (nbFichiersJPG <= 0)
            {
                Console.WriteLine("Màj non effectuée");
            }
            else
            {
                images = new GestionListeImages(progressBar1);
                Console.WriteLine("Màj effectuée");
            }
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
                GestionListeImport image = new GestionListeImport(imagesList, this.images);
                image.importer();
            }
        }

        private void paramètresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1_Ensemble.Hide();
            tableLayoutPanel3_Modification.Hide();
            tableLayoutPanel4_Parametre.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("bouton ok");
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1_Ensemble.Hide();
            tableLayoutPanel4_Parametre.Hide();
            tableLayoutPanel3_Modification.Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
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

        private void confirmerBtn_Click(object sender, EventArgs e)
        {

        }
        private void versionDuLogicielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }

        private void dataGridView_listeImage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void annulerBtn_Click(object sender, EventArgs e)
        {
            tableLayoutPanel4_Parametre.Hide();
            tableLayoutPanel3_Modification.Hide();
            tableLayoutPanel1_Ensemble.Show();
        }

        
    }
}