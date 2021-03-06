﻿namespace ProjetDotNetM1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("coucou");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("coucou");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("coucou");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_recherche = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_Ensemble = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Accueil = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox_infoImage = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel_Photos = new System.Windows.Forms.TableLayoutPanel();
            this.treeView_TagsAcceuil = new System.Windows.Forms.TreeView();
            this.contextMenuStrip_Tags = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renommerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rafraîchirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_info = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel_Modification = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Photo = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.retourBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxModifAfficheImage = new System.Windows.Forms.PictureBox();
            this.tabInformations = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBoxInformationModif = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSupprimerTag = new System.Windows.Forms.Button();
            this.listViewTags = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRename = new System.Windows.Forms.Button();
            this.richTextBoxRename = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel_TreeView = new System.Windows.Forms.TableLayoutPanel();
            this.treeView_TagsModification = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_InformationsLogiciel = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_Recherche = new System.Windows.Forms.ComboBox();
            this.Fichier_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ouvrir_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Dossier_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Fichier_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importerUneListeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterUneListeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Edition_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VersionDuLogiciel_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tag_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Modifier_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MiseAJour_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_barreAccueil = new System.Windows.Forms.MenuStrip();
            this.tableLayoutPanel_Ensemble.SuspendLayout();
            this.tableLayoutPanel_Accueil.SuspendLayout();
            this.contextMenuStrip_Tags.SuspendLayout();
            this.tableLayoutPanel_Modification.SuspendLayout();
            this.tableLayoutPanel_Photo.SuspendLayout();
            this.tableLayoutPanel_Buttons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModifAfficheImage)).BeginInit();
            this.tabInformations.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel_TreeView.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel_InformationsLogiciel.SuspendLayout();
            this.menuStrip_barreAccueil.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_recherche
            // 
            this.textBox_recherche.BackColor = System.Drawing.Color.LightGray;
            this.textBox_recherche.Location = new System.Drawing.Point(1111, 3);
            this.textBox_recherche.Name = "textBox_recherche";
            this.textBox_recherche.Size = new System.Drawing.Size(210, 20);
            this.textBox_recherche.TabIndex = 7;
            this.textBox_recherche.Text = "Rechercher nom ou tag d\'une photo";
            this.textBox_recherche.Click += new System.EventHandler(this.textBox_recherche_Click);
            this.textBox_recherche.TextChanged += new System.EventHandler(this.textBox_recherche_TextChanged);
            // 
            // tableLayoutPanel_Ensemble
            // 
            this.tableLayoutPanel_Ensemble.ColumnCount = 2;
            this.tableLayoutPanel_Ensemble.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_Ensemble.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.71429F));
            this.tableLayoutPanel_Ensemble.Controls.Add(this.tableLayoutPanel_Accueil, 5, 0);
            this.tableLayoutPanel_Ensemble.Controls.Add(this.treeView_TagsAcceuil, 0, 0);
            this.tableLayoutPanel_Ensemble.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Ensemble.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Ensemble.Name = "tableLayoutPanel_Ensemble";
            this.tableLayoutPanel_Ensemble.RowCount = 1;
            this.tableLayoutPanel_Ensemble.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Ensemble.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 676F));
            this.tableLayoutPanel_Ensemble.Size = new System.Drawing.Size(1350, 676);
            this.tableLayoutPanel_Ensemble.TabIndex = 3;
            // 
            // tableLayoutPanel_Accueil
            // 
            this.tableLayoutPanel_Accueil.ColumnCount = 1;
            this.tableLayoutPanel_Accueil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Accueil.Controls.Add(this.richTextBox_infoImage, 0, 1);
            this.tableLayoutPanel_Accueil.Controls.Add(this.tableLayoutPanel_Photos, 0, 0);
            this.tableLayoutPanel_Accueil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Accueil.Location = new System.Drawing.Point(195, 3);
            this.tableLayoutPanel_Accueil.MaximumSize = new System.Drawing.Size(7892, 4320);
            this.tableLayoutPanel_Accueil.Name = "tableLayoutPanel_Accueil";
            this.tableLayoutPanel_Accueil.RowCount = 2;
            this.tableLayoutPanel_Accueil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel_Accueil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Accueil.Size = new System.Drawing.Size(1152, 670);
            this.tableLayoutPanel_Accueil.TabIndex = 0;
            // 
            // richTextBox_infoImage
            // 
            this.richTextBox_infoImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_infoImage.Enabled = false;
            this.richTextBox_infoImage.Location = new System.Drawing.Point(3, 539);
            this.richTextBox_infoImage.MaximumSize = new System.Drawing.Size(10000, 200);
            this.richTextBox_infoImage.Name = "richTextBox_infoImage";
            this.richTextBox_infoImage.Size = new System.Drawing.Size(1146, 128);
            this.richTextBox_infoImage.TabIndex = 1;
            this.richTextBox_infoImage.Text = "Information de l\'image sélectionnée";
            // 
            // tableLayoutPanel_Photos
            // 
            this.tableLayoutPanel_Photos.AutoScroll = true;
            this.tableLayoutPanel_Photos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel_Photos.ColumnCount = 5;
            this.tableLayoutPanel_Photos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Photos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Photos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Photos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Photos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Photos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Photos.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_Photos.MaximumSize = new System.Drawing.Size(7892, 4020);
            this.tableLayoutPanel_Photos.Name = "tableLayoutPanel_Photos";
            this.tableLayoutPanel_Photos.RowCount = 3;
            this.tableLayoutPanel_Photos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel_Photos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel_Photos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel_Photos.Size = new System.Drawing.Size(1146, 530);
            this.tableLayoutPanel_Photos.TabIndex = 2;
            // 
            // treeView_TagsAcceuil
            // 
            this.treeView_TagsAcceuil.AllowDrop = true;
            this.treeView_TagsAcceuil.ContextMenuStrip = this.contextMenuStrip_Tags;
            this.treeView_TagsAcceuil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_TagsAcceuil.Location = new System.Drawing.Point(3, 3);
            this.treeView_TagsAcceuil.MaximumSize = new System.Drawing.Size(300, 4320);
            this.treeView_TagsAcceuil.MinimumSize = new System.Drawing.Size(300, 500);
            this.treeView_TagsAcceuil.Name = "treeView_TagsAcceuil";
            this.treeView_TagsAcceuil.Size = new System.Drawing.Size(300, 670);
            this.treeView_TagsAcceuil.TabIndex = 1;
            this.treeView_TagsAcceuil.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView_TagsAcceuil_AfterLabelEdit);
            this.treeView_TagsAcceuil.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView_TagsAcceuil_ItemDrag);
            this.treeView_TagsAcceuil.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_TagsAcceuil_NodeMouseClick);
            this.treeView_TagsAcceuil.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView_TagsAcceuil_DragDrop);
            this.treeView_TagsAcceuil.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView_TagsAcceuil_DragEnter);
            // 
            // contextMenuStrip_Tags
            // 
            this.contextMenuStrip_Tags.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.renommerToolStripMenuItem,
            this.rafraîchirToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip_Tags.Name = "contextMenuStrip_Tags";
            this.contextMenuStrip_Tags.Size = new System.Drawing.Size(134, 92);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.AjouterToolStripMenuItem_Click);
            // 
            // renommerToolStripMenuItem
            // 
            this.renommerToolStripMenuItem.Name = "renommerToolStripMenuItem";
            this.renommerToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.renommerToolStripMenuItem.Text = "Renommer";
            this.renommerToolStripMenuItem.Click += new System.EventHandler(this.RenommerToolStripMenuItem_Click_1);
            // 
            // rafraîchirToolStripMenuItem
            // 
            this.rafraîchirToolStripMenuItem.Name = "rafraîchirToolStripMenuItem";
            this.rafraîchirToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.rafraîchirToolStripMenuItem.Text = "Rafraîchir";
            this.rafraîchirToolStripMenuItem.Click += new System.EventHandler(this.RafraîchirToolStripMenuItem_Click_1);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.BackColor = System.Drawing.Color.LightGray;
            this.label_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info.ForeColor = System.Drawing.Color.Green;
            this.label_info.Location = new System.Drawing.Point(247, 0);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(83, 13);
            this.label_info.TabIndex = 4;
            this.label_info.Text = "Label de MàJ";
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(3, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(238, 23);
            this.progressBar.TabIndex = 8;
            this.progressBar.Visible = false;
            // 
            // tableLayoutPanel_Modification
            // 
            this.tableLayoutPanel_Modification.ColumnCount = 2;
            this.tableLayoutPanel_Modification.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel_Modification.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel_Modification.Controls.Add(this.tableLayoutPanel_Photo, 1, 0);
            this.tableLayoutPanel_Modification.Controls.Add(this.tableLayoutPanel_TreeView, 0, 0);
            this.tableLayoutPanel_Modification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Modification.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Modification.Name = "tableLayoutPanel_Modification";
            this.tableLayoutPanel_Modification.RowCount = 1;
            this.tableLayoutPanel_Modification.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Modification.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 676F));
            this.tableLayoutPanel_Modification.Size = new System.Drawing.Size(1350, 676);
            this.tableLayoutPanel_Modification.TabIndex = 2;
            // 
            // tableLayoutPanel_Photo
            // 
            this.tableLayoutPanel_Photo.ColumnCount = 1;
            this.tableLayoutPanel_Photo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Photo.Controls.Add(this.tableLayoutPanel_Buttons, 0, 1);
            this.tableLayoutPanel_Photo.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel_Photo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Photo.Location = new System.Drawing.Point(205, 3);
            this.tableLayoutPanel_Photo.Name = "tableLayoutPanel_Photo";
            this.tableLayoutPanel_Photo.RowCount = 2;
            this.tableLayoutPanel_Photo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87F));
            this.tableLayoutPanel_Photo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel_Photo.Size = new System.Drawing.Size(1142, 670);
            this.tableLayoutPanel_Photo.TabIndex = 0;
            // 
            // tableLayoutPanel_Buttons
            // 
            this.tableLayoutPanel_Buttons.ColumnCount = 1;
            this.tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Buttons.Controls.Add(this.retourBtn, 0, 0);
            this.tableLayoutPanel_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Buttons.Location = new System.Drawing.Point(3, 585);
            this.tableLayoutPanel_Buttons.MaximumSize = new System.Drawing.Size(0, 66);
            this.tableLayoutPanel_Buttons.MinimumSize = new System.Drawing.Size(0, 66);
            this.tableLayoutPanel_Buttons.Name = "tableLayoutPanel_Buttons";
            this.tableLayoutPanel_Buttons.RowCount = 1;
            this.tableLayoutPanel_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Buttons.Size = new System.Drawing.Size(1136, 66);
            this.tableLayoutPanel_Buttons.TabIndex = 0;
            // 
            // retourBtn
            // 
            this.retourBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.retourBtn.AutoSize = true;
            this.retourBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.retourBtn.Image = global::ProjetDotNetM1.Properties.Resources.arrow_left;
            this.retourBtn.Location = new System.Drawing.Point(480, 15);
            this.retourBtn.Margin = new System.Windows.Forms.Padding(480, 15, 480, 15);
            this.retourBtn.MaximumSize = new System.Drawing.Size(70, 36);
            this.retourBtn.MinimumSize = new System.Drawing.Size(70, 36);
            this.retourBtn.Name = "retourBtn";
            this.retourBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.retourBtn.Size = new System.Drawing.Size(70, 36);
            this.retourBtn.TabIndex = 0;
            this.retourBtn.UseVisualStyleBackColor = false;
            this.retourBtn.Click += new System.EventHandler(this.RetourBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxModifAfficheImage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabInformations, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1136, 576);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pictureBoxModifAfficheImage
            // 
            this.pictureBoxModifAfficheImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxModifAfficheImage.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxModifAfficheImage.Name = "pictureBoxModifAfficheImage";
            this.pictureBoxModifAfficheImage.Size = new System.Drawing.Size(1130, 397);
            this.pictureBoxModifAfficheImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxModifAfficheImage.TabIndex = 0;
            this.pictureBoxModifAfficheImage.TabStop = false;
            this.pictureBoxModifAfficheImage.DoubleClick += new System.EventHandler(this.pictureBoxModifAfficheImage_DoubleClick);
            // 
            // tabInformations
            // 
            this.tabInformations.Controls.Add(this.tabPage1);
            this.tabInformations.Controls.Add(this.tabPage2);
            this.tabInformations.Controls.Add(this.tabPage3);
            this.tabInformations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabInformations.Location = new System.Drawing.Point(0, 403);
            this.tabInformations.Margin = new System.Windows.Forms.Padding(0);
            this.tabInformations.MaximumSize = new System.Drawing.Size(7892, 200);
            this.tabInformations.Name = "tabInformations";
            this.tabInformations.SelectedIndex = 0;
            this.tabInformations.Size = new System.Drawing.Size(1136, 173);
            this.tabInformations.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBoxInformationModif);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1128, 147);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Informations";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBoxInformationModif
            // 
            this.richTextBoxInformationModif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxInformationModif.Enabled = false;
            this.richTextBoxInformationModif.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxInformationModif.Name = "richTextBoxInformationModif";
            this.richTextBoxInformationModif.Size = new System.Drawing.Size(1122, 141);
            this.richTextBoxInformationModif.TabIndex = 0;
            this.richTextBoxInformationModif.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1128, 147);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tags";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.Controls.Add(this.buttonSupprimerTag, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.listViewTags, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1128, 147);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonSupprimerTag
            // 
            this.buttonSupprimerTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSupprimerTag.Image = global::ProjetDotNetM1.Properties.Resources.delete;
            this.buttonSupprimerTag.Location = new System.Drawing.Point(931, 3);
            this.buttonSupprimerTag.Name = "buttonSupprimerTag";
            this.buttonSupprimerTag.Size = new System.Drawing.Size(194, 141);
            this.buttonSupprimerTag.TabIndex = 0;
            this.buttonSupprimerTag.UseVisualStyleBackColor = true;
            this.buttonSupprimerTag.Click += new System.EventHandler(this.buttonSupprimerTag_Click);
            // 
            // listViewTags
            // 
            this.listViewTags.AllowDrop = true;
            this.listViewTags.CheckBoxes = true;
            this.listViewTags.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            this.listViewTags.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listViewTags.LabelEdit = true;
            this.listViewTags.Location = new System.Drawing.Point(3, 3);
            this.listViewTags.Name = "listViewTags";
            this.listViewTags.Size = new System.Drawing.Size(922, 141);
            this.listViewTags.TabIndex = 1;
            this.listViewTags.UseCompatibleStateImageBehavior = false;
            this.listViewTags.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listViewTags_AfterLabelEdit);
            this.listViewTags.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listViewTags_MouseUp);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1128, 147);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Renommer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.Controls.Add(this.buttonRename, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.richTextBoxRename, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1122, 141);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // buttonRename
            // 
            this.buttonRename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRename.Image = global::ProjetDotNetM1.Properties.Resources.square_edit_outline;
            this.buttonRename.Location = new System.Drawing.Point(1025, 3);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(94, 135);
            this.buttonRename.TabIndex = 0;
            this.buttonRename.UseVisualStyleBackColor = true;
            this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // richTextBoxRename
            // 
            this.richTextBoxRename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxRename.Enabled = false;
            this.richTextBoxRename.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxRename.Name = "richTextBoxRename";
            this.richTextBoxRename.Size = new System.Drawing.Size(1016, 135);
            this.richTextBoxRename.TabIndex = 1;
            this.richTextBoxRename.Text = "";
            // 
            // tableLayoutPanel_TreeView
            // 
            this.tableLayoutPanel_TreeView.ColumnCount = 1;
            this.tableLayoutPanel_TreeView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_TreeView.Controls.Add(this.treeView_TagsModification, 0, 0);
            this.tableLayoutPanel_TreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TreeView.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_TreeView.Name = "tableLayoutPanel_TreeView";
            this.tableLayoutPanel_TreeView.RowCount = 1;
            this.tableLayoutPanel_TreeView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.09612F));
            this.tableLayoutPanel_TreeView.Size = new System.Drawing.Size(196, 670);
            this.tableLayoutPanel_TreeView.TabIndex = 1;
            // 
            // treeView_TagsModification
            // 
            this.treeView_TagsModification.AllowDrop = true;
            this.treeView_TagsModification.ContextMenuStrip = this.contextMenuStrip_Tags;
            this.treeView_TagsModification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_TagsModification.Location = new System.Drawing.Point(3, 3);
            this.treeView_TagsModification.MaximumSize = new System.Drawing.Size(300, 4320);
            this.treeView_TagsModification.Name = "treeView_TagsModification";
            this.treeView_TagsModification.Size = new System.Drawing.Size(190, 664);
            this.treeView_TagsModification.TabIndex = 0;
            this.treeView_TagsModification.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView_TagsModification_ItemDrag);
            this.treeView_TagsModification.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView_TagsModification_DragDrop);
            this.treeView_TagsModification.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView_TagsModification_DragEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel_Ensemble);
            this.panel1.Controls.Add(this.tableLayoutPanel_Modification);
            this.panel1.Controls.Add(this.tableLayoutPanel_InformationsLogiciel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 705);
            this.panel1.TabIndex = 7;
            // 
            // tableLayoutPanel_InformationsLogiciel
            // 
            this.tableLayoutPanel_InformationsLogiciel.ColumnCount = 4;
            this.tableLayoutPanel_InformationsLogiciel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.06639F));
            this.tableLayoutPanel_InformationsLogiciel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.93361F));
            this.tableLayoutPanel_InformationsLogiciel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel_InformationsLogiciel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 241F));
            this.tableLayoutPanel_InformationsLogiciel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel_InformationsLogiciel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.36034F));
            this.tableLayoutPanel_InformationsLogiciel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.63966F));
            this.tableLayoutPanel_InformationsLogiciel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            this.tableLayoutPanel_InformationsLogiciel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel_InformationsLogiciel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.06639F));
            this.tableLayoutPanel_InformationsLogiciel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.93361F));
            this.tableLayoutPanel_InformationsLogiciel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel_InformationsLogiciel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.tableLayoutPanel_InformationsLogiciel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.36034F));
            this.tableLayoutPanel_InformationsLogiciel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.63966F));
            this.tableLayoutPanel_InformationsLogiciel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            this.tableLayoutPanel_InformationsLogiciel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel_InformationsLogiciel.Controls.Add(this.progressBar, 0, 0);
            this.tableLayoutPanel_InformationsLogiciel.Controls.Add(this.label_info, 1, 0);
            this.tableLayoutPanel_InformationsLogiciel.Controls.Add(this.textBox_recherche, 3, 0);
            this.tableLayoutPanel_InformationsLogiciel.Controls.Add(this.comboBox_Recherche, 2, 0);
            this.tableLayoutPanel_InformationsLogiciel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel_InformationsLogiciel.Location = new System.Drawing.Point(0, 676);
            this.tableLayoutPanel_InformationsLogiciel.Name = "tableLayoutPanel_InformationsLogiciel";
            this.tableLayoutPanel_InformationsLogiciel.RowCount = 1;
            this.tableLayoutPanel_InformationsLogiciel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_InformationsLogiciel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_InformationsLogiciel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_InformationsLogiciel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_InformationsLogiciel.Size = new System.Drawing.Size(1350, 29);
            this.tableLayoutPanel_InformationsLogiciel.TabIndex = 8;
            // 
            // comboBox_Recherche
            // 
            this.comboBox_Recherche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Recherche.FormattingEnabled = true;
            this.comboBox_Recherche.Items.AddRange(new object[] {
            "Tous",
            "Photos",
            "Tags"});
            this.comboBox_Recherche.Location = new System.Drawing.Point(1020, 3);
            this.comboBox_Recherche.Name = "comboBox_Recherche";
            this.comboBox_Recherche.Size = new System.Drawing.Size(85, 21);
            this.comboBox_Recherche.TabIndex = 9;
            // 
            // Fichier_ToolStripMenuItem
            // 
            this.Fichier_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ouvrir_ToolStripMenuItem,
            this.listeDesTagsToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.Fichier_ToolStripMenuItem.Name = "Fichier_ToolStripMenuItem";
            this.Fichier_ToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.Fichier_ToolStripMenuItem.Text = "Fichier";
            // 
            // Ouvrir_ToolStripMenuItem
            // 
            this.Ouvrir_ToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.Ouvrir_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Dossier_ToolStripMenuItem,
            this.Fichier_ToolStripMenuItem1});
            this.Ouvrir_ToolStripMenuItem.Name = "Ouvrir_ToolStripMenuItem";
            this.Ouvrir_ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.Ouvrir_ToolStripMenuItem.Text = "Importer";
            // 
            // Dossier_ToolStripMenuItem
            // 
            this.Dossier_ToolStripMenuItem.Name = "Dossier_ToolStripMenuItem";
            this.Dossier_ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.Dossier_ToolStripMenuItem.Text = "Dossier";
            this.Dossier_ToolStripMenuItem.Click += new System.EventHandler(this.DossierToolStripMenuItem_Click);
            // 
            // Fichier_ToolStripMenuItem1
            // 
            this.Fichier_ToolStripMenuItem1.Name = "Fichier_ToolStripMenuItem1";
            this.Fichier_ToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.Fichier_ToolStripMenuItem1.Text = "Fichier";
            this.Fichier_ToolStripMenuItem1.Click += new System.EventHandler(this.FichierToolStripMenuItem1_Click);
            // 
            // listeDesTagsToolStripMenuItem
            // 
            this.listeDesTagsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importerUneListeToolStripMenuItem,
            this.exporterUneListeToolStripMenuItem});
            this.listeDesTagsToolStripMenuItem.Name = "listeDesTagsToolStripMenuItem";
            this.listeDesTagsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.listeDesTagsToolStripMenuItem.Text = "Liste des tags";
            // 
            // importerUneListeToolStripMenuItem
            // 
            this.importerUneListeToolStripMenuItem.Name = "importerUneListeToolStripMenuItem";
            this.importerUneListeToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.importerUneListeToolStripMenuItem.Text = "Importer une liste...";
            this.importerUneListeToolStripMenuItem.Click += new System.EventHandler(this.importerUneListeToolStripMenuItem_Click);
            // 
            // exporterUneListeToolStripMenuItem
            // 
            this.exporterUneListeToolStripMenuItem.Name = "exporterUneListeToolStripMenuItem";
            this.exporterUneListeToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.exporterUneListeToolStripMenuItem.Text = "Exporter une liste...";
            this.exporterUneListeToolStripMenuItem.Click += new System.EventHandler(this.exporterUneListeToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.aideToolStripMenuItem.Text = "Aide";
            this.aideToolStripMenuItem.Click += new System.EventHandler(this.aideToolStripMenuItem_Click);
            // 
            // Edition_ToolStripMenuItem
            // 
            this.Edition_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VersionDuLogiciel_ToolStripMenuItem});
            this.Edition_ToolStripMenuItem.Name = "Edition_ToolStripMenuItem";
            this.Edition_ToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.Edition_ToolStripMenuItem.Text = "Edition";
            // 
            // VersionDuLogiciel_ToolStripMenuItem
            // 
            this.VersionDuLogiciel_ToolStripMenuItem.Name = "VersionDuLogiciel_ToolStripMenuItem";
            this.VersionDuLogiciel_ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.VersionDuLogiciel_ToolStripMenuItem.Text = "A propos";
            this.VersionDuLogiciel_ToolStripMenuItem.Click += new System.EventHandler(this.VersionDuLogicielToolStripMenuItem_Click);
            // 
            // Tag_ToolStripMenuItem
            // 
            this.Tag_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Modifier_ToolStripMenuItem});
            this.Tag_ToolStripMenuItem.Name = "Tag_ToolStripMenuItem";
            this.Tag_ToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.Tag_ToolStripMenuItem.Text = "Tag";
            // 
            // Modifier_ToolStripMenuItem
            // 
            this.Modifier_ToolStripMenuItem.Name = "Modifier_ToolStripMenuItem";
            this.Modifier_ToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.Modifier_ToolStripMenuItem.Text = "Modifier";
            this.Modifier_ToolStripMenuItem.Click += new System.EventHandler(this.ModifierToolStripMenuItem_Click);
            // 
            // MiseAJour_ToolStripMenuItem
            // 
            this.MiseAJour_ToolStripMenuItem.Name = "MiseAJour_ToolStripMenuItem";
            this.MiseAJour_ToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.MiseAJour_ToolStripMenuItem.Text = "Mise à jour";
            this.MiseAJour_ToolStripMenuItem.Click += new System.EventHandler(this.MiseAJourToolStripMenuItem_Click_1);
            // 
            // menuStrip_barreAccueil
            // 
            this.menuStrip_barreAccueil.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip_barreAccueil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Fichier_ToolStripMenuItem,
            this.Edition_ToolStripMenuItem,
            this.Tag_ToolStripMenuItem,
            this.MiseAJour_ToolStripMenuItem});
            this.menuStrip_barreAccueil.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_barreAccueil.Name = "menuStrip_barreAccueil";
            this.menuStrip_barreAccueil.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip_barreAccueil.TabIndex = 1;
            this.menuStrip_barreAccueil.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip_barreAccueil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_barreAccueil;
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "Form1";
            this.Text = "Application";
            this.tableLayoutPanel_Ensemble.ResumeLayout(false);
            this.tableLayoutPanel_Accueil.ResumeLayout(false);
            this.contextMenuStrip_Tags.ResumeLayout(false);
            this.tableLayoutPanel_Modification.ResumeLayout(false);
            this.tableLayoutPanel_Photo.ResumeLayout(false);
            this.tableLayoutPanel_Buttons.ResumeLayout(false);
            this.tableLayoutPanel_Buttons.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModifAfficheImage)).EndInit();
            this.tabInformations.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel_TreeView.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel_InformationsLogiciel.ResumeLayout(false);
            this.tableLayoutPanel_InformationsLogiciel.PerformLayout();
            this.menuStrip_barreAccueil.ResumeLayout(false);
            this.menuStrip_barreAccueil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_recherche;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Ensemble;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Accueil;
        private System.Windows.Forms.TreeView treeView_TagsAcceuil;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.RichTextBox richTextBox_infoImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Modification;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Photo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Buttons;
        private System.Windows.Forms.Button retourBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TreeView;
        private System.Windows.Forms.TreeView treeView_TagsModification;
        private System.Windows.Forms.ToolStripMenuItem Fichier_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Ouvrir_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Dossier_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Fichier_ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Edition_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VersionDuLogiciel_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tag_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Modifier_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MiseAJour_ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip_barreAccueil;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Photos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_InformationsLogiciel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Tags;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renommerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rafraîchirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox_Recherche;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxModifAfficheImage;
        private System.Windows.Forms.TabControl tabInformations;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBoxInformationModif;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonSupprimerTag;
        private System.Windows.Forms.ListView listViewTags;
        private System.Windows.Forms.ToolStripMenuItem listeDesTagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importerUneListeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporterUneListeToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonRename;
        private System.Windows.Forms.RichTextBox richTextBoxRename;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
    }
}

