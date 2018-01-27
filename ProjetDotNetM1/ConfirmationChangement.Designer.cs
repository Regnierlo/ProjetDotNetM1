namespace ProjetDotNetM1
{
    partial class ConfirmationChangement
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
            this.enregistrerBtn = new System.Windows.Forms.Button();
            this.nepasenregistrerBtn = new System.Windows.Forms.Button();
            this.annulerBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 73);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.67816F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.32184F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(337, 73);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.enregistrerBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.nepasenregistrerBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.annulerBtn, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 34);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(331, 36);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // enregistrerBtn
            // 
            this.enregistrerBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enregistrerBtn.Location = new System.Drawing.Point(3, 3);
            this.enregistrerBtn.Name = "enregistrerBtn";
            this.enregistrerBtn.Size = new System.Drawing.Size(104, 30);
            this.enregistrerBtn.TabIndex = 0;
            this.enregistrerBtn.Text = "Enregistrer";
            this.enregistrerBtn.UseVisualStyleBackColor = true;
            // 
            // nepasenregistrerBtn
            // 
            this.nepasenregistrerBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nepasenregistrerBtn.Location = new System.Drawing.Point(113, 3);
            this.nepasenregistrerBtn.Name = "nepasenregistrerBtn";
            this.nepasenregistrerBtn.Size = new System.Drawing.Size(104, 30);
            this.nepasenregistrerBtn.TabIndex = 1;
            this.nepasenregistrerBtn.Text = "Ne pas enregistrer";
            this.nepasenregistrerBtn.UseVisualStyleBackColor = true;
            this.nepasenregistrerBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // annulerBtn
            // 
            this.annulerBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.annulerBtn.Location = new System.Drawing.Point(223, 3);
            this.annulerBtn.Name = "annulerBtn";
            this.annulerBtn.Size = new System.Drawing.Size(105, 30);
            this.annulerBtn.TabIndex = 2;
            this.annulerBtn.Text = "Annuler";
            this.annulerBtn.UseVisualStyleBackColor = true;
            this.annulerBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voulez-vous quitter sans enregistrer vos modifications ? ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfirmationChangement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 73);
            this.Controls.Add(this.panel1);
            this.Name = "ConfirmationChangement";
            this.Text = "ConfirmationChangement";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button enregistrerBtn;
        private System.Windows.Forms.Button nepasenregistrerBtn;
        private System.Windows.Forms.Button annulerBtn;
        private System.Windows.Forms.Label label1;
    }
}