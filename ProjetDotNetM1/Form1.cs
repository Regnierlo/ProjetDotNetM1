﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Xml;
using System.Collections.Generic;

namespace ProjetDotNetM1
{
    public partial class Form1 : Form
    {
        GestionListeImages images;
        List<System.Windows.Forms.PictureBox> pictureList;
        
        public Form1()
        {

            InitializeComponent();
            pictureList = new List<System.Windows.Forms.PictureBox>();
            textBox_recherche.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Mise_a_jour();
            InitialisationPerso();
            AfficheImage();
        }

        /// <summary>
        /// Initialise certains outils de l'accuil pour que ce soit à jour
        /// </summary>
        private void InitialisationPerso()
        {
            #region Affiche le treeView au démarrage
            TreeView t = treeView_TagsAcceuil;
            //On récupere le gestionnaire
            GestionnaireTags gestionnaire = GestionnaireTags.Instance;

            //On demande un affichage
            gestionnaire.AfficheTreeView(t);
            #endregion

            comboBox_Recherche.SelectedIndex = 0; //Mis par défaut à "TOUS" pour la comboxbox_recherche
            label_info.Text = "Les informations de l'application seront affichées ici.";
        }

        /// <summary>
        /// Fonction permettant l'affichage des photos du dossier lors du lancement du logiciel sur la page d'accueil
        /// </summary>
        public void AfficheImage()
        {
            foreach (GestionImage img in images.ListeImg)
            {
                int larg;
                int haut;
                FileStream fs = new FileStream(img.ImgUrl, FileMode.Open);
                Image image = Image.FromStream(fs);
                fs.Close();
                switch (img.Orientation)
                {
                    case 6:
                        image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        break;
                    case 8:
                        image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        break;
                    case 2:
                        //affichage optimal non garanti 
                        image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        break;
                    case 3:
                        image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        break;
                    case 4:
                        //affichage optimal non garanti 
                        image.RotateFlip(RotateFlipType.RotateNoneFlipY);
                        break;
                    case 5:
                        //affichage optimal non garanti 
                        image.RotateFlip(RotateFlipType.Rotate270FlipX);
                        break;
                    case 7:
                        //affichage optimal non garanti 
                        image.RotateFlip(RotateFlipType.Rotate90FlipX);
                        break;
                    default:
                        break;
                }
                if (img.Orientation == 6 | img.Orientation == 8)
                {
                    haut = 200;
                    double largD = (double)image.Width / (double)image.Height * 200;
                    larg = (int)largD;
                }
                else
                {
                    larg = tableLayoutPanel_Photos.Controls.Container.Width / 5;
                    double hautD = (double)image.Height/(double)image.Width * (double)tableLayoutPanel_Photos.Controls.Container.Width/5;
                    haut = (int)hautD;
                }
                PictureBox pic = new PictureBox() { Image = new Bitmap(image, new Size(larg, haut)) };
                pictureList.Add( pic );
                pictureList[pictureList.Count-1].Click += new System.EventHandler(this.Pic_Click);

                pictureList[pictureList.Count - 1].Dock = DockStyle.Fill;
                pictureList[pictureList.Count - 1].SizeMode = PictureBoxSizeMode.CenterImage;
                tableLayoutPanel_Photos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
                tableLayoutPanel_Photos.Controls.Add(pictureList[pictureList.Count - 1], 0,0);
                image.Dispose();
            }
            //affiche la grille pour se reperer
            //tableLayoutPanel6.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;         
            foreach (System.Windows.Forms.RowStyle row in tableLayoutPanel_Photos.RowStyles)
            {
                row.SizeType = System.Windows.Forms.SizeType.Absolute;
                row.Height = 200F;
            }
        }
        private void Pic_Click(object sender, EventArgs e)
        {
            foreach(PictureBox picture in pictureList)
            {
                picture.BackColor = Color.Transparent;
            }
            PictureBox pic = (PictureBox)sender;
            pic.BackColor = Color.DeepSkyBlue;
        }
        /// <summary>
        /// Fonction permettant de mettre à jour le dossier d'images lors du lancement de l'application
        /// </summary>
        private void Mise_a_jour()
        {
            string saveUrlDos = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            saveUrlDos = Path.Combine(saveUrlDos, "FHRImages");
            int nbFichiersJPG = Directory.GetFiles(saveUrlDos, "*.jpg", SearchOption.AllDirectories).Length;
            images = new GestionListeImages(progressBar);
        }

        /// <summary>
        /// Permet à l'utilisateur d'importer un ou plusieurs dossiers dans l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Permet la récursivité de la lecture des dossiers
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Permet à l'utilisateur d'importer un ou plusieurs fichiers dans l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                Console.WriteLine("Màj effectuée");
            }
        }

        /// <summary>
        /// Permet à l'utilisateur de montrer la fenetre des paramètres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ParamètresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel_Ensemble.Hide();
            tableLayoutPanel_Modification.Hide();
            tableLayoutPanel_Parametres.Show();
        }

        /// <summary>
        /// Evenement lié au bouton permettant à l'utilisateur de rechercher des tags/images,...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("bouton ok");
        }

        /// <summary>
        /// Permet à l'utilisateur de faire apparaitre la fenetre des modifications de tag
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel_Ensemble.Hide();
            tableLayoutPanel_Parametres.Hide();
            tableLayoutPanel_Modification.Show();
            RafraichirTreeView();//Affiche les tags dans le treeView
        }

        /// <summary>
        /// Permet à l'utilisateur d'annuler les modifications effectuées lors de la modification de tag
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            ConfirmationChangement cg = new ConfirmationChangement();
            DialogResult res = cg.ShowDialog();
            if (res == DialogResult.Abort)
            {
                tableLayoutPanel_Modification.Hide();
                tableLayoutPanel_Parametres.Hide();
                tableLayoutPanel_Ensemble.Show();
            }
            RafraichirTreeView();//Affiche les tags dans le treeView
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfirmerBtn_Click(object sender, EventArgs e)
        {
            RafraichirTreeView(); //Affiche les tags dans le treeView
        }

        /// <summary>
        /// Permet d'afficher la fenetre "A propos" menant à une visualisation des détails du logiciel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VersionDuLogicielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }

        /// <summary>
        /// Permet à l'utilisateur d'annuler les modifications effectuées lors de l'utilisation des paramètres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnnulerBtn_Click(object sender, EventArgs e)
        {
            tableLayoutPanel_Parametres.Hide();
            tableLayoutPanel_Modification.Hide();
            tableLayoutPanel_Ensemble.Show();
        }

        
        

        /// <summary>
        /// Retourne le treeview qui est dans la fenêtre courante. 
        /// /!\ NE FONCTIONNE QUE SI UN SEUL TREEVIEW EST PRESENT DANS LA FENÊTRE ! /!\
        /// </summary>
        /// <returns></returns>
        private TreeView GetTreeViewActif()
        {
            TreeView tv;

            if (tableLayoutPanel_Ensemble.Visible)//On récupère le bon treeview
                tv = treeView_TagsAcceuil;
            else
                tv = treeView_TagsModification;

            return tv;
        }

        /// <summary>
        /// Evenement permettant à l'utilisateur de mettre à jour le dossier d'images
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MiseAJourToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string saveUrlDos = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            saveUrlDos = Path.Combine(saveUrlDos, "FHRImages");
            int nbFichiersJPG = Directory.GetFiles(saveUrlDos, "*.jpg", SearchOption.AllDirectories).Length;
            if (nbFichiersJPG > 0)
            {
                images = new GestionListeImages(progressBar);
                Console.WriteLine("Màj effectuée");
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            else
            {
                Console.WriteLine("Màj non effectuée");
            }
        }

        /// <summary>
        /// Permet de renommer un tags dans le treeView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RenommerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TreeView tv = GetTreeViewActif();

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
                TreeNode node = tv.SelectedNode;
                label_info.Text = "Renommer le tag";
                label_info.ForeColor = Color.OrangeRed;
                tv.LabelEdit = true;
                node.BeginEdit();
            }
        }

        private void AjouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionnaireTags gXML = GestionnaireTags.Instance;
            TreeView tv = GetTreeViewActif();
            TreeNode newNode = new TreeNode("NouveauTag");
            
            tv.SelectedNode.Nodes.Add(newNode);//Ajout du noeud avec comme père la sélection
            tv.SelectedNode = newNode;//On sélectionne notre nouveau noeud
            tv.ExpandAll();//On étend TOUS le treeview
            label_info.Text = "Ajout d'un nouveau tag - Modifier son nom";//MaJ du label
            label_info.ForeColor = Color.OrangeRed;//Indication en orange car action en cours
            tv.LabelEdit = true;//On accepte l'édition de tag
            newNode.BeginEdit();//Permet d'éditer le tag

            gXML.AjouterTag(newNode.Text, tv.SelectedNode);//On ajoute le tag dans la liste
        }

        /// <summary>
        /// Permet de rafraichir un treeView pour afficher la liste des tags
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RafraîchirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RafraichirTreeView();            
        }

        private void RafraichirTreeView()
        {
            //On récupere le gestionnaire
            GestionnaireTags gestionnaire = GestionnaireTags.Instance;
            gestionnaire.exportToXml(GetTreeViewActif(), gestionnaire.Chemin + gestionnaire.NomXML);//Exportation en XML

            //On demande un affichage
            gestionnaire.AfficheTreeView(GetTreeViewActif());
        }

        private void treeView_TagsAcceuil_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            TreeView tv = GetTreeViewActif();//On récupère le treeview actif
            TreeNode node = tv.SelectedNode;//On récupère le noeud sélectionné
            
            if (e.Label != null) //Si le tag a changé
            {
                if (e.Label.Length > 0)//On faut que la taille du tag soit au moins de 1
                {
                    if (e.Label.IndexOfAny(new char[] { ' ','@', '.', ',', '!' }) == -1) //Si aucun des caractères sont présent 
                    {
                        e.Node.EndEdit(false);//Arret de l'édition avec aucune annulation sur le label
                        node.Text = e.Label;
                        GestionnaireTags gt = GestionnaireTags.Instance;
                        gt.exportToXml(GetTreeViewActif(), gt.Chemin + gt.NomXML);//Exportation en XML
                        label_info.Text = "Modification du tag ok";//Affichage de l'information
                        label_info.ForeColor = Color.Green;//Vert car c'est OK
                    }
                    else
                    {
                        node.EndEdit(true);//On annule l'édition
                        label_info.Text = "Présence de caractères impossible";//Information pour l'utilisateur
                        label_info.ForeColor = Color.Red;//Rouge car c'est pas cool
                        node.BeginEdit();//On recommence l'édition
                    }
                }
                else
                {
                    node.EndEdit(true);//On annule l'édition
                    label_info.Text = "Nom de tag vide impossible";//Informaiton pour l'utilisateur
                    label_info.ForeColor = Color.Red;//Rouge car c'est pas cool
                    e.Node.BeginEdit();//On reommence l'édition
                }
            }
            else //S'il n'a pas changé on lui donne le nom par défaut
            {
                e.Node.EndEdit(false);
                GestionnaireTags gt = GestionnaireTags.Instance;
                gt.exportToXml(GetTreeViewActif(), gt.Chemin + gt.NomXML);
                label_info.Text = "Modification du tag ok";
                label_info.ForeColor = Color.Green;
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeView tv = GetTreeViewActif();
            TreeNode node = tv.SelectedNode;
            node.Remove();
            GestionnaireTags gt = GestionnaireTags.Instance;
            gt.exportToXml(GetTreeViewActif(), gt.Chemin + gt.NomXML);//Exportation en XML
        }

        private void monterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void descendreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}