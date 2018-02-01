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
            this.textBox_recherche = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_Ensemble = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Accueil = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox_infoImage = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel_Photos = new System.Windows.Forms.TableLayoutPanel();
            this.treeView_tag = new System.Windows.Forms.TreeView();
            this.label_info = new System.Windows.Forms.Label();
            this.button_Go_Recherche = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel_Modification = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Photo = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.confirmerBtn = new System.Windows.Forms.Button();
            this.dataGridView_Photos = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel_TreeView = new System.Windows.Forms.TableLayoutPanel();
            this.treeView_Tags = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_Parametres = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_EnregistrerParametres = new System.Windows.Forms.TableLayoutPanel();
            this.Button_ConfirmerParametres = new System.Windows.Forms.Button();
            this.tableLayoutPanel_AnnulerParametres = new System.Windows.Forms.TableLayoutPanel();
            this.Button_AnnulerParametres = new System.Windows.Forms.Button();
            this.tableLayoutPanel_InformationsLogiciel = new System.Windows.Forms.TableLayoutPanel();
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
            this.MiseAJour_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_barreAccueil = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip_Tags = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renommerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rafraîchirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel_Ensemble.SuspendLayout();
            this.tableLayoutPanel_Accueil.SuspendLayout();
            this.tableLayoutPanel_Modification.SuspendLayout();
            this.tableLayoutPanel_Photo.SuspendLayout();
            this.tableLayoutPanel_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Photos)).BeginInit();
            this.tableLayoutPanel_TreeView.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel_Parametres.SuspendLayout();
            this.tableLayoutPanel_EnregistrerParametres.SuspendLayout();
            this.tableLayoutPanel_AnnulerParametres.SuspendLayout();
            this.tableLayoutPanel_InformationsLogiciel.SuspendLayout();
            this.menuStrip_barreAccueil.SuspendLayout();
            this.contextMenuStrip_Tags.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_recherche
            // 
            this.textBox_recherche.BackColor = System.Drawing.Color.LightGray;
            this.textBox_recherche.Location = new System.Drawing.Point(965, 3);
            this.textBox_recherche.Name = "textBox_recherche";
            this.textBox_recherche.Size = new System.Drawing.Size(210, 20);
            this.textBox_recherche.TabIndex = 2;
            this.textBox_recherche.Text = "Rechercher photo, tag, ...";
            // 
            // tableLayoutPanel_Ensemble
            // 
            this.tableLayoutPanel_Ensemble.ColumnCount = 2;
            this.tableLayoutPanel_Ensemble.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Ensemble.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 994F));
            this.tableLayoutPanel_Ensemble.Controls.Add(this.tableLayoutPanel_Accueil, 5, 0);
            this.tableLayoutPanel_Ensemble.Controls.Add(this.treeView_tag, 0, 0);
            this.tableLayoutPanel_Ensemble.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Ensemble.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Ensemble.Name = "tableLayoutPanel_Ensemble";
            this.tableLayoutPanel_Ensemble.RowCount = 1;
            this.tableLayoutPanel_Ensemble.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Ensemble.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 518F));
            this.tableLayoutPanel_Ensemble.Size = new System.Drawing.Size(1224, 518);
            this.tableLayoutPanel_Ensemble.TabIndex = 3;
            // 
            // tableLayoutPanel_Accueil
            // 
            this.tableLayoutPanel_Accueil.ColumnCount = 1;
            this.tableLayoutPanel_Accueil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Accueil.Controls.Add(this.richTextBox_infoImage, 0, 1);
            this.tableLayoutPanel_Accueil.Controls.Add(this.tableLayoutPanel_Photos, 0, 0);
            this.tableLayoutPanel_Accueil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Accueil.Location = new System.Drawing.Point(233, 3);
            this.tableLayoutPanel_Accueil.Name = "tableLayoutPanel_Accueil";
            this.tableLayoutPanel_Accueil.RowCount = 2;
            this.tableLayoutPanel_Accueil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 410F));
            this.tableLayoutPanel_Accueil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel_Accueil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Accueil.Size = new System.Drawing.Size(988, 512);
            this.tableLayoutPanel_Accueil.TabIndex = 0;
            // 
            // richTextBox_infoImage
            // 
            this.richTextBox_infoImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_infoImage.Enabled = false;
            this.richTextBox_infoImage.Location = new System.Drawing.Point(3, 413);
            this.richTextBox_infoImage.Name = "richTextBox_infoImage";
            this.richTextBox_infoImage.Size = new System.Drawing.Size(982, 96);
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
            this.tableLayoutPanel_Photos.MaximumSize = new System.Drawing.Size(982, 404);
            this.tableLayoutPanel_Photos.Name = "tableLayoutPanel_Photos";
            this.tableLayoutPanel_Photos.RowCount = 3;
            this.tableLayoutPanel_Photos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel_Photos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel_Photos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel_Photos.Size = new System.Drawing.Size(982, 404);
            this.tableLayoutPanel_Photos.TabIndex = 2;
            // 
            // treeView_tag
            // 
            this.treeView_tag.ContextMenuStrip = this.contextMenuStrip_Tags;
            this.treeView_tag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_tag.Location = new System.Drawing.Point(3, 3);
            this.treeView_tag.Name = "treeView_tag";
            this.treeView_tag.Size = new System.Drawing.Size(224, 512);
            this.treeView_tag.TabIndex = 1;
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.BackColor = System.Drawing.Color.LightGray;
            this.label_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info.ForeColor = System.Drawing.Color.Green;
            this.label_info.Location = new System.Drawing.Point(234, 0);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(83, 13);
            this.label_info.TabIndex = 4;
            this.label_info.Text = "Label de MàJ";
            // 
            // button_Go_Recherche
            // 
            this.button_Go_Recherche.Location = new System.Drawing.Point(1181, 3);
            this.button_Go_Recherche.Name = "button_Go_Recherche";
            this.button_Go_Recherche.Size = new System.Drawing.Size(32, 20);
            this.button_Go_Recherche.TabIndex = 5;
            this.button_Go_Recherche.Text = "Go";
            this.button_Go_Recherche.UseVisualStyleBackColor = true;
            this.button_Go_Recherche.Click += new System.EventHandler(this.Button1_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(3, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(225, 16);
            this.progressBar.TabIndex = 6;
            this.progressBar.Visible = false;
            // 
            // tableLayoutPanel_Modification
            // 
            this.tableLayoutPanel_Modification.ColumnCount = 2;
            this.tableLayoutPanel_Modification.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.71569F));
            this.tableLayoutPanel_Modification.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.28432F));
            this.tableLayoutPanel_Modification.Controls.Add(this.tableLayoutPanel_Photo, 1, 0);
            this.tableLayoutPanel_Modification.Controls.Add(this.tableLayoutPanel_TreeView, 0, 0);
            this.tableLayoutPanel_Modification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Modification.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Modification.Name = "tableLayoutPanel_Modification";
            this.tableLayoutPanel_Modification.RowCount = 1;
            this.tableLayoutPanel_Modification.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Modification.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 518F));
            this.tableLayoutPanel_Modification.Size = new System.Drawing.Size(1224, 518);
            this.tableLayoutPanel_Modification.TabIndex = 2;
            // 
            // tableLayoutPanel_Photo
            // 
            this.tableLayoutPanel_Photo.ColumnCount = 1;
            this.tableLayoutPanel_Photo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Photo.Controls.Add(this.tableLayoutPanel_Buttons, 0, 1);
            this.tableLayoutPanel_Photo.Controls.Add(this.dataGridView_Photos, 0, 0);
            this.tableLayoutPanel_Photo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Photo.Location = new System.Drawing.Point(330, 3);
            this.tableLayoutPanel_Photo.Name = "tableLayoutPanel_Photo";
            this.tableLayoutPanel_Photo.RowCount = 2;
            this.tableLayoutPanel_Photo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.69131F));
            this.tableLayoutPanel_Photo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.30869F));
            this.tableLayoutPanel_Photo.Size = new System.Drawing.Size(891, 512);
            this.tableLayoutPanel_Photo.TabIndex = 0;
            // 
            // tableLayoutPanel_Buttons
            // 
            this.tableLayoutPanel_Buttons.ColumnCount = 2;
            this.tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Buttons.Controls.Add(this.cancelBtn, 1, 0);
            this.tableLayoutPanel_Buttons.Controls.Add(this.confirmerBtn, 0, 0);
            this.tableLayoutPanel_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Buttons.Location = new System.Drawing.Point(3, 446);
            this.tableLayoutPanel_Buttons.Name = "tableLayoutPanel_Buttons";
            this.tableLayoutPanel_Buttons.RowCount = 1;
            this.tableLayoutPanel_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Buttons.Size = new System.Drawing.Size(885, 63);
            this.tableLayoutPanel_Buttons.TabIndex = 0;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelBtn.Location = new System.Drawing.Point(612, 20);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(170, 20, 170, 20);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(103, 23);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Annuler";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // confirmerBtn
            // 
            this.confirmerBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmerBtn.Location = new System.Drawing.Point(170, 20);
            this.confirmerBtn.Margin = new System.Windows.Forms.Padding(170, 20, 170, 20);
            this.confirmerBtn.Name = "confirmerBtn";
            this.confirmerBtn.Size = new System.Drawing.Size(102, 23);
            this.confirmerBtn.TabIndex = 0;
            this.confirmerBtn.Text = "Confirmer";
            this.confirmerBtn.UseVisualStyleBackColor = true;
            this.confirmerBtn.Click += new System.EventHandler(this.ConfirmerBtn_Click);
            // 
            // dataGridView_Photos
            // 
            this.dataGridView_Photos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Photos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Photos.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_Photos.Name = "dataGridView_Photos";
            this.dataGridView_Photos.Size = new System.Drawing.Size(885, 437);
            this.dataGridView_Photos.TabIndex = 1;
            // 
            // tableLayoutPanel_TreeView
            // 
            this.tableLayoutPanel_TreeView.ColumnCount = 1;
            this.tableLayoutPanel_TreeView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_TreeView.Controls.Add(this.treeView_Tags, 0, 0);
            this.tableLayoutPanel_TreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TreeView.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_TreeView.Name = "tableLayoutPanel_TreeView";
            this.tableLayoutPanel_TreeView.RowCount = 1;
            this.tableLayoutPanel_TreeView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.09612F));
            this.tableLayoutPanel_TreeView.Size = new System.Drawing.Size(321, 512);
            this.tableLayoutPanel_TreeView.TabIndex = 1;
            // 
            // treeView_Tags
            // 
            this.treeView_Tags.ContextMenuStrip = this.contextMenuStrip_Tags;
            this.treeView_Tags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_Tags.Location = new System.Drawing.Point(3, 3);
            this.treeView_Tags.Name = "treeView_Tags";
            this.treeView_Tags.Size = new System.Drawing.Size(315, 506);
            this.treeView_Tags.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel_Ensemble);
            this.panel1.Controls.Add(this.tableLayoutPanel_Parametres);
            this.panel1.Controls.Add(this.tableLayoutPanel_Modification);
            this.panel1.Controls.Add(this.tableLayoutPanel_InformationsLogiciel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1224, 547);
            this.panel1.TabIndex = 7;
            // 
            // tableLayoutPanel_Parametres
            // 
            this.tableLayoutPanel_Parametres.ColumnCount = 2;
            this.tableLayoutPanel_Parametres.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Parametres.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Parametres.Controls.Add(this.tableLayoutPanel_EnregistrerParametres, 0, 4);
            this.tableLayoutPanel_Parametres.Controls.Add(this.tableLayoutPanel_AnnulerParametres, 1, 4);
            this.tableLayoutPanel_Parametres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Parametres.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Parametres.Name = "tableLayoutPanel_Parametres";
            this.tableLayoutPanel_Parametres.RowCount = 5;
            this.tableLayoutPanel_Parametres.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tableLayoutPanel_Parametres.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tableLayoutPanel_Parametres.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tableLayoutPanel_Parametres.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tableLayoutPanel_Parametres.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel_Parametres.Size = new System.Drawing.Size(1224, 518);
            this.tableLayoutPanel_Parametres.TabIndex = 2;
            // 
            // tableLayoutPanel_EnregistrerParametres
            // 
            this.tableLayoutPanel_EnregistrerParametres.ColumnCount = 4;
            this.tableLayoutPanel_EnregistrerParametres.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_EnregistrerParametres.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_EnregistrerParametres.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_EnregistrerParametres.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_EnregistrerParametres.Controls.Add(this.Button_ConfirmerParametres, 2, 0);
            this.tableLayoutPanel_EnregistrerParametres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_EnregistrerParametres.Location = new System.Drawing.Point(3, 471);
            this.tableLayoutPanel_EnregistrerParametres.Name = "tableLayoutPanel_EnregistrerParametres";
            this.tableLayoutPanel_EnregistrerParametres.RowCount = 1;
            this.tableLayoutPanel_EnregistrerParametres.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_EnregistrerParametres.Size = new System.Drawing.Size(606, 44);
            this.tableLayoutPanel_EnregistrerParametres.TabIndex = 2;
            // 
            // Button_ConfirmerParametres
            // 
            this.Button_ConfirmerParametres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_ConfirmerParametres.Location = new System.Drawing.Point(305, 3);
            this.Button_ConfirmerParametres.Name = "Button_ConfirmerParametres";
            this.Button_ConfirmerParametres.Size = new System.Drawing.Size(145, 38);
            this.Button_ConfirmerParametres.TabIndex = 0;
            this.Button_ConfirmerParametres.Text = "Enregistrer les paramètres";
            this.Button_ConfirmerParametres.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_AnnulerParametres
            // 
            this.tableLayoutPanel_AnnulerParametres.ColumnCount = 4;
            this.tableLayoutPanel_AnnulerParametres.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_AnnulerParametres.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_AnnulerParametres.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_AnnulerParametres.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_AnnulerParametres.Controls.Add(this.Button_AnnulerParametres, 1, 0);
            this.tableLayoutPanel_AnnulerParametres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_AnnulerParametres.Location = new System.Drawing.Point(615, 471);
            this.tableLayoutPanel_AnnulerParametres.Name = "tableLayoutPanel_AnnulerParametres";
            this.tableLayoutPanel_AnnulerParametres.RowCount = 1;
            this.tableLayoutPanel_AnnulerParametres.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_AnnulerParametres.Size = new System.Drawing.Size(606, 44);
            this.tableLayoutPanel_AnnulerParametres.TabIndex = 3;
            // 
            // Button_AnnulerParametres
            // 
            this.Button_AnnulerParametres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_AnnulerParametres.Location = new System.Drawing.Point(154, 3);
            this.Button_AnnulerParametres.Name = "Button_AnnulerParametres";
            this.Button_AnnulerParametres.Size = new System.Drawing.Size(145, 38);
            this.Button_AnnulerParametres.TabIndex = 1;
            this.Button_AnnulerParametres.Text = "Annuler";
            this.Button_AnnulerParametres.UseVisualStyleBackColor = true;
            this.Button_AnnulerParametres.Click += new System.EventHandler(this.AnnulerBtn_Click);
            // 
            // tableLayoutPanel_InformationsLogiciel
            // 
            this.tableLayoutPanel_InformationsLogiciel.ColumnCount = 4;
            this.tableLayoutPanel_InformationsLogiciel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.06639F));
            this.tableLayoutPanel_InformationsLogiciel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.93361F));
            this.tableLayoutPanel_InformationsLogiciel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 216F));
            this.tableLayoutPanel_InformationsLogiciel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel_InformationsLogiciel.Controls.Add(this.progressBar, 0, 0);
            this.tableLayoutPanel_InformationsLogiciel.Controls.Add(this.button_Go_Recherche, 3, 0);
            this.tableLayoutPanel_InformationsLogiciel.Controls.Add(this.label_info, 1, 0);
            this.tableLayoutPanel_InformationsLogiciel.Controls.Add(this.textBox_recherche, 2, 0);
            this.tableLayoutPanel_InformationsLogiciel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel_InformationsLogiciel.Location = new System.Drawing.Point(0, 518);
            this.tableLayoutPanel_InformationsLogiciel.Name = "tableLayoutPanel_InformationsLogiciel";
            this.tableLayoutPanel_InformationsLogiciel.RowCount = 1;
            this.tableLayoutPanel_InformationsLogiciel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_InformationsLogiciel.Size = new System.Drawing.Size(1224, 29);
            this.tableLayoutPanel_InformationsLogiciel.TabIndex = 8;
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
            this.Ouvrir_ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
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
            // Paramètres_ToolStripMenuItem
            // 
            this.Paramètres_ToolStripMenuItem.Name = "Paramètres_ToolStripMenuItem";
            this.Paramètres_ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.Paramètres_ToolStripMenuItem.Text = "Paramètres";
            this.Paramètres_ToolStripMenuItem.Click += new System.EventHandler(this.ParamètresToolStripMenuItem_Click);
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
            this.VersionDuLogiciel_ToolStripMenuItem.Click += new System.EventHandler(this.VersionDuLogicielToolStripMenuItem_Click);
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
            this.menuStrip_barreAccueil.Size = new System.Drawing.Size(1224, 24);
            this.menuStrip_barreAccueil.TabIndex = 1;
            this.menuStrip_barreAccueil.Text = "menuStrip1";
            // 
            // contextMenuStrip_Tags
            // 
            this.contextMenuStrip_Tags.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.renommerToolStripMenuItem,
            this.rafraîchirToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip_Tags.Name = "contextMenuStrip_Tags";
            this.contextMenuStrip_Tags.Size = new System.Drawing.Size(153, 114);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // renommerToolStripMenuItem
            // 
            this.renommerToolStripMenuItem.Name = "renommerToolStripMenuItem";
            this.renommerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.renommerToolStripMenuItem.Text = "Renommer";
            // 
            // rafraîchirToolStripMenuItem
            // 
            this.rafraîchirToolStripMenuItem.Name = "rafraîchirToolStripMenuItem";
            this.rafraîchirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rafraîchirToolStripMenuItem.Text = "Rafraîchir";
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
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
            this.tableLayoutPanel_Modification.ResumeLayout(false);
            this.tableLayoutPanel_Photo.ResumeLayout(false);
            this.tableLayoutPanel_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Photos)).EndInit();
            this.tableLayoutPanel_TreeView.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel_Parametres.ResumeLayout(false);
            this.tableLayoutPanel_EnregistrerParametres.ResumeLayout(false);
            this.tableLayoutPanel_AnnulerParametres.ResumeLayout(false);
            this.tableLayoutPanel_InformationsLogiciel.ResumeLayout(false);
            this.tableLayoutPanel_InformationsLogiciel.PerformLayout();
            this.menuStrip_barreAccueil.ResumeLayout(false);
            this.menuStrip_barreAccueil.PerformLayout();
            this.contextMenuStrip_Tags.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_recherche;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Ensemble;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Accueil;
        private System.Windows.Forms.TreeView treeView_tag;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Button button_Go_Recherche;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.RichTextBox richTextBox_infoImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Modification;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Photo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Buttons;
        private System.Windows.Forms.Button confirmerBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.DataGridView dataGridView_Photos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TreeView;
        private System.Windows.Forms.TreeView treeView_Tags;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Parametres;
        private System.Windows.Forms.Button Button_ConfirmerParametres;
        private System.Windows.Forms.Button Button_AnnulerParametres;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_EnregistrerParametres;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_AnnulerParametres;
        private System.Windows.Forms.ToolStripMenuItem Fichier_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Ouvrir_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Dossier_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Fichier_ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Paramètres_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Edition_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModeDiaporama_ToolStripMenuItem;
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
    }
}

