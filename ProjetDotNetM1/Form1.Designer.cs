namespace ProjetDotNetM1
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
            this.tableLayoutPanel_Ensemble = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Accueil = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_listeImage = new System.Windows.Forms.DataGridView();
            this.richTextBox_infoImage = new System.Windows.Forms.RichTextBox();
            this.treeView_tag = new System.Windows.Forms.TreeView();
            this.contextMenuStrip_Tag = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Ajouter_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Renommer_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rafraîchir_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Supprimer_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_info = new System.Windows.Forms.Label();
            this.Fichier_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ouvrir_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Dossier_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Fichier_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Paramètres_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Edition_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModeDiaporama_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VersionDuLogiciel_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tag_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Modifier_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MiseÀJour_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_barreAccueil = new System.Windows.Forms.MenuStrip();
            this.tableLayoutPanel_Modification = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_BoutonsConfirmerAnnuler = new System.Windows.Forms.TableLayoutPanel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.confirmerBtn = new System.Windows.Forms.Button();
            this.dataGridView_photos = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel_TreeViewTags = new System.Windows.Forms.TableLayoutPanel();
            this.treeView_TagsModification = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_InformationsLogiciel = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.button_Go_Recherche = new System.Windows.Forms.Button();
            this.textBox_recherche = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_Ensemble.SuspendLayout();
            this.tableLayoutPanel_Accueil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listeImage)).BeginInit();
            this.contextMenuStrip_Tag.SuspendLayout();
            this.menuStrip_barreAccueil.SuspendLayout();
            this.tableLayoutPanel_Modification.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel_BoutonsConfirmerAnnuler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_photos)).BeginInit();
            this.tableLayoutPanel_TreeViewTags.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel_InformationsLogiciel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Ensemble
            // 
            this.tableLayoutPanel_Ensemble.ColumnCount = 2;
            this.tableLayoutPanel_Ensemble.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Ensemble.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1005F));
            this.tableLayoutPanel_Ensemble.Controls.Add(this.tableLayoutPanel_Accueil, 5, 0);
            this.tableLayoutPanel_Ensemble.Controls.Add(this.treeView_tag, 0, 0);
            this.tableLayoutPanel_Ensemble.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Ensemble.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Ensemble.Name = "tableLayoutPanel_Ensemble";
            this.tableLayoutPanel_Ensemble.RowCount = 2;
            this.tableLayoutPanel_Ensemble.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Ensemble.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel_Ensemble.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 547F));
            this.tableLayoutPanel_Ensemble.Size = new System.Drawing.Size(1224, 518);
            this.tableLayoutPanel_Ensemble.TabIndex = 3;
            // 
            // tableLayoutPanel_Accueil
            // 
            this.tableLayoutPanel_Accueil.ColumnCount = 1;
            this.tableLayoutPanel_Accueil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Accueil.Controls.Add(this.dataGridView_listeImage, 3, 0);
            this.tableLayoutPanel_Accueil.Controls.Add(this.richTextBox_infoImage, 0, 1);
            this.tableLayoutPanel_Accueil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Accueil.Location = new System.Drawing.Point(222, 3);
            this.tableLayoutPanel_Accueil.Name = "tableLayoutPanel_Accueil";
            this.tableLayoutPanel_Accueil.RowCount = 2;
            this.tableLayoutPanel_Accueil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 410F));
            this.tableLayoutPanel_Accueil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel_Accueil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel_Accueil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Accueil.Size = new System.Drawing.Size(999, 483);
            this.tableLayoutPanel_Accueil.TabIndex = 0;
            // 
            // dataGridView_listeImage
            // 
            this.dataGridView_listeImage.AllowUserToAddRows = false;
            this.dataGridView_listeImage.AllowUserToDeleteRows = false;
            this.dataGridView_listeImage.AllowUserToResizeColumns = false;
            this.dataGridView_listeImage.AllowUserToResizeRows = false;
            this.dataGridView_listeImage.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView_listeImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listeImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_listeImage.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_listeImage.Name = "dataGridView_listeImage";
            this.dataGridView_listeImage.ReadOnly = true;
            this.dataGridView_listeImage.Size = new System.Drawing.Size(993, 404);
            this.dataGridView_listeImage.TabIndex = 0;
            this.dataGridView_listeImage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_listeImage_CellContentClick);
            // 
            // richTextBox_infoImage
            // 
            this.richTextBox_infoImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_infoImage.Enabled = false;
            this.richTextBox_infoImage.Location = new System.Drawing.Point(3, 413);
            this.richTextBox_infoImage.Name = "richTextBox_infoImage";
            this.richTextBox_infoImage.Size = new System.Drawing.Size(993, 67);
            this.richTextBox_infoImage.TabIndex = 1;
            this.richTextBox_infoImage.Text = "Information de l\'image sélectionnée";
            // 
            // treeView_tag
            // 
            this.treeView_tag.ContextMenuStrip = this.contextMenuStrip_Tag;
            this.treeView_tag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_tag.Location = new System.Drawing.Point(3, 3);
            this.treeView_tag.Name = "treeView_tag";
            this.treeView_tag.Size = new System.Drawing.Size(213, 483);
            this.treeView_tag.TabIndex = 1;
            // 
            // contextMenuStrip_Tag
            // 
            this.contextMenuStrip_Tag.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ajouter_ToolStripMenuItem,
            this.Renommer_ToolStripMenuItem,
            this.Rafraîchir_ToolStripMenuItem,
            this.Supprimer_ToolStripMenuItem});
            this.contextMenuStrip_Tag.Name = "contextMenuStrip_Tag";
            this.contextMenuStrip_Tag.Size = new System.Drawing.Size(134, 92);
            // 
            // Ajouter_ToolStripMenuItem
            // 
            this.Ajouter_ToolStripMenuItem.Name = "Ajouter_ToolStripMenuItem";
            this.Ajouter_ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.Ajouter_ToolStripMenuItem.Text = "Ajouter";
            this.Ajouter_ToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Ajouter_Click);
            // 
            // Renommer_ToolStripMenuItem
            // 
            this.Renommer_ToolStripMenuItem.Name = "Renommer_ToolStripMenuItem";
            this.Renommer_ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.Renommer_ToolStripMenuItem.Text = "Renommer";
            this.Renommer_ToolStripMenuItem.Click += new System.EventHandler(this.renommerToolStripMenuItem_Click);
            // 
            // Rafraîchir_ToolStripMenuItem
            // 
            this.Rafraîchir_ToolStripMenuItem.Name = "Rafraîchir_ToolStripMenuItem";
            this.Rafraîchir_ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.Rafraîchir_ToolStripMenuItem.Text = "Rafraîchir";
            this.Rafraîchir_ToolStripMenuItem.Click += new System.EventHandler(this.rafraîchirToolStripMenuItem_Click);
            // 
            // Supprimer_ToolStripMenuItem
            // 
            this.Supprimer_ToolStripMenuItem.Name = "Supprimer_ToolStripMenuItem";
            this.Supprimer_ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.Supprimer_ToolStripMenuItem.Text = "Supprimer";
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.BackColor = System.Drawing.Color.LightGray;
            this.label_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info.ForeColor = System.Drawing.Color.Green;
            this.label_info.Location = new System.Drawing.Point(248, 0);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(83, 13);
            this.label_info.TabIndex = 4;
            this.label_info.Text = "Label de MàJ";
            // 
            // Fichier_ToolStripMenuItem
            // 
            this.Fichier_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ouvrir_ToolStripMenuItem,
            this.Paramètres_ToolStripMenuItem});
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
            this.Ouvrir_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Ouvrir_ToolStripMenuItem.Text = "Importer";
            // 
            // Dossier_ToolStripMenuItem
            // 
            this.Dossier_ToolStripMenuItem.Name = "Dossier_ToolStripMenuItem";
            this.Dossier_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Dossier_ToolStripMenuItem.Text = "Dossier";
            this.Dossier_ToolStripMenuItem.Click += new System.EventHandler(this.dossierToolStripMenuItem_Click);
            // 
            // Fichier_ToolStripMenuItem1
            // 
            this.Fichier_ToolStripMenuItem1.Name = "Fichier_ToolStripMenuItem1";
            this.Fichier_ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.Fichier_ToolStripMenuItem1.Text = "Fichier";
            this.Fichier_ToolStripMenuItem1.Click += new System.EventHandler(this.fichierToolStripMenuItem1_Click);
            // 
            // Paramètres_ToolStripMenuItem
            // 
            this.Paramètres_ToolStripMenuItem.Name = "Paramètres_ToolStripMenuItem";
            this.Paramètres_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Paramètres_ToolStripMenuItem.Text = "Paramètres";
            this.Paramètres_ToolStripMenuItem.Click += new System.EventHandler(this.paramètresToolStripMenuItem_Click);
            // 
            // Edition_ToolStripMenuItem
            // 
            this.Edition_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModeDiaporama_ToolStripMenuItem,
            this.VersionDuLogiciel_ToolStripMenuItem});
            this.Edition_ToolStripMenuItem.Name = "Edition_ToolStripMenuItem";
            this.Edition_ToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.Edition_ToolStripMenuItem.Text = "Edition";
            // 
            // ModeDiaporama_ToolStripMenuItem
            // 
            this.ModeDiaporama_ToolStripMenuItem.Name = "ModeDiaporama_ToolStripMenuItem";
            this.ModeDiaporama_ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ModeDiaporama_ToolStripMenuItem.Text = "Mode diaporama";
            // 
            // VersionDuLogiciel_ToolStripMenuItem
            // 
            this.VersionDuLogiciel_ToolStripMenuItem.Name = "VersionDuLogiciel_ToolStripMenuItem";
            this.VersionDuLogiciel_ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.VersionDuLogiciel_ToolStripMenuItem.Text = "A propos";
            this.VersionDuLogiciel_ToolStripMenuItem.Click += new System.EventHandler(this.versionDuLogicielToolStripMenuItem_Click);
            // 
            // Tag_ToolStripMenuItem
            // 
            this.Tag_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Modifier_ToolStripMenuItem});
            this.Tag_ToolStripMenuItem.Name = "Tag_ToolStripMenuItem";
            this.Tag_ToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.Tag_ToolStripMenuItem.Text = "Tag";
            // 
            // Modifier_ToolStripMenuItem
            // 
            this.Modifier_ToolStripMenuItem.Name = "Modifier_ToolStripMenuItem";
            this.Modifier_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Modifier_ToolStripMenuItem.Text = "Modifier";
            this.Modifier_ToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // MiseÀJour_ToolStripMenuItem
            // 
            this.MiseÀJour_ToolStripMenuItem.Name = "MiseÀJour_ToolStripMenuItem";
            this.MiseÀJour_ToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.MiseÀJour_ToolStripMenuItem.Text = "Mise à jour";
            this.MiseÀJour_ToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip_barreAccueil
            // 
            this.menuStrip_barreAccueil.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip_barreAccueil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Fichier_ToolStripMenuItem,
            this.Edition_ToolStripMenuItem,
            this.Tag_ToolStripMenuItem,
            this.MiseÀJour_ToolStripMenuItem});
            this.menuStrip_barreAccueil.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_barreAccueil.Name = "menuStrip_barreAccueil";
            this.menuStrip_barreAccueil.Size = new System.Drawing.Size(1224, 24);
            this.menuStrip_barreAccueil.TabIndex = 1;
            this.menuStrip_barreAccueil.Text = "menuStrip1";
            // 
            // tableLayoutPanel_Modification
            // 
            this.tableLayoutPanel_Modification.ColumnCount = 2;
            this.tableLayoutPanel_Modification.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.71569F));
            this.tableLayoutPanel_Modification.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.28432F));
            this.tableLayoutPanel_Modification.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel_Modification.Controls.Add(this.tableLayoutPanel_TreeViewTags, 0, 0);
            this.tableLayoutPanel_Modification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Modification.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Modification.Name = "tableLayoutPanel_Modification";
            this.tableLayoutPanel_Modification.RowCount = 2;
            this.tableLayoutPanel_Modification.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Modification.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Modification.Size = new System.Drawing.Size(1224, 518);
            this.tableLayoutPanel_Modification.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel_BoutonsConfirmerAnnuler, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_photos, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(330, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.69131F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.30869F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(891, 492);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel_BoutonsConfirmerAnnuler
            // 
            this.tableLayoutPanel_BoutonsConfirmerAnnuler.ColumnCount = 2;
            this.tableLayoutPanel_BoutonsConfirmerAnnuler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_BoutonsConfirmerAnnuler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_BoutonsConfirmerAnnuler.Controls.Add(this.cancelBtn, 1, 0);
            this.tableLayoutPanel_BoutonsConfirmerAnnuler.Controls.Add(this.confirmerBtn, 0, 0);
            this.tableLayoutPanel_BoutonsConfirmerAnnuler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_BoutonsConfirmerAnnuler.Location = new System.Drawing.Point(3, 429);
            this.tableLayoutPanel_BoutonsConfirmerAnnuler.Name = "tableLayoutPanel_BoutonsConfirmerAnnuler";
            this.tableLayoutPanel_BoutonsConfirmerAnnuler.RowCount = 1;
            this.tableLayoutPanel_BoutonsConfirmerAnnuler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_BoutonsConfirmerAnnuler.Size = new System.Drawing.Size(885, 60);
            this.tableLayoutPanel_BoutonsConfirmerAnnuler.TabIndex = 0;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelBtn.Location = new System.Drawing.Point(612, 20);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(170, 20, 170, 20);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(103, 20);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Annuler";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // confirmerBtn
            // 
            this.confirmerBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmerBtn.Location = new System.Drawing.Point(170, 20);
            this.confirmerBtn.Margin = new System.Windows.Forms.Padding(170, 20, 170, 20);
            this.confirmerBtn.Name = "confirmerBtn";
            this.confirmerBtn.Size = new System.Drawing.Size(102, 20);
            this.confirmerBtn.TabIndex = 0;
            this.confirmerBtn.Text = "Confirmer";
            this.confirmerBtn.UseVisualStyleBackColor = true;
            this.confirmerBtn.Click += new System.EventHandler(this.confirmerBtn_Click);
            // 
            // dataGridView_photos
            // 
            this.dataGridView_photos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_photos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_photos.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_photos.Name = "dataGridView_photos";
            this.dataGridView_photos.Size = new System.Drawing.Size(885, 420);
            this.dataGridView_photos.TabIndex = 1;
            // 
            // tableLayoutPanel_TreeViewTags
            // 
            this.tableLayoutPanel_TreeViewTags.ColumnCount = 1;
            this.tableLayoutPanel_TreeViewTags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_TreeViewTags.Controls.Add(this.treeView_TagsModification, 0, 0);
            this.tableLayoutPanel_TreeViewTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TreeViewTags.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_TreeViewTags.Name = "tableLayoutPanel_TreeViewTags";
            this.tableLayoutPanel_TreeViewTags.RowCount = 1;
            this.tableLayoutPanel_TreeViewTags.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.09612F));
            this.tableLayoutPanel_TreeViewTags.Size = new System.Drawing.Size(321, 492);
            this.tableLayoutPanel_TreeViewTags.TabIndex = 1;
            // 
            // treeView_TagsModification
            // 
            this.treeView_TagsModification.ContextMenuStrip = this.contextMenuStrip_Tag;
            this.treeView_TagsModification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_TagsModification.Location = new System.Drawing.Point(3, 3);
            this.treeView_TagsModification.Name = "treeView_TagsModification";
            this.treeView_TagsModification.Size = new System.Drawing.Size(315, 486);
            this.treeView_TagsModification.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel_Ensemble);
            this.panel1.Controls.Add(this.tableLayoutPanel_Modification);
            this.panel1.Controls.Add(this.tableLayoutPanel_InformationsLogiciel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1224, 547);
            this.panel1.TabIndex = 7;
            // 
            // tableLayoutPanel_InformationsLogiciel
            // 
            this.tableLayoutPanel_InformationsLogiciel.ColumnCount = 4;
            this.tableLayoutPanel_InformationsLogiciel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.36034F));
            this.tableLayoutPanel_InformationsLogiciel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.63966F));
            this.tableLayoutPanel_InformationsLogiciel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            this.tableLayoutPanel_InformationsLogiciel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel_InformationsLogiciel.Controls.Add(this.progressBar, 0, 0);
            this.tableLayoutPanel_InformationsLogiciel.Controls.Add(this.label_info, 1, 0);
            this.tableLayoutPanel_InformationsLogiciel.Controls.Add(this.button_Go_Recherche, 3, 0);
            this.tableLayoutPanel_InformationsLogiciel.Controls.Add(this.textBox_recherche, 2, 0);
            this.tableLayoutPanel_InformationsLogiciel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel_InformationsLogiciel.Location = new System.Drawing.Point(0, 518);
            this.tableLayoutPanel_InformationsLogiciel.Name = "tableLayoutPanel_InformationsLogiciel";
            this.tableLayoutPanel_InformationsLogiciel.RowCount = 1;
            this.tableLayoutPanel_InformationsLogiciel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_InformationsLogiciel.Size = new System.Drawing.Size(1224, 29);
            this.tableLayoutPanel_InformationsLogiciel.TabIndex = 8;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(3, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(213, 16);
            this.progressBar.TabIndex = 8;
            this.progressBar.Visible = false;
            // 
            // button_Go_Recherche
            // 
            this.button_Go_Recherche.Location = new System.Drawing.Point(1176, 3);
            this.button_Go_Recherche.Name = "button_Go_Recherche";
            this.button_Go_Recherche.Size = new System.Drawing.Size(34, 23);
            this.button_Go_Recherche.TabIndex = 6;
            this.button_Go_Recherche.Text = "Go";
            this.button_Go_Recherche.UseVisualStyleBackColor = true;
            // 
            // textBox_recherche
            // 
            this.textBox_recherche.BackColor = System.Drawing.Color.LightGray;
            this.textBox_recherche.Location = new System.Drawing.Point(932, 3);
            this.textBox_recherche.Name = "textBox_recherche";
            this.textBox_recherche.Size = new System.Drawing.Size(238, 20);
            this.textBox_recherche.TabIndex = 7;
            this.textBox_recherche.Text = "Rechercher photo, tag, ...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1224, 571);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip_barreAccueil);
            this.MainMenuStrip = this.menuStrip_barreAccueil;
            this.Name = "Form1";
            this.Text = "Application";
            this.tableLayoutPanel_Ensemble.ResumeLayout(false);
            this.tableLayoutPanel_Accueil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listeImage)).EndInit();
            this.contextMenuStrip_Tag.ResumeLayout(false);
            this.menuStrip_barreAccueil.ResumeLayout(false);
            this.menuStrip_barreAccueil.PerformLayout();
            this.tableLayoutPanel_Modification.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel_BoutonsConfirmerAnnuler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_photos)).EndInit();
            this.tableLayoutPanel_TreeViewTags.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel_InformationsLogiciel.ResumeLayout(false);
            this.tableLayoutPanel_InformationsLogiciel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Ensemble;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Accueil;
        private System.Windows.Forms.TreeView treeView_tag;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.ToolStripMenuItem Fichier_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Ouvrir_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Dossier_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Fichier_ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Paramètres_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Edition_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModeDiaporama_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tag_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Modifier_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MiseÀJour_ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip_barreAccueil;
        private System.Windows.Forms.DataGridView dataGridView_listeImage;
        private System.Windows.Forms.RichTextBox richTextBox_infoImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Modification;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_BoutonsConfirmerAnnuler;
        private System.Windows.Forms.Button confirmerBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.DataGridView dataGridView_photos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TreeViewTags;
        private System.Windows.Forms.TreeView treeView_TagsModification;
        private System.Windows.Forms.ToolStripMenuItem VersionDuLogiciel_ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Tag;
        private System.Windows.Forms.ToolStripMenuItem Ajouter_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Rafraîchir_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Renommer_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Supprimer_ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_InformationsLogiciel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button button_Go_Recherche;
        private System.Windows.Forms.TextBox textBox_recherche;
    }
}

