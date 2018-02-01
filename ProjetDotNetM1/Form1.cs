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
using System.Xml;

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
            rafraîchirToolStripMenuItem_Click(sender, e);//Affiche les tags dans le treeView
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
            rafraîchirToolStripMenuItem_Click(sender, e);//Affiche les tags dans le treeView
        }

        private void confirmerBtn_Click(object sender, EventArgs e)
        {
            rafraîchirToolStripMenuItem_Click(sender, e); //Affiche les tags dans le treeView
        }
        private void versionDuLogicielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }

        private void dataGridView_listeImage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ajouterToolStripMenuItem_Ajouter_Click(object sender, EventArgs e)
        {
            GestionnaireTags gXML = GestionnaireTags.Instance;
            gXML.AjouterTag("Test1");

            rafraîchirToolStripMenuItem_Click(sender, e);//rafraichie le treeview
        }

        /// <summary>
        /// Permet de rafraichir un treeView pour afficher la liste des tags
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rafraîchirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //On récupere le gestionnaire
            GestionnaireTags gestionnaire = GestionnaireTags.Instance;

            //On demande un affichage
            gestionnaire.AfficheTreeView(getTreeViewActif());
        }

        /// <summary>
        /// Permet de renommer un tags dans le treeView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void renommerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeView tv = getTreeViewActif();

            if (tv.SelectedNode == null)//Si aucun tag n'es sélectionné
            {
                label_info.Text = "Aucun tag sélectionné pour le renommage.";
                label_info.ForeColor = Color.Red;
            }
            else if (tv.SelectedNode.Text == "Liste_des_tags")//Si l'utilisateur tente de renommer le noeud root
            {
                label_info.Text = "Impossible de renommer le noeud initial.";
                label_info.ForeColor = Color.Red;
            }
            else//Sinon on renomme le noeud désiré
            {
                label_info.Text = "Renommage fini.";
                label_info.ForeColor = Color.Green;
            }

        }

        /// <summary>
        /// Retourne le treeview qui est dans la fenêtre courante. 
        /// /!\ NE FONCTIONNE QUE SI UN SEUL TREEVIEW EST PRESENT DANS LA FENÊTRE ! /!\
        /// </summary>
        /// <returns></returns>
        private TreeView getTreeViewActif()
        {
            TreeView tv;

            if (tableLayoutPanel1_Ensemble.Visible)//On récupère le bon treeview
                tv = treeView_tag;
            else
                tv = treeView_Tags;

            return tv;
        }
    }
}