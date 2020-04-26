namespace ISET_2020_Découverte_WinForm
{
    partial class EcranBDDataset
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
            this.components = new System.ComponentModel.Container();
            this.lblID = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbPre = new System.Windows.Forms.TextBox();
            this.lblPre = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblNai = new System.Windows.Forms.Label();
            this.dtpNai = new System.Windows.Forms.DateTimePicker();
            this.btn1er = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEditer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.dspClient = new ISET_2020_Découverte_WinForm.DataSetPerso();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new ISET_2020_Découverte_WinForm.DataSetPersoTableAdapters.ClientTableAdapter();
            this.nUMCLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dspClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(27, 23);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(80, 20);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Identifiant";
            // 
            // tbID
            // 
            this.tbID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "NUMCLI", true));
            this.tbID.Location = new System.Drawing.Point(31, 60);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(210, 26);
            this.tbID.TabIndex = 1;
            // 
            // tbPre
            // 
            this.tbPre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "PRE", true));
            this.tbPre.Location = new System.Drawing.Point(31, 141);
            this.tbPre.Name = "tbPre";
            this.tbPre.Size = new System.Drawing.Size(210, 26);
            this.tbPre.TabIndex = 3;
            // 
            // lblPre
            // 
            this.lblPre.AutoSize = true;
            this.lblPre.Location = new System.Drawing.Point(27, 105);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(64, 20);
            this.lblPre.TabIndex = 2;
            this.lblPre.Text = "Prenom";
            // 
            // tbNom
            // 
            this.tbNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "NOM", true));
            this.tbNom.Location = new System.Drawing.Point(31, 205);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(210, 26);
            this.tbNom.TabIndex = 5;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(27, 182);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 20);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Nom";
            // 
            // lblNai
            // 
            this.lblNai.AutoSize = true;
            this.lblNai.Location = new System.Drawing.Point(27, 250);
            this.lblNai.Name = "lblNai";
            this.lblNai.Size = new System.Drawing.Size(144, 20);
            this.lblNai.TabIndex = 6;
            this.lblNai.Text = "Date de Naissance";
            // 
            // dtpNai
            // 
            this.dtpNai.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientBindingSource, "NAI", true));
            this.dtpNai.Location = new System.Drawing.Point(5, 273);
            this.dtpNai.Name = "dtpNai";
            this.dtpNai.Size = new System.Drawing.Size(266, 26);
            this.dtpNai.TabIndex = 8;
            // 
            // btn1er
            // 
            this.btn1er.Location = new System.Drawing.Point(5, 315);
            this.btn1er.Name = "btn1er";
            this.btn1er.Size = new System.Drawing.Size(40, 33);
            this.btn1er.TabIndex = 9;
            this.btn1er.Text = "|<";
            this.btn1er.UseVisualStyleBackColor = true;
            this.btn1er.Click += new System.EventHandler(this.btn1er_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(58, 315);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(33, 33);
            this.btnSuivant.TabIndex = 10;
            this.btnSuivant.Text = "<";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(197, 315);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(33, 33);
            this.btnPrecedent.TabIndex = 11;
            this.btnPrecedent.Text = ">";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(236, 315);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(42, 33);
            this.btnDernier.TabIndex = 12;
            this.btnDernier.Text = ">|";
            this.btnDernier.UseVisualStyleBackColor = true;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // lblPosition
            // 
            this.lblPosition.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblPosition.Location = new System.Drawing.Point(97, 312);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(94, 39);
            this.lblPosition.TabIndex = 13;
            this.lblPosition.Text = "0/0";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(5, 365);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(102, 50);
            this.btnConfirmer.TabIndex = 14;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(162, 365);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(116, 50);
            this.btnAnnuler.TabIndex = 15;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEditer
            // 
            this.btnEditer.Location = new System.Drawing.Point(5, 421);
            this.btnEditer.Name = "btnEditer";
            this.btnEditer.Size = new System.Drawing.Size(86, 40);
            this.btnEditer.TabIndex = 16;
            this.btnEditer.Text = "Editer";
            this.btnEditer.UseVisualStyleBackColor = true;
            this.btnEditer.Click += new System.EventHandler(this.btnEditer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(97, 421);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(74, 40);
            this.btnAjouter.TabIndex = 17;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(178, 421);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(100, 40);
            this.btnSupprimer.TabIndex = 18;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToDeleteRows = false;
            this.dgvClient.AutoGenerateColumns = false;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nUMCLIDataGridViewTextBoxColumn,
            this.nOMDataGridViewTextBoxColumn,
            this.pREDataGridViewTextBoxColumn,
            this.nAIDataGridViewTextBoxColumn});
            this.dgvClient.DataSource = this.clientBindingSource;
            this.dgvClient.Location = new System.Drawing.Point(267, 23);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            this.dgvClient.RowHeadersVisible = false;
            this.dgvClient.RowTemplate.Height = 28;
            this.dgvClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClient.Size = new System.Drawing.Size(541, 208);
            this.dgvClient.TabIndex = 19;
            // 
            // dspClient
            // 
            this.dspClient.DataSetName = "DataSetPerso";
            this.dspClient.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.dspClient;
            this.clientBindingSource.CurrentChanged += new System.EventHandler(this.clientBindingSource_CurrentChanged);
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // nUMCLIDataGridViewTextBoxColumn
            // 
            this.nUMCLIDataGridViewTextBoxColumn.DataPropertyName = "NUMCLI";
            this.nUMCLIDataGridViewTextBoxColumn.HeaderText = "NUMCLI";
            this.nUMCLIDataGridViewTextBoxColumn.Name = "nUMCLIDataGridViewTextBoxColumn";
            this.nUMCLIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMDataGridViewTextBoxColumn
            // 
            this.nOMDataGridViewTextBoxColumn.DataPropertyName = "NOM";
            this.nOMDataGridViewTextBoxColumn.HeaderText = "NOM";
            this.nOMDataGridViewTextBoxColumn.Name = "nOMDataGridViewTextBoxColumn";
            this.nOMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pREDataGridViewTextBoxColumn
            // 
            this.pREDataGridViewTextBoxColumn.DataPropertyName = "PRE";
            this.pREDataGridViewTextBoxColumn.HeaderText = "PRE";
            this.pREDataGridViewTextBoxColumn.Name = "pREDataGridViewTextBoxColumn";
            this.pREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nAIDataGridViewTextBoxColumn
            // 
            this.nAIDataGridViewTextBoxColumn.DataPropertyName = "NAI";
            this.nAIDataGridViewTextBoxColumn.HeaderText = "NAI";
            this.nAIDataGridViewTextBoxColumn.Name = "nAIDataGridViewTextBoxColumn";
            this.nAIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EcranBDDataset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 482);
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnEditer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.btnDernier);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btn1er);
            this.Controls.Add(this.dtpNai);
            this.Controls.Add(this.lblNai);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.tbPre);
            this.Controls.Add(this.lblPre);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lblID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranBDDataset";
            this.Text = "Gestion de BD via un Dataset";
            this.Load += new System.EventHandler(this.EcranBDDataset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dspClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbPre;
        private System.Windows.Forms.Label lblPre;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblNai;
        private System.Windows.Forms.DateTimePicker dtpNai;
        private System.Windows.Forms.Button btn1er;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEditer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.DataGridView dgvClient;
        private DataSetPerso dspClient;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DataSetPersoTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMCLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAIDataGridViewTextBoxColumn;
    }
}