using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProjetDotNetM1
{
    public partial class Form1 : Form
    {
        public delegate void MiseAJourDelegate();
        public MiseAJourDelegate monDelegue;
        GestionListeImages images;
        Boolean enCourDeModifAdd=false;
        Boolean enCourDeModifSupr = false;
        List<System.Windows.Forms.PictureBox> pictureList;

        //Pour la recherche
        List<GestionImage> imagesRecherche = new List<GestionImage>();

        string imageSelect;
        public Form1()
        {
            InitializeComponent();
            pictureList = new List<System.Windows.Forms.PictureBox>();
            textBox_recherche.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            monDelegue = new MiseAJourDelegate(MiseAJour);
            InitialisationPerso();
            MiseAJour();
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

        #region affiche les images de la zone d'accueil

        /// <summary>
        /// Fonction permettant l'affichage des photos du dossier lors du lancement du logiciel sur la page d'accueil
        /// </summary>
        private void AfficheImage(GestionListeImages list)
        {
            tableLayoutPanel_Photos.Controls.Clear();
            tableLayoutPanel_Photos.RowStyles.Clear();
            foreach (GestionImage img in list.ListeImg)
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
                if (image.Height < image.Width)
                {
                    larg = tableLayoutPanel_Photos.Controls.Container.Width / 5 - 20;
                    double hautD = (double)image.Height / (double)image.Width * (double)tableLayoutPanel_Photos.Controls.Container.Width / 5;
                    haut = (int)hautD - 20;                }
                else
                {
                    if(image.Height == image.Width)
                    {
                        larg = tableLayoutPanel_Photos.Controls.Container.Width / 5 - 20;
                        haut = 200 - 20;
                    }
                    else
                    {
                        haut = 200-20;
                        double largD = (double)image.Width / (double)image.Height * 200;
                        larg = (int)largD-20;
                    }
                }
                PictureBox pic = new PictureBox() { Image = new Bitmap(image, new Size(larg, haut)) };
                pic.Name = img.ImgUrl;
                pictureList.Add( pic );
                pictureList[pictureList.Count-1].Click += new System.EventHandler(this.Pic_Click);
                pictureList[pictureList.Count - 1].DoubleClick += new System.EventHandler(this.Pic_Double_Click);
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
        /// <summary>
        /// evenement de clic pour chacune des picture box de la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            int i = 0;
            foreach (PictureBox picture in pictureList)
            {
                picture.BackColor = Color.Transparent;
                i = i++;
            }
            pic.BackColor = Color.DeepSkyBlue;
            imageSelect = pic.Name;
            richTextBox_infoImage.Text = images.rechercheinfo(pic.Name);
        }
        /// <summary>
        /// evenement de double click pour chacune des picture box de la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pic_Double_Click(object sender, EventArgs e)
        {
            botonModifier();
            RafraichirTreeView();
        }
        #endregion

        #region barre de menu

        /// <summary>
        /// Evenement permettant à l'utilisateur de mettre à jour le dossier d'images
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MiseAJourToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MiseAJour();
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
        /// Permet à l'utilisateur d'importer un ou plusieurs dossiers dans l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DossierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            string saveUrlDos = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            saveUrlDos = Path.Combine(saveUrlDos, "FHRImages");
            if (folderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Console.WriteLine("lecture du dossier réussie");
                string path = folderDialog.SelectedPath;
                if(saveUrlDos == path)
                {
                    Console.WriteLine("dossier HRF = dossier courant");
                    MessageBox.Show("Le dossier importé est le même dossier courrant.");
                }
                else
                {
                    GestionListeImport image = new GestionListeImport(ProcessDirectory(path), this.images,this);
                    image.Importer();
                }
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
            bool T = false;
            string saveUrlDos = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            saveUrlDos = Path.Combine(saveUrlDos, "FHRImages");
            Console.WriteLine(saveUrlDos);
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
                    string[] decompositionNom = img.Split('\\');
                    string[] nom = decompositionNom[decompositionNom.Length - 1].Split('.');
                    string courrantUrlDos = decompositionNom[0] + "\\";

                    string[] decompositionNom2 = saveUrlDos.Split('\\');
                    string[] nom2 = decompositionNom2[decompositionNom2.Length - 1].Split('.');
                    saveUrlDos = decompositionNom2[0] + "\\";

                    foreach (string urlPart in decompositionNom)
                    {
                        if (urlPart != decompositionNom[decompositionNom.Length - 1])
                        {
                            courrantUrlDos = Path.Combine(courrantUrlDos, urlPart);
                        }
                    }
                    foreach (string urlPart in decompositionNom2)
                    {
                       saveUrlDos = Path.Combine(saveUrlDos, urlPart);
                    }
                    
                    if (saveUrlDos == courrantUrlDos)
                    {
                        Console.WriteLine("Dossier courant : " + courrantUrlDos + "\nDossier FHRImages : " + saveUrlDos);
                        Console.WriteLine("dossier HRF = dossier courant");
                        T = true;
                    }
                    else
                    {
                        imagesList.Add(img);
                    }
                }
                if (T == false)
                {
                    GestionListeImport image = new GestionListeImport(imagesList, this.images, this);
                    image.Importer();
                }
                else
                {
                    MessageBox.Show("Le fichier importé est déjà présent dans le dossier d'importation.");
                }
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
        /// Permet à l'utilisateur de faire apparaitre la fenetre des modifications de tag
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            botonModifier();
        }
        #endregion
        #region Chargement de la zone modifier
        /// <summary>
        /// fonction pour entrer dans le menu modification
        /// </summary>
        private void botonModifier()
        {
            if (imageSelect != null)
            {
                //Mis à jour du label
                label_info.Text = "Modification des tags.";
                label_info.ForeColor = Color.Green;


                tableLayoutPanel_Ensemble.Hide();
                tableLayoutPanel_Parametres.Hide();
                tableLayoutPanel_Modification.Show();
                FileStream fs = new FileStream(imageSelect, FileMode.Open);
                Image image = Image.FromStream(fs);
                fs.Close();
                int orientation = images.rechercheOrientation(imageSelect);
                int larg;
                int haut;
                switch (orientation)
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
                if (image.Height > image.Width)
                {
                    double largD;
                    haut = pictureBoxModifAfficheImage.Height;
                    largD = (double)image.Width / (double)image.Height * pictureBoxModifAfficheImage.Height;
                    larg = (int)largD;
                }
                else
                {
                    larg = pictureBoxModifAfficheImage.Height;
                    double hautD = (double)image.Height / (double)image.Width * pictureBoxModifAfficheImage.Height;
                    haut = (int)hautD;
                }
                pictureBoxModifAfficheImage.Image = new Bitmap(image, new Size(larg, haut));
                richTextBoxInformationModif.Text = images.rechercheinfo(imageSelect);
                string[] decompositionNom = imageSelect.Split('\\');
                string[] nom = decompositionNom[decompositionNom.Length - 1].Split('.');
                richTextBoxRename.Text = nom[0];
                listViewTags.Items.Clear();
                foreach (string tag in images.rechercheTags(imageSelect))
                {
                    listViewTags.Items.Add(tag);
                }
                tabInformations.SelectedTab = tabPage1;
                listViewTags.CheckBoxes = false;
                image.Dispose();
                //RafraichirTreeView();//Affiche les tags dans le treeView
            }
            else
            {
                label_info.Text = "Veuillez sélectionner une image afin de modifier ses tags.";
                label_info.ForeColor = Color.Red;
            }
        }
        #endregion
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
        private void LabelMessage(string message, Color couleur)
        {
            label_info.Text = message;
            label_info.ForeColor = couleur;
        }
        private void MiseAJour()
        {
            string saveUrlDos = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            saveUrlDos = Path.Combine(saveUrlDos, "FHRImages");

            int nbFichiersJPG = Directory.GetFiles(saveUrlDos, "*.jpg", SearchOption.AllDirectories).Length;

            if (!Directory.Exists(saveUrlDos))
            {
                Directory.CreateDirectory(saveUrlDos);
            }
            if (nbFichiersJPG > 0)
            {
                images = new GestionListeImages(progressBar);
                //Console.WriteLine("Màj effectuée");
                LabelMessage("Mise à jour effectuée", Color.Green);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                AfficheImage(images);
            }
            else
            {
                LabelMessage("Mise à jour non effectuée", Color.Red);
                tableLayoutPanel_Photos.Controls.Clear();
                tableLayoutPanel_Photos.RowStyles.Clear();
                //Console.WriteLine("Màj non effectuée");
            }
        }

        // Declare a method with the same signature as the delegate.
        static void Notify(string name)
        {
            Console.WriteLine("Notification received for: {0}", name);
        }


        #region ActionsCliqueDroitTreeView
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
                LabelMessage("Aucun tag sélectionné pour le renommage.", Color.Red);
            }
            else if (tv.SelectedNode.Text == "Liste_des_tags")//Si l'utilisateur tente de renommer le noeud root
            {
                LabelMessage("Impossible de renommer le noeud initial.", Color.Red);
            }
            else//Sinon on renomme le noeud désiré
            {
                TreeNode node = tv.SelectedNode;
                LabelMessage("Renommer le tag", Color.OrangeRed);
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

            gXML.exportToXml(GetTreeViewActif(), gXML.Chemin + gXML.NomXML);//Exportation en XML
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
            else if(node.Text == "NouveauTag") //S'il n'a pas changé on lui donne le nom par défaut
            {
                e.Node.EndEdit(false);
                GestionnaireTags gt = GestionnaireTags.Instance;
                gt.exportToXml(GetTreeViewActif(), gt.Chemin + gt.NomXML);
                label_info.Text = "Modification du tag ok";
                label_info.ForeColor = Color.Green;
            }
            else
            {
                node.EndEdit(true);//On annule l'édition
                label_info.Text = "Nom de tag incorrect";//Informaiton pour l'utilisateur
                label_info.ForeColor = Color.Red;//Rouge car c'est pas cool
                e.Node.BeginEdit();//On reommence l'édition
            }
        }

        /// <summary>
        /// Supprimer un tag dans le treeView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeView tv = GetTreeViewActif();//On récupère le treeview actif
            TreeNode node = tv.SelectedNode;//On recupère le noeud sélectionné
            GestionnaireTags gt = GestionnaireTags.Instance;//On récupère l'instance de GestionnaireTags

            if (node.Text != gt.Root)//Si le noeud sélectionné n'est pas le noeud root
            {
                node.Remove();//On le supprime
                gt.exportToXml(GetTreeViewActif(), gt.Chemin + gt.NomXML);//Exportation en XML
            }
            else//Sinon
            {
                label_info.Text = "Impossible de supprimer le noeud " + gt.Root+".";//On l'indique dans le label
                label_info.ForeColor = Color.Red;//En rouge
            }

        }

        /// <summary>
        /// Monter un tag dans la hiérachisation du treeview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void monterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeView tv = GetTreeViewActif();//On récupère le tag sélectionné
            TreeNode node = tv.SelectedNode;//On récupère le noeud selectionné
            TreeNode parent = node.Parent;//On récupère le noeud parent
            GestionnaireTags gestionnaire = GestionnaireTags.Instance;//On récupère l'instance de GestionnaireTags

            if(parent != null && parent.Text != gestionnaire.Root)//Si le noeud parent n'est pas null et n'est pas le noeud root
            {
                TreeNode parentParent = parent.Parent;//On récupère le parent du parent
                node.Remove();//On supprime le noeud qu'on veut monter
                parentParent.Nodes.Add(node);//On ajoute le noeud qu'on veut monter comme fils du parent du parent
                gestionnaire.exportToXml(tv, gestionnaire.Chemin + gestionnaire.NomXML);//On exporte en XML
                label_info.Text = "Le tag et ses fils ont été remontés";//On affiche dans le label
                label_info.ForeColor = Color.Green;
            }
            else
            {
                label_info.Text = "Impossible de monter au dessus de la racine";
                label_info.ForeColor = Color.Red;
            }
        }
        #endregion
        #region dragAndDropTreeView
        private void treeView_TagsAcceuil_DragDrop(object sender, DragEventArgs e)
        {
            TreeView tv = GetTreeViewActif();
            DragAndDropPerso(tv, e);
        }

        private void DragAndDropPerso(TreeView tv, DragEventArgs e)
        {             
            // Retrieve the client coordinates of the drop location.
            Point targetPoint = tv.PointToClient(new Point(e.X, e.Y));

            // Retrieve the node at the drop location.
            TreeNode targetNode = tv.GetNodeAt(targetPoint);

            // Retrieve the node that was dragged.
            TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));

            // Confirm that the node at the drop location is not 
            // the dragged node and that target node isn't null
            // (for example if you drag outside the control)
            if (!draggedNode.Equals(targetNode) && targetNode != null)
            {
                // Remove the node from its current 
                // location and add it to the node at the drop location.
                draggedNode.Remove();
                targetNode.Nodes.Add(draggedNode);

                // Expand the node at the location 
                // to show the dropped node.
                targetNode.Expand();

            }

            GestionnaireTags gestionnaire = GestionnaireTags.Instance;
            gestionnaire.exportToXml(tv,gestionnaire.Chemin + gestionnaire.NomXML);


            LabelMessage("Déplacement du tag enregistré", Color.Green);
        }

        private void ItemDragPerso(ItemDragEventArgs e)
        {
            TreeView tv = GetTreeViewActif();
            TreeNode node = (TreeNode)e.Item;
            tv.DoDragDrop(node, DragDropEffects.Move);
        }

        private void treeView_TagsAcceuil_ItemDrag(object sender, ItemDragEventArgs e)
        {
            ItemDragPerso(e);
        }

        private void treeView_TagsAcceuil_DragEnter(object sender, DragEventArgs e)
        {
            DragEnterPerso(e);
        }

        private void treeView_TagsModification_DragEnter(object sender, DragEventArgs e)
        {
            DragEnterPerso(e);
        }

        private void DragEnterPerso(DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;

            LabelMessage("Déplacement du tag (ECHAP pour annuler)", Color.OrangeRed);
        }

        private void treeView_TagsModification_DragDrop(object sender, DragEventArgs e)
        {
            TreeView tv = GetTreeViewActif();
            DragAndDropPerso(tv, e);
        }

        private void treeView_TagsModification_ItemDrag(object sender, ItemDragEventArgs e)
        {
            ItemDragPerso(e);
        }
        #endregion
        #region FichierXML_ImportationExportation

        /// <summary>
        /// Importation d'un fichier XML qui à un Noeud root dans la localisation appdata
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void importerUneListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionnaireTags gestionnaire = GestionnaireTags.Instance;

            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "XML Files (.xml)|*.xml",
                Multiselect = false,
                FilterIndex = 1
            };
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {   
                if (gestionnaire.VerificationUnSeulRoot(ofd.FileName))
                {
                    //Importation
                    try
                    {
                        File.Copy(ofd.FileName, gestionnaire.Chemin + gestionnaire.NomXML, true);
                        RafraichirTreeView();
                        LabelMessage("Importation réussie", Color.Green);
                    }
                    catch (Exception ex)
                    {
                        LabelMessage(ex.Message, Color.Red);
                    }
                }
                else
                {
                    LabelMessage("Structure du fichier importé incorrect", Color.Red);
                }
            }
        }

        /// <summary>
        /// Permet à l'utilisateur d'enregistrer le fichier XML utilisé pour les tags où il veut et avec le nom qu'il veut
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exporterUneListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionnaireTags gestionnaire = GestionnaireTags.Instance;

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "XML Files (.xml)|*.xml",
                FilterIndex = 1
            };
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    File.Copy(gestionnaire.Chemin + gestionnaire.NomXML, sfd.FileName);
                    LabelMessage("Exportation effectuée.", Color.Green);
                }
                catch (Exception ex)
                {
                    LabelMessage(ex.Message, Color.Red);
                }
            }
        }
        #endregion
        #region Recherche
        /// <summary>
        /// Fais une recherche dès que le texte change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_recherche_TextChanged(object sender, EventArgs e)
        {
            string secteurRecherche = this.comboBox_Recherche.Text;
            string rechercheUtilisateur = this.textBox_recherche.Text;
            Recherche r = new Recherche();

            if (secteurRecherche == this.comboBox_Recherche.Items[0].ToString())//Tous
            {
                if (rechercheUtilisateur != "")
                {
                    imagesRecherche = r.RechercheTous(rechercheUtilisateur, images.ListeImg);

                    GestionListeImages imgRechercheTous = new GestionListeImages(imagesRecherche);
                    AfficheImage(imgRechercheTous);
                }
                else
                {
                    AfficheImage(images);
                }
            }
            else if (secteurRecherche == this.comboBox_Recherche.Items[1].ToString())//Photos
            {
                if (rechercheUtilisateur != "")
                {
                    imagesRecherche = r.RecherchePhotos(rechercheUtilisateur, images.ListeImg);

                    GestionListeImages imagesAvecTags = new GestionListeImages(imagesRecherche);
                    AfficheImage(imagesAvecTags);
                }
                else
                {
                    AfficheImage(images);
                }
            }
            else if (secteurRecherche == this.comboBox_Recherche.Items[2].ToString())//Tags
            {
                if (rechercheUtilisateur != "")
                {
                    imagesRecherche = r.RechercheTags(rechercheUtilisateur, images.ListeImg);

                    GestionListeImages imagesAvecTags = new GestionListeImages(imagesRecherche);
                    AfficheImage(imagesAvecTags);
                }
                else
                {
                    AfficheImage(images);
                }
            }
            else
            {
                LabelMessage("Impossible de lancer la recherche.", Color.Red);
            }
        }

        /// <summary>
        /// Fais une recherche quand on clique sur un tag d'une photo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_TagsAcceuil_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Recherche r = new Recherche();

            imagesRecherche = r.RechercheTags(e.Node.Text, images.ListeImg);//On recherche les photos avec le tag sélectionné

            imagesRecherche.AddRange(r.RechercheTagsTreeView(e.Node, images.ListeImg));//On fusionne les photos trouvées avant avec celle des fils

            imagesRecherche = r.EnleverDoubleImageListe(imagesRecherche);

            GestionListeImages imagesAvecTags = new GestionListeImages(imagesRecherche);
            
            AfficheImage(imagesAvecTags);
        }
        #endregion
        private void buttonRename_Click(object sender, EventArgs e)
        {
            if (richTextBoxRename.Enabled == false)//si on veut entrer dans e mode edition
            {
                richTextBoxRename.Enabled = true;
            }
            else//si on est deja dans le mode edition
            {
                string[] decompositionNom = imageSelect.Split('\\');
                string[] nom = decompositionNom[decompositionNom.Length - 1].Split('.');
                nom[nom.Length - 2] = richTextBoxRename.Text;
                string name = nom[0] + "." + nom[1];
                decompositionNom[decompositionNom.Length - 1] = name;
                string newUrl = decompositionNom[0] + "\\";
                foreach (string urlPart in decompositionNom)
                {
                    //newUrl = Path.Combine(newUrl, urlPart);
                    if (urlPart != decompositionNom[0])
                    {
                        newUrl = Path.Combine(newUrl, urlPart);
                    }
                }
                File.Move(imageSelect, newUrl);
                images.modifieURL(imageSelect, newUrl);
                imageSelect = newUrl;
                AfficheImage(images);
                richTextBoxRename.Enabled = false;
            }
        }
        #region SupprimerTag
        private void buttonSupprimerTag_Click(object sender, EventArgs e)
        {
            if (listViewTags.CheckBoxes == false)//si on est dans le mode par defaut
            {
                enCourDeModifSupr = true;
                listViewTags.CheckBoxes = true;
                label_info.ForeColor = Color.Green;
                label_info.Text = "cochez le ou les tags a supprimer puis appuyez de nouveau sur le bouton";
            }
            else//si on est deja dans le mode de suppression
            {
                List<string> tags = images.rechercheTags(imageSelect);
                foreach (ListViewItem tag in listViewTags.CheckedItems)
                {
                    tags.Remove(tag.Text);
                    listViewTags.Items.Remove(tag);
                }
                images.modifieTags(imageSelect, new List<string>(tags));
                listViewTags.CheckBoxes = false;
                richTextBoxInformationModif.Text = images.rechercheinfo(imageSelect);
                richTextBox_infoImage.Text = images.rechercheinfo(imageSelect);
                label_info.Text = "le(s) tag(s) on été supprimé(s)";
                label_info.ForeColor = Color.Green;
                enCourDeModifSupr = false;
            }
        }
        #endregion
        /// <summary>
        /// On demande à l'utilisateur s'il veut regarder l'image via notre application ou via Windows
        /// yes = windows, no = appli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxModifAfficheImage_DoubleClick(object sender, EventArgs e)
        {
            ChoixZoom cz = new ChoixZoom();
            DialogResult res = cz.ShowDialog();
            if (res == DialogResult.Yes)
            {
                Process.Start(imageSelect);
            }
            else if (res == DialogResult.No)
            {
                Form2 full = new Form2(imageSelect,images.rechercheOrientation(imageSelect));
                full.Show();
            }
        }

        private void textBox_recherche_Click(object sender, EventArgs e)
        {
            if (textBox_recherche.Text == "Rechercher nom ou tag d'une photo")
            {
                textBox_recherche.Clear();
            }
        }
        #region ajoutTag
        private void listViewTags_MouseUp(object sender, MouseEventArgs e)
        {
            if (!enCourDeModifAdd & !enCourDeModifSupr)
            {
                enCourDeModifAdd = true;
                listViewTags.Items.Add("nouveau_tag");
                listViewTags.Items[listViewTags.Items.Count-1].BeginEdit();
            }
            else
            {
                enCourDeModifAdd = false;
            }
        }
        private void listViewTags_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (e.Label == null)
            {
                LabelMessage("vous n'avez pas changer le nom par default du tag, il n'a pas été sauvegardé", Color.Red);
                e.CancelEdit = true;
                listViewTags.Items.RemoveAt(listViewTags.Items.Count - 1);
            }
            else
            {
                Boolean dejaPresent = false;
                foreach(string tag in images.rechercheTags(imageSelect))
                {
                    if(tag == e.Label)
                    {
                        dejaPresent = true;
                        break;
                    }
                }
                if (!dejaPresent)//si le tag n'est pas deja dans la liste
                {

                    TreeView tv = treeView_TagsModification;
                    List<string> tln = FindAllNodes(tv.Nodes);
                    List<string> noeudRessemblant = new List<string>();
                    noeudRessemblant.Add(e.Label);
                    if (e.Label.Length <= 4)    //le le mot est court on accepte une difference
                    {
                        foreach (string tag in tln)
                        {
                            if (levenshtein(tag, e.Label) <= 1)
                            {
                                noeudRessemblant.Add(tag);
                            }
                        }
                    }
                    else             //si le mot est long on en accepte deux
                    {
                        foreach (string tag in tln) 
                        {
                            if (levenshtein(tag, e.Label) <= 2)
                            {
                                noeudRessemblant.Add(tag);
                            }
                        }
                    }
                    Form3 fenetreChoix = new Form3(noeudRessemblant);
                    var resultatDialog = fenetreChoix.ShowDialog();
                    string tagAEnregistrer;
                    if (resultatDialog == DialogResult.OK)
                    {
                        tagAEnregistrer = fenetreChoix.Tag;
                    }
                    else
                    {
                        tagAEnregistrer = e.Label;
                    }
                    fenetreChoix.Dispose();
                    e.CancelEdit = true;
                    listViewTags.Items[e.Item].Text = tagAEnregistrer;
                    SauvegarderLaModificationDeTags(tagAEnregistrer); //on transmet le nouveau nom donné par l'evenement
                    FinalisationEnregistrementTagThread(tln, tagAEnregistrer);
                }
                else//si le tag est deja présent
                {
                    LabelMessage("ce tag Existe déjà, le tag n'a pas été sauvegardé", Color.Red);
                    e.CancelEdit = true;
                    listViewTags.Items.RemoveAt(listViewTags.Items.Count - 1);
                }
            }
        }
        private void FinalisationEnregistrementTagThread(List<string> tln,string tag)
        {
            TreeView tv = treeView_TagsModification;
            richTextBoxInformationModif.Text = images.rechercheinfo(imageSelect);
            richTextBox_infoImage.Text = images.rechercheinfo(imageSelect);
            GestionnaireTags gXML = GestionnaireTags.Instance;
            if (!(tln.Contains(tag))) //si le tag n'est pas deja dans le treeview
            {
                TreeNode newNode = new TreeNode(tag);
                tv.Nodes[0].Nodes.Add(newNode);//Ajout du noeud avec comme père la sélection
                tv.SelectedNode = newNode;//On sélectionne notre nouveau noeud
                tv.ExpandAll();//On étend TOUS le treeview
                gXML.AjouterTag(newNode.Text, tv.SelectedNode);//On ajoute le tag dans la liste
                gXML.exportToXml(GetTreeViewActif(), gXML.Chemin + gXML.NomXML);//Exportation en XML
            }
        }

        private void SauvegarderLaModificationDeTags(string nouveauTag)
        {
            List<string> listTag = new List<string>();
            for(int i = 0; i< listViewTags.Items.Count - 1; i++) //on ne prend pas la derniere valeur qui est le nouveau_nom
            {
                listTag.Add(listViewTags.Items[i].Text);
            }
            listTag.Add(nouveauTag); // mais on met le nouveau tag transmis en parametre
            images.modifieTags(imageSelect, new List<string>(listTag)); //on modifie les tags
        }
        private List<string> FindAllNodes(TreeNodeCollection nodes)
        {
            List<string> output = new List<string>();
            foreach (TreeNode tn in nodes)
            {
                output.Add(tn.Text);
                foreach (string tag in FindAllNodes(tn.Nodes))
                {
                    output.Add(tag);
                }
            }
            return output;
        }
        /// <summary>
        /// https://blog.netapsys.fr/algorithme-de-levenshtein-en-c-net/*
        /// algorithme de levenshtein
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private Int32 levenshtein(String a, String b)
        {
            if (string.IsNullOrEmpty(a))
            {
                if (!string.IsNullOrEmpty(b))
                {
                    return b.Length;
                }
                return 0;
            }
            if (string.IsNullOrEmpty(b))
            {
                if (!string.IsNullOrEmpty(a))
                {
                    return a.Length;
                }
                return 0;
            }
            Int32 cost;
            Int32[,] d = new int[a.Length + 1, b.Length + 1];
            Int32 min1;
            Int32 min2;
            Int32 min3;
            for (Int32 i = 0; i <= d.GetUpperBound(0); i += 1)
            {
                d[i, 0] = i;
            }
            for (Int32 i = 0; i <= d.GetUpperBound(1); i += 1)
            {
                d[0, i] = i;
            }
            for (Int32 i = 1; i <= d.GetUpperBound(0); i += 1)
            {
                for (Int32 j = 1; j <= d.GetUpperBound(1); j += 1)
                {
                    cost = Convert.ToInt32(!(a[i - 1] == b[j - 1]));

                    min1 = d[i - 1, j] + 1;
                    min2 = d[i, j - 1] + 1;
                    min3 = d[i - 1, j - 1] + cost;
                    d[i, j] = Math.Min(Math.Min(min1, min2), min3);
                }
            }
            return d[d.GetUpperBound(0), d.GetUpperBound(1)];
        }

#endregion
        private void RetourBtn_Click(object sender, EventArgs e)
        {
            RafraichirTreeView(); //Affiche les tags dans le treeView
            tableLayoutPanel_Parametres.Hide();
            tableLayoutPanel_Modification.Hide();
            tableLayoutPanel_Ensemble.Show();
        }
        
    }
}