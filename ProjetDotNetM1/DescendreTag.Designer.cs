namespace ProjetDotNetM1
{
    partial class DescendreTag
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_Sauvegarder = new System.Windows.Forms.Button();
            this.button_Annuler = new System.Windows.Forms.Button();
            this.treeView_SelectFils = new System.Windows.Forms.TreeView();
            this.label_consignes = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label_consignes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 461);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.treeView_SelectFils, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.61607F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.38393F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 448);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button_Sauvegarder, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_Annuler, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 400);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(288, 45);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // button_Sauvegarder
            // 
            this.button_Sauvegarder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Sauvegarder.Location = new System.Drawing.Point(3, 3);
            this.button_Sauvegarder.Name = "button_Sauvegarder";
            this.button_Sauvegarder.Size = new System.Drawing.Size(138, 39);
            this.button_Sauvegarder.TabIndex = 0;
            this.button_Sauvegarder.Text = "Sauvegarder";
            this.button_Sauvegarder.UseVisualStyleBackColor = true;
            this.button_Sauvegarder.Click += new System.EventHandler(this.button_Sauvegarder_Click);
            // 
            // button_Annuler
            // 
            this.button_Annuler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Annuler.Location = new System.Drawing.Point(147, 3);
            this.button_Annuler.Name = "button_Annuler";
            this.button_Annuler.Size = new System.Drawing.Size(138, 39);
            this.button_Annuler.TabIndex = 1;
            this.button_Annuler.Text = "Annuler";
            this.button_Annuler.UseVisualStyleBackColor = true;
            this.button_Annuler.Click += new System.EventHandler(this.button_Annuler_Click);
            // 
            // treeView_SelectFils
            // 
            this.treeView_SelectFils.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_SelectFils.Location = new System.Drawing.Point(3, 3);
            this.treeView_SelectFils.Name = "treeView_SelectFils";
            this.treeView_SelectFils.Size = new System.Drawing.Size(288, 391);
            this.treeView_SelectFils.TabIndex = 1;
            // 
            // label_consignes
            // 
            this.label_consignes.AutoSize = true;
            this.label_consignes.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_consignes.Location = new System.Drawing.Point(0, 0);
            this.label_consignes.Name = "label_consignes";
            this.label_consignes.Size = new System.Drawing.Size(235, 13);
            this.label_consignes.TabIndex = 1;
            this.label_consignes.Text = "Sur quel fils voulez-vous faire descendre le tag ?";
            // 
            // DescendreTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 461);
            this.Controls.Add(this.panel1);
            this.Name = "DescendreTag";
            this.Text = "DescendreTag";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_Sauvegarder;
        private System.Windows.Forms.Button button_Annuler;
        private System.Windows.Forms.TreeView treeView_SelectFils;
        private System.Windows.Forms.Label label_consignes;
    }
}