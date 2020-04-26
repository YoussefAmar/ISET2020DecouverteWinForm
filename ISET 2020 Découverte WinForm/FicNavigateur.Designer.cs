namespace ISET_2020_Découverte_WinForm
{
    partial class EcranNavigateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranNavigateur));
            this.tsCommandes = new System.Windows.Forms.ToolStrip();
            this.tsbQuitter = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsApparence = new System.Windows.Forms.ToolStripSplitButton();
            this.tsPetitesIcones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGrandesIcones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsListe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMessage = new System.Windows.Forms.StatusStrip();
            this.tsslMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainerDivision = new System.Windows.Forms.SplitContainer();
            this.tvRepertoire = new System.Windows.Forms.TreeView();
            this.ilRepertoire = new System.Windows.Forms.ImageList(this.components);
            this.lvFichier = new System.Windows.Forms.ListView();
            this.NOM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TAI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CRE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MOD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilFichierGrand = new System.Windows.Forms.ImageList(this.components);
            this.ilFichierPetit = new System.Windows.Forms.ImageList(this.components);
            this.tsCommandes.SuspendLayout();
            this.ssMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDivision)).BeginInit();
            this.splitContainerDivision.Panel1.SuspendLayout();
            this.splitContainerDivision.Panel2.SuspendLayout();
            this.splitContainerDivision.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsCommandes
            // 
            this.tsCommandes.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsCommandes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbQuitter,
            this.toolStripSeparator1,
            this.tsApparence});
            this.tsCommandes.Location = new System.Drawing.Point(0, 0);
            this.tsCommandes.Name = "tsCommandes";
            this.tsCommandes.Size = new System.Drawing.Size(674, 31);
            this.tsCommandes.TabIndex = 0;
            this.tsCommandes.Text = "toolStrip1";
            // 
            // tsbQuitter
            // 
            this.tsbQuitter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbQuitter.Image = global::ISET_2020_Découverte_WinForm.Properties.Resources.doorshut;
            this.tsbQuitter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuitter.Name = "tsbQuitter";
            this.tsbQuitter.Size = new System.Drawing.Size(28, 28);
            this.tsbQuitter.Text = "toolStripButton1";
            this.tsbQuitter.Click += new System.EventHandler(this.tsbQuitter_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsApparence
            // 
            this.tsApparence.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsApparence.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPetitesIcones,
            this.tsGrandesIcones,
            this.tsListe,
            this.tsDetail});
            this.tsApparence.Image = global::ISET_2020_Découverte_WinForm.Properties.Resources.WETBApparence;
            this.tsApparence.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsApparence.Name = "tsApparence";
            this.tsApparence.Size = new System.Drawing.Size(45, 28);
            this.tsApparence.Text = "toolStripSplitButton1";
            // 
            // tsPetitesIcones
            // 
            this.tsPetitesIcones.Name = "tsPetitesIcones";
            this.tsPetitesIcones.Size = new System.Drawing.Size(252, 30);
            this.tsPetitesIcones.Text = "Petites icones";
            this.tsPetitesIcones.Click += new System.EventHandler(this.tsPetitesIcones_Click);
            // 
            // tsGrandesIcones
            // 
            this.tsGrandesIcones.Name = "tsGrandesIcones";
            this.tsGrandesIcones.Size = new System.Drawing.Size(252, 30);
            this.tsGrandesIcones.Text = "Grandes icones";
            this.tsGrandesIcones.Click += new System.EventHandler(this.tsGrandesIcones_Click);
            // 
            // tsListe
            // 
            this.tsListe.Name = "tsListe";
            this.tsListe.Size = new System.Drawing.Size(252, 30);
            this.tsListe.Text = "Liste";
            this.tsListe.Click += new System.EventHandler(this.tsListe_Click);
            // 
            // tsDetail
            // 
            this.tsDetail.Name = "tsDetail";
            this.tsDetail.Size = new System.Drawing.Size(252, 30);
            this.tsDetail.Text = "Detail";
            this.tsDetail.Click += new System.EventHandler(this.tsDetail_Click);
            // 
            // ssMessage
            // 
            this.ssMessage.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ssMessage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMessage});
            this.ssMessage.Location = new System.Drawing.Point(0, 422);
            this.ssMessage.Name = "ssMessage";
            this.ssMessage.Size = new System.Drawing.Size(674, 22);
            this.ssMessage.TabIndex = 1;
            this.ssMessage.Text = "statusStrip1";
            // 
            // tsslMessage
            // 
            this.tsslMessage.Name = "tsslMessage";
            this.tsslMessage.Size = new System.Drawing.Size(0, 23);
            // 
            // splitContainerDivision
            // 
            this.splitContainerDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDivision.Location = new System.Drawing.Point(0, 31);
            this.splitContainerDivision.Name = "splitContainerDivision";
            // 
            // splitContainerDivision.Panel1
            // 
            this.splitContainerDivision.Panel1.Controls.Add(this.tvRepertoire);
            // 
            // splitContainerDivision.Panel2
            // 
            this.splitContainerDivision.Panel2.Controls.Add(this.lvFichier);
            this.splitContainerDivision.Size = new System.Drawing.Size(674, 391);
            this.splitContainerDivision.SplitterDistance = 148;
            this.splitContainerDivision.TabIndex = 2;
            // 
            // tvRepertoire
            // 
            this.tvRepertoire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvRepertoire.ImageIndex = 0;
            this.tvRepertoire.ImageList = this.ilRepertoire;
            this.tvRepertoire.Location = new System.Drawing.Point(0, 0);
            this.tvRepertoire.Name = "tvRepertoire";
            this.tvRepertoire.SelectedImageIndex = 0;
            this.tvRepertoire.Size = new System.Drawing.Size(148, 391);
            this.tvRepertoire.TabIndex = 0;
            this.tvRepertoire.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvRepertoire_AfterSelect);
            // 
            // ilRepertoire
            // 
            this.ilRepertoire.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilRepertoire.ImageStream")));
            this.ilRepertoire.TransparentColor = System.Drawing.Color.Transparent;
            this.ilRepertoire.Images.SetKeyName(0, "WEOrdi.bmp");
            this.ilRepertoire.Images.SetKeyName(1, "WEFloppy.bmp");
            this.ilRepertoire.Images.SetKeyName(2, "WERepertoire.bmp");
            this.ilRepertoire.Images.SetKeyName(3, "WERepertoireActif.bmp");
            this.ilRepertoire.Images.SetKeyName(4, "WEPoubelle.bmp");
            // 
            // lvFichier
            // 
            this.lvFichier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NOM,
            this.TAI,
            this.CRE,
            this.MOD});
            this.lvFichier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFichier.FullRowSelect = true;
            this.lvFichier.HideSelection = false;
            this.lvFichier.LargeImageList = this.ilFichierGrand;
            this.lvFichier.Location = new System.Drawing.Point(0, 0);
            this.lvFichier.Name = "lvFichier";
            this.lvFichier.Size = new System.Drawing.Size(522, 391);
            this.lvFichier.SmallImageList = this.ilFichierPetit;
            this.lvFichier.TabIndex = 0;
            this.lvFichier.UseCompatibleStateImageBehavior = false;
            this.lvFichier.View = System.Windows.Forms.View.Details;
            // 
            // NOM
            // 
            this.NOM.Text = "Nom";
            this.NOM.Width = 235;
            // 
            // TAI
            // 
            this.TAI.Text = "Taille";
            this.TAI.Width = 94;
            // 
            // CRE
            // 
            this.CRE.Text = "Création";
            this.CRE.Width = 75;
            // 
            // MOD
            // 
            this.MOD.Text = "Modification";
            this.MOD.Width = 103;
            // 
            // ilFichierGrand
            // 
            this.ilFichierGrand.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilFichierGrand.ImageStream")));
            this.ilFichierGrand.TransparentColor = System.Drawing.Color.Transparent;
            this.ilFichierGrand.Images.SetKeyName(0, "WELVGrandeIcone.bmp");
            // 
            // ilFichierPetit
            // 
            this.ilFichierPetit.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilFichierPetit.ImageStream")));
            this.ilFichierPetit.TransparentColor = System.Drawing.Color.Transparent;
            this.ilFichierPetit.Images.SetKeyName(0, "WELVPetiteIcone.bmp");
            // 
            // EcranNavigateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 444);
            this.Controls.Add(this.splitContainerDivision);
            this.Controls.Add(this.ssMessage);
            this.Controls.Add(this.tsCommandes);
            this.Name = "EcranNavigateur";
            this.Text = "Explorateur de fichiers";
            this.Load += new System.EventHandler(this.EcranNavigateur_Load);
            this.tsCommandes.ResumeLayout(false);
            this.tsCommandes.PerformLayout();
            this.ssMessage.ResumeLayout(false);
            this.ssMessage.PerformLayout();
            this.splitContainerDivision.Panel1.ResumeLayout(false);
            this.splitContainerDivision.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDivision)).EndInit();
            this.splitContainerDivision.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsCommandes;
        private System.Windows.Forms.StatusStrip ssMessage;
        private System.Windows.Forms.SplitContainer splitContainerDivision;
        private System.Windows.Forms.TreeView tvRepertoire;
        private System.Windows.Forms.ListView lvFichier;
        private System.Windows.Forms.ImageList ilRepertoire;
        private System.Windows.Forms.ToolStripButton tsbQuitter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ImageList ilFichierPetit;
        private System.Windows.Forms.ImageList ilFichierGrand;
        private System.Windows.Forms.ToolStripSplitButton tsApparence;
        private System.Windows.Forms.ToolStripMenuItem tsPetitesIcones;
        private System.Windows.Forms.ToolStripMenuItem tsGrandesIcones;
        private System.Windows.Forms.ToolStripMenuItem tsListe;
        private System.Windows.Forms.ToolStripMenuItem tsDetail;
        private System.Windows.Forms.ColumnHeader NOM;
        private System.Windows.Forms.ColumnHeader TAI;
        private System.Windows.Forms.ColumnHeader CRE;
        private System.Windows.Forms.ColumnHeader MOD;
        private System.Windows.Forms.ToolStripStatusLabel tsslMessage;
    }
}