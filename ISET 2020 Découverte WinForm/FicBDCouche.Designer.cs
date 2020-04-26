namespace ISET_2020_Découverte_WinForm
{
    partial class EcranBDCouche
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
            this.dgvPersonne = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnEditer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPre = new System.Windows.Forms.Label();
            this.tbPre = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lblNai = new System.Windows.Forms.Label();
            this.dtpNai = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Afficher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonne)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonne
            // 
            this.dgvPersonne.AllowUserToAddRows = false;
            this.dgvPersonne.AllowUserToDeleteRows = false;
            this.dgvPersonne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Afficher});
            this.dgvPersonne.Location = new System.Drawing.Point(12, 12);
            this.dgvPersonne.Name = "dgvPersonne";
            this.dgvPersonne.ReadOnly = true;
            this.dgvPersonne.RowHeadersVisible = false;
            this.dgvPersonne.RowTemplate.Height = 28;
            this.dgvPersonne.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonne.Size = new System.Drawing.Size(419, 223);
            this.dgvPersonne.TabIndex = 0;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(21, 241);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(95, 34);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnEditer
            // 
            this.btnEditer.Location = new System.Drawing.Point(181, 241);
            this.btnEditer.Name = "btnEditer";
            this.btnEditer.Size = new System.Drawing.Size(95, 34);
            this.btnEditer.TabIndex = 2;
            this.btnEditer.Text = "Editer";
            this.btnEditer.UseVisualStyleBackColor = true;
            this.btnEditer.Click += new System.EventHandler(this.btnEditer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(336, 241);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(95, 34);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(21, 303);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(410, 26);
            this.tbID.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(17, 280);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(80, 20);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "Identifiant";
            // 
            // lblPre
            // 
            this.lblPre.AutoSize = true;
            this.lblPre.Location = new System.Drawing.Point(17, 332);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(64, 20);
            this.lblPre.TabIndex = 7;
            this.lblPre.Text = "Prénom";
            // 
            // tbPre
            // 
            this.tbPre.Location = new System.Drawing.Point(21, 355);
            this.tbPre.Name = "tbPre";
            this.tbPre.Size = new System.Drawing.Size(410, 26);
            this.tbPre.TabIndex = 6;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(17, 384);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 20);
            this.lblNom.TabIndex = 9;
            this.lblNom.Text = "Nom";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(21, 407);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(410, 26);
            this.tbNom.TabIndex = 8;
            // 
            // lblNai
            // 
            this.lblNai.AutoSize = true;
            this.lblNai.Location = new System.Drawing.Point(17, 436);
            this.lblNai.Name = "lblNai";
            this.lblNai.Size = new System.Drawing.Size(142, 20);
            this.lblNai.TabIndex = 10;
            this.lblNai.Text = "Date de naissance";
            // 
            // dtpNai
            // 
            this.dtpNai.Location = new System.Drawing.Point(21, 459);
            this.dtpNai.Name = "dtpNai";
            this.dtpNai.Size = new System.Drawing.Size(410, 26);
            this.dtpNai.TabIndex = 11;
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(22, 491);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(99, 30);
            this.btnConfirmer.TabIndex = 12;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(336, 491);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(99, 30);
            this.btnAnnuler.TabIndex = 13;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Afficher
            // 
            this.Afficher.DataPropertyName = "Afficher";
            this.Afficher.HeaderText = "Prénom et nom";
            this.Afficher.Name = "Afficher";
            this.Afficher.ReadOnly = true;
            this.Afficher.Width = 300;
            // 
            // EcranBDCouche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 601);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.dtpNai);
            this.Controls.Add(this.lblNai);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lblPre);
            this.Controls.Add(this.tbPre);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnEditer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgvPersonne);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranBDCouche";
            this.Text = "Gestion BD par couches";
            this.Load += new System.EventHandler(this.EcranBDCouche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonne;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnEditer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPre;
        private System.Windows.Forms.TextBox tbPre;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lblNai;
        private System.Windows.Forms.DateTimePicker dtpNai;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Afficher;
    }
}