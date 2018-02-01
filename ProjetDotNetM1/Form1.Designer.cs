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
            this.tableLayoutPanel1_Ensemble = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2_Accueil = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_listeImage = new System.Windows.Forms.DataGridView();
            this.richTextBox_infoImage = new System.Windows.Forms.RichTextBox();
            this.treeView_tag = new System.Windows.Forms.TreeView();
            this.contextMenuStrip_Tag = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem_Ajouter = new System.Windows.Forms.ToolStripMenuItem();
            this.rafraîchirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_info = new System.Windows.Forms.Label();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dossierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeDiaporamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionDuLogicielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseÀJourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_barreAccueil = new System.Windows.Forms.MenuStrip();
            this.tableLayoutPanel3_Modification = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.confirmerBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView_Tags = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.renommerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_recherche = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1_Ensemble.SuspendLayout();
            this.tableLayoutPanel2_Accueil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listeImage)).BeginInit();
            this.contextMenuStrip_Tag.SuspendLayout();
            this.menuStrip_barreAccueil.SuspendLayout();
            this.tableLayoutPanel3_Modification.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1_Ensemble
            // 
            this.tableLayoutPanel1_Ensemble.ColumnCount = 2;
            this.tableLayoutPanel1_Ensemble.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1_Ensemble.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1005F));
            this.tableLayoutPanel1_Ensemble.Controls.Add(this.tableLayoutPanel2_Accueil, 5, 0);
            this.tableLayoutPanel1_Ensemble.Controls.Add(this.treeView_tag, 0, 0);
            this.tableLayoutPanel1_Ensemble.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1_Ensemble.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1_Ensemble.Name = "tableLayoutPanel1_Ensemble";
            this.tableLayoutPanel1_Ensemble.RowCount = 2;
            this.tableLayoutPanel1_Ensemble.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1_Ensemble.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1_Ensemble.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 547F));
            this.tableLayoutPanel1_Ensemble.Size = new System.Drawing.Size(1224, 547);
            this.tableLayoutPanel1_Ensemble.TabIndex = 3;
            // 
            // tableLayoutPanel2_Accueil
            // 
            this.tableLayoutPanel2_Accueil.ColumnCount = 1;
            this.tableLayoutPanel2_Accueil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2_Accueil.Controls.Add(this.dataGridView_listeImage, 3, 0);
            this.tableLayoutPanel2_Accueil.Controls.Add(this.richTextBox_infoImage, 0, 1);
            this.tableLayoutPanel2_Accueil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2_Accueil.Location = new System.Drawing.Point(222, 3);
            this.tableLayoutPanel2_Accueil.Name = "tableLayoutPanel2_Accueil";
            this.tableLayoutPanel2_Accueil.RowCount = 2;
            this.tableLayoutPanel2_Accueil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 410F));
            this.tableLayoutPanel2_Accueil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2_Accueil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel2_Accueil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2_Accueil.Size = new System.Drawing.Size(999, 512);
            this.tableLayoutPanel2_Accueil.TabIndex = 0;
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
            this.richTextBox_infoImage.Size = new System.Drawing.Size(993, 96);
            this.richTextBox_infoImage.TabIndex = 1;
            this.richTextBox_infoImage.Text = "Information de l\'image sélectionnée";
            // 
            // treeView_tag
            // 
            this.treeView_tag.ContextMenuStrip = this.contextMenuStrip_Tag;
            this.treeView_tag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_tag.Location = new System.Drawing.Point(3, 3);
            this.treeView_tag.Name = "treeView_tag";
            this.treeView_tag.Size = new System.Drawing.Size(213, 512);
            this.treeView_tag.TabIndex = 1;
            // 
            // contextMenuStrip_Tag
            // 
            this.contextMenuStrip_Tag.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem_Ajouter,
            this.renommerToolStripMenuItem,
            this.rafraîchirToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip_Tag.Name = "contextMenuStrip_Tag";
            this.contextMenuStrip_Tag.Size = new System.Drawing.Size(134, 92);
            // 
            // ajouterToolStripMenuItem_Ajouter
            // 
            this.ajouterToolStripMenuItem_Ajouter.Name = "ajouterToolStripMenuItem_Ajouter";
            this.ajouterToolStripMenuItem_Ajouter.Size = new System.Drawing.Size(133, 22);
            this.ajouterToolStripMenuItem_Ajouter.Text = "Ajouter";
            this.ajouterToolStripMenuItem_Ajouter.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Ajouter_Click);
            // 
            // rafraîchirToolStripMenuItem
            // 
            this.rafraîchirToolStripMenuItem.Name = "rafraîchirToolStripMenuItem";
            this.rafraîchirToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.rafraîchirToolStripMenuItem.Text = "Rafraîchir";
            this.rafraîchirToolStripMenuItem.Click += new System.EventHandler(this.rafraîchirToolStripMenuItem_Click);
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
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.paramètresToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.ouvrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dossierToolStripMenuItem,
            this.fichierToolStripMenuItem1});
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.ouvrirToolStripMenuItem.Text = "Importer";
            // 
            // dossierToolStripMenuItem
            // 
            this.dossierToolStripMenuItem.Name = "dossierToolStripMenuItem";
            this.dossierToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.dossierToolStripMenuItem.Text = "Dossier";
            this.dossierToolStripMenuItem.Click += new System.EventHandler(this.dossierToolStripMenuItem_Click);
            // 
            // fichierToolStripMenuItem1
            // 
            this.fichierToolStripMenuItem1.Name = "fichierToolStripMenuItem1";
            this.fichierToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.fichierToolStripMenuItem1.Text = "Fichier";
            this.fichierToolStripMenuItem1.Click += new System.EventHandler(this.fichierToolStripMenuItem1_Click);
            // 
            // paramètresToolStripMenuItem
            // 
            this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
            this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.paramètresToolStripMenuItem.Text = "Paramètres";
            this.paramètresToolStripMenuItem.Click += new System.EventHandler(this.paramètresToolStripMenuItem_Click);
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeDiaporamaToolStripMenuItem,
            this.versionDuLogicielToolStripMenuItem});
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // modeDiaporamaToolStripMenuItem
            // 
            this.modeDiaporamaToolStripMenuItem.Name = "modeDiaporamaToolStripMenuItem";
            this.modeDiaporamaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.modeDiaporamaToolStripMenuItem.Text = "Mode diaporama";
            // 
            // versionDuLogicielToolStripMenuItem
            // 
            this.versionDuLogicielToolStripMenuItem.Name = "versionDuLogicielToolStripMenuItem";
            this.versionDuLogicielToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.versionDuLogicielToolStripMenuItem.Text = "A propos";
            this.versionDuLogicielToolStripMenuItem.Click += new System.EventHandler(this.versionDuLogicielToolStripMenuItem_Click);
            // 
            // tagToolStripMenuItem
            // 
            this.tagToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem});
            this.tagToolStripMenuItem.Name = "tagToolStripMenuItem";
            this.tagToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.tagToolStripMenuItem.Text = "Tag";
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // miseÀJourToolStripMenuItem
            // 
            this.miseÀJourToolStripMenuItem.Name = "miseÀJourToolStripMenuItem";
            this.miseÀJourToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.miseÀJourToolStripMenuItem.Text = "Mise à jour";
            this.miseÀJourToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip_barreAccueil
            // 
            this.menuStrip_barreAccueil.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip_barreAccueil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.tagToolStripMenuItem,
            this.miseÀJourToolStripMenuItem});
            this.menuStrip_barreAccueil.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_barreAccueil.Name = "menuStrip_barreAccueil";
            this.menuStrip_barreAccueil.Size = new System.Drawing.Size(1224, 24);
            this.menuStrip_barreAccueil.TabIndex = 1;
            this.menuStrip_barreAccueil.Text = "menuStrip1";
            // 
            // tableLayoutPanel3_Modification
            // 
            this.tableLayoutPanel3_Modification.ColumnCount = 2;
            this.tableLayoutPanel3_Modification.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.71569F));
            this.tableLayoutPanel3_Modification.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.28432F));
            this.tableLayoutPanel3_Modification.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel3_Modification.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel3_Modification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3_Modification.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3_Modification.Name = "tableLayoutPanel3_Modification";
            this.tableLayoutPanel3_Modification.RowCount = 2;
            this.tableLayoutPanel3_Modification.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3_Modification.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3_Modification.Size = new System.Drawing.Size(1224, 547);
            this.tableLayoutPanel3_Modification.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(330, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.69131F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.30869F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(891, 521);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cancelBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.confirmerBtn, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 454);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(885, 64);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelBtn.Location = new System.Drawing.Point(612, 20);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(170, 20, 170, 20);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(103, 24);
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
            this.confirmerBtn.Size = new System.Drawing.Size(102, 24);
            this.confirmerBtn.TabIndex = 0;
            this.confirmerBtn.Text = "Confirmer";
            this.confirmerBtn.UseVisualStyleBackColor = true;
            this.confirmerBtn.Click += new System.EventHandler(this.confirmerBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(885, 445);
            this.dataGridView1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.treeView_Tags, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.09612F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(321, 521);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // treeView_Tags
            // 
            this.treeView_Tags.ContextMenuStrip = this.contextMenuStrip_Tag;
            this.treeView_Tags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_Tags.Location = new System.Drawing.Point(3, 3);
            this.treeView_Tags.Name = "treeView_Tags";
            this.treeView_Tags.Size = new System.Drawing.Size(315, 515);
            this.treeView_Tags.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel5);
            this.panel1.Controls.Add(this.tableLayoutPanel1_Ensemble);
            this.panel1.Controls.Add(this.tableLayoutPanel3_Modification);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1224, 547);
            this.panel1.TabIndex = 7;
            // 
            // renommerToolStripMenuItem
            // 
            this.renommerToolStripMenuItem.Name = "renommerToolStripMenuItem";
            this.renommerToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.renommerToolStripMenuItem.Text = "Renommer";
            this.renommerToolStripMenuItem.Click += new System.EventHandler(this.renommerToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.36034F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.63966F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel5.Controls.Add(this.progressBar1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label_info, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.button1, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBox_recherche, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 518);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1224, 29);
            this.tableLayoutPanel5.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1177, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox_recherche
            // 
            this.textBox_recherche.BackColor = System.Drawing.Color.LightGray;
            this.textBox_recherche.Location = new System.Drawing.Point(933, 3);
            this.textBox_recherche.Name = "textBox_recherche";
            this.textBox_recherche.Size = new System.Drawing.Size(238, 20);
            this.textBox_recherche.TabIndex = 7;
            this.textBox_recherche.Text = "Rechercher photo, tag, ...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(213, 16);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Visible = false;
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
            this.tableLayoutPanel1_Ensemble.ResumeLayout(false);
            this.tableLayoutPanel2_Accueil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listeImage)).EndInit();
            this.contextMenuStrip_Tag.ResumeLayout(false);
            this.menuStrip_barreAccueil.ResumeLayout(false);
            this.menuStrip_barreAccueil.PerformLayout();
            this.tableLayoutPanel3_Modification.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1_Ensemble;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2_Accueil;
        private System.Windows.Forms.TreeView treeView_tag;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dossierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeDiaporamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseÀJourToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip_barreAccueil;
        private System.Windows.Forms.DataGridView dataGridView_listeImage;
        private System.Windows.Forms.RichTextBox richTextBox_infoImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3_Modification;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button confirmerBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TreeView treeView_Tags;
        private System.Windows.Forms.ToolStripMenuItem versionDuLogicielToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Tag;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem_Ajouter;
        private System.Windows.Forms.ToolStripMenuItem rafraîchirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renommerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_recherche;
    }
}

