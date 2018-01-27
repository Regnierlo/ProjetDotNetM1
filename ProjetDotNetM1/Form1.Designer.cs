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
            this.textBox_recherche = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1_Ensemble = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2_Accueil = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_listeImage = new System.Windows.Forms.DataGridView();
            this.richTextBox_infoImage = new System.Windows.Forms.RichTextBox();
            this.treeView_tag = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dossierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeDiaporamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseÀJourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_barreAccueil = new System.Windows.Forms.MenuStrip();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel3_Modification = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.confirmerBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.versionDuLogicielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1_Ensemble.SuspendLayout();
            this.tableLayoutPanel2_Accueil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listeImage)).BeginInit();
            this.menuStrip_barreAccueil.SuspendLayout();
            this.tableLayoutPanel3_Modification.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_recherche
            // 
            this.textBox_recherche.BackColor = System.Drawing.Color.LightGray;
            this.textBox_recherche.Location = new System.Drawing.Point(895, 1);
            this.textBox_recherche.Name = "textBox_recherche";
            this.textBox_recherche.Size = new System.Drawing.Size(212, 20);
            this.textBox_recherche.TabIndex = 2;
            this.textBox_recherche.Text = "Rechercher photo, tag, ...";
            // 
            // tableLayoutPanel1_Ensemble
            // 
            this.tableLayoutPanel1_Ensemble.ColumnCount = 2;
            this.tableLayoutPanel1_Ensemble.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1_Ensemble.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 994F));
            this.tableLayoutPanel1_Ensemble.Controls.Add(this.tableLayoutPanel2_Accueil, 5, 0);
            this.tableLayoutPanel1_Ensemble.Controls.Add(this.treeView_tag, 0, 0);
            this.tableLayoutPanel1_Ensemble.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1_Ensemble.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1_Ensemble.Name = "tableLayoutPanel1_Ensemble";
            this.tableLayoutPanel1_Ensemble.RowCount = 1;
            this.tableLayoutPanel1_Ensemble.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1_Ensemble.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 547F));
            this.tableLayoutPanel1_Ensemble.Size = new System.Drawing.Size(1224, 547);
            this.tableLayoutPanel1_Ensemble.TabIndex = 3;
            // 
            // tableLayoutPanel2_Accueil
            // 
            this.tableLayoutPanel2_Accueil.ColumnCount = 1;
            this.tableLayoutPanel2_Accueil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2_Accueil.Controls.Add(this.dataGridView_listeImage, 0, 0);
            this.tableLayoutPanel2_Accueil.Controls.Add(this.richTextBox_infoImage, 0, 1);
            this.tableLayoutPanel2_Accueil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2_Accueil.Location = new System.Drawing.Point(233, 3);
            this.tableLayoutPanel2_Accueil.Name = "tableLayoutPanel2_Accueil";
            this.tableLayoutPanel2_Accueil.RowCount = 2;
            this.tableLayoutPanel2_Accueil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 410F));
            this.tableLayoutPanel2_Accueil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2_Accueil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel2_Accueil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2_Accueil.Size = new System.Drawing.Size(988, 541);
            this.tableLayoutPanel2_Accueil.TabIndex = 0;
            // 
            // dataGridView_listeImage
            // 
            this.dataGridView_listeImage.AllowUserToDeleteRows = false;
            this.dataGridView_listeImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listeImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_listeImage.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_listeImage.Name = "dataGridView_listeImage";
            this.dataGridView_listeImage.ReadOnly = true;
            this.dataGridView_listeImage.Size = new System.Drawing.Size(982, 404);
            this.dataGridView_listeImage.TabIndex = 0;
            // 
            // richTextBox_infoImage
            // 
            this.richTextBox_infoImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_infoImage.Enabled = false;
            this.richTextBox_infoImage.Location = new System.Drawing.Point(3, 413);
            this.richTextBox_infoImage.Name = "richTextBox_infoImage";
            this.richTextBox_infoImage.Size = new System.Drawing.Size(982, 125);
            this.richTextBox_infoImage.TabIndex = 1;
            this.richTextBox_infoImage.Text = "Information de l\'image sélectionnée";
            // 
            // treeView_tag
            // 
            this.treeView_tag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_tag.Location = new System.Drawing.Point(3, 3);
            this.treeView_tag.Name = "treeView_tag";
            this.treeView_tag.Size = new System.Drawing.Size(224, 541);
            this.treeView_tag.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(806, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Label de MàJ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1113, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ouvrirToolStripMenuItem.Text = "Importer";
            // 
            // dossierToolStripMenuItem
            // 
            this.dossierToolStripMenuItem.Name = "dossierToolStripMenuItem";
            this.dossierToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dossierToolStripMenuItem.Text = "Dossier";
            this.dossierToolStripMenuItem.Click += new System.EventHandler(this.dossierToolStripMenuItem_Click);
            // 
            // fichierToolStripMenuItem1
            // 
            this.fichierToolStripMenuItem1.Name = "fichierToolStripMenuItem1";
            this.fichierToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.fichierToolStripMenuItem1.Text = "Fichier";
            this.fichierToolStripMenuItem1.Click += new System.EventHandler(this.fichierToolStripMenuItem1_Click);
            // 
            // paramètresToolStripMenuItem
            // 
            this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
            this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.modeDiaporamaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.modeDiaporamaToolStripMenuItem.Text = "Mode diaporama";
            // 
            // tagToolStripMenuItem
            // 
            this.tagToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem});
            this.tagToolStripMenuItem.Name = "tagToolStripMenuItem";
            this.tagToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.tagToolStripMenuItem.Text = "Tag";
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(245, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(555, 16);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Visible = false;
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
            this.tableLayoutPanel3_Modification.RowCount = 1;
            this.tableLayoutPanel3_Modification.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(891, 541);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 471);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(885, 67);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelBtn.Location = new System.Drawing.Point(612, 20);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(170, 20, 170, 20);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(103, 27);
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
            this.confirmerBtn.Size = new System.Drawing.Size(102, 27);
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
            this.dataGridView1.Size = new System.Drawing.Size(885, 462);
            this.dataGridView1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.treeView1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.09612F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(321, 541);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(315, 535);
            this.treeView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1_Ensemble);
            this.panel1.Controls.Add(this.tableLayoutPanel3_Modification);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1224, 547);
            this.panel1.TabIndex = 7;
            // 
            // versionDuLogicielToolStripMenuItem
            // 
            this.versionDuLogicielToolStripMenuItem.Name = "versionDuLogicielToolStripMenuItem";
            this.versionDuLogicielToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.versionDuLogicielToolStripMenuItem.Text = "A propos";
            this.versionDuLogicielToolStripMenuItem.Click += new System.EventHandler(this.versionDuLogicielToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1224, 571);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_recherche);
            this.Controls.Add(this.menuStrip_barreAccueil);
            this.MainMenuStrip = this.menuStrip_barreAccueil;
            this.Name = "Form1";
            this.Text = "Application";
            this.tableLayoutPanel1_Ensemble.ResumeLayout(false);
            this.tableLayoutPanel2_Accueil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listeImage)).EndInit();
            this.menuStrip_barreAccueil.ResumeLayout(false);
            this.menuStrip_barreAccueil.PerformLayout();
            this.tableLayoutPanel3_Modification.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_recherche;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1_Ensemble;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2_Accueil;
        private System.Windows.Forms.TreeView treeView_tag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.ProgressBar progressBar1;
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
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem versionDuLogicielToolStripMenuItem;
    }
}

