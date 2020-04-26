namespace ISET_2020_Découverte_WinForm
{
    partial class EcranListe
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
            this.lbFichier = new System.Windows.Forms.Label();
            this.lblQualité = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lbPersonne = new System.Windows.Forms.ListBox();
            this.btnOuvrir = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.cbQualité = new System.Windows.Forms.ComboBox();
            this.pDetail = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnAnuller = new System.Windows.Forms.Button();
            this.pDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFichier
            // 
            this.lbFichier.AutoSize = true;
            this.lbFichier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFichier.Location = new System.Drawing.Point(34, 19);
            this.lbFichier.Name = "lbFichier";
            this.lbFichier.Size = new System.Drawing.Size(211, 32);
            this.lbFichier.TabIndex = 0;
            this.lbFichier.Text = "Nom du fichier";
            // 
            // lblQualité
            // 
            this.lblQualité.AutoSize = true;
            this.lblQualité.Location = new System.Drawing.Point(12, 15);
            this.lblQualité.Name = "lblQualité";
            this.lblQualité.Size = new System.Drawing.Size(59, 20);
            this.lblQualité.TabIndex = 0;
            this.lblQualité.Text = "Qualité";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 118);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 20);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom";
            // 
            // lbPersonne
            // 
            this.lbPersonne.FormattingEnabled = true;
            this.lbPersonne.ItemHeight = 20;
            this.lbPersonne.Location = new System.Drawing.Point(25, 54);
            this.lbPersonne.Name = "lbPersonne";
            this.lbPersonne.Size = new System.Drawing.Size(469, 104);
            this.lbPersonne.TabIndex = 1;
            this.lbPersonne.DoubleClick += new System.EventHandler(this.lbPersonne_DoubleClick);
            // 
            // btnOuvrir
            // 
            this.btnOuvrir.Location = new System.Drawing.Point(25, 175);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(120, 36);
            this.btnOuvrir.TabIndex = 2;
            this.btnOuvrir.Text = "Ouvrir";
            this.btnOuvrir.UseVisualStyleBackColor = true;
            this.btnOuvrir.Click += new System.EventHandler(this.btnOuvrir_Click);
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(16, 158);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(269, 26);
            this.tbNom.TabIndex = 3;
            // 
            // cbQualité
            // 
            this.cbQualité.FormattingEnabled = true;
            this.cbQualité.Items.AddRange(new object[] {
            "Madame",
            "Mademoiselle",
            "Monsieur",
            "Mondamoiseau",
            "Indéfini",
            "Autres"});
            this.cbQualité.Location = new System.Drawing.Point(16, 61);
            this.cbQualité.Name = "cbQualité";
            this.cbQualité.Size = new System.Drawing.Size(269, 28);
            this.cbQualité.TabIndex = 1;
            // 
            // pDetail
            // 
            this.pDetail.Controls.Add(this.btnAnuller);
            this.pDetail.Controls.Add(this.btnConfirmer);
            this.pDetail.Controls.Add(this.tbNom);
            this.pDetail.Controls.Add(this.cbQualité);
            this.pDetail.Controls.Add(this.lblQualité);
            this.pDetail.Controls.Add(this.lblNom);
            this.pDetail.Location = new System.Drawing.Point(193, 164);
            this.pDetail.Name = "pDetail";
            this.pDetail.Size = new System.Drawing.Size(301, 278);
            this.pDetail.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(25, 225);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 39);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(25, 282);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(120, 39);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(25, 339);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(120, 43);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(16, 210);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(96, 40);
            this.btnConfirmer.TabIndex = 4;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // btnAnuller
            // 
            this.btnAnuller.Location = new System.Drawing.Point(168, 210);
            this.btnAnuller.Name = "btnAnuller";
            this.btnAnuller.Size = new System.Drawing.Size(89, 40);
            this.btnAnuller.TabIndex = 5;
            this.btnAnuller.Text = "Annuler";
            this.btnAnuller.UseVisualStyleBackColor = true;
            this.btnAnuller.Click += new System.EventHandler(this.btnAnuller_Click);
            // 
            // EcranListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 460);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pDetail);
            this.Controls.Add(this.btnOuvrir);
            this.Controls.Add(this.lbPersonne);
            this.Controls.Add(this.lbFichier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranListe";
            this.Text = "Manipulation d\'une liste";
            this.pDetail.ResumeLayout(false);
            this.pDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFichier;
        private System.Windows.Forms.Label lblQualité;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.ListBox lbPersonne;
        private System.Windows.Forms.Button btnOuvrir;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.ComboBox cbQualité;
        private System.Windows.Forms.Panel pDetail;
        private System.Windows.Forms.Button btnAnuller;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
    }
}