namespace ISET_2020_Découverte_WinForm
{
    partial class EcranPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranPrincipal));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.mControle = new System.Windows.Forms.ToolStripMenuItem();
            this.mcProgression = new System.Windows.Forms.ToolStripMenuItem();
            this.mcListe = new System.Windows.Forms.ToolStripMenuItem();
            this.mcEditeur = new System.Windows.Forms.ToolStripMenuItem();
            this.mcClavierSouris = new System.Windows.Forms.ToolStripMenuItem();
            this.mAppli = new System.Windows.Forms.ToolStripMenuItem();
            this.maSpirographe = new System.Windows.Forms.ToolStripMenuItem();
            this.maHorloge = new System.Windows.Forms.ToolStripMenuItem();
            this.spirographe2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maNavigateurFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.malectureGPS = new System.Windows.Forms.ToolStripMenuItem();
            this.maProcessusEtThreads = new System.Windows.Forms.ToolStripMenuItem();
            this.maBDBasique = new System.Windows.Forms.ToolStripMenuItem();
            this.maBDDataset = new System.Windows.Forms.ToolStripMenuItem();
            this.maBDCouche = new System.Windows.Forms.ToolStripMenuItem();
            this.dinerPhilo = new System.Windows.Forms.ToolStripMenuItem();
            this.maSerialisation = new System.Windows.Forms.ToolStripMenuItem();
            this.maIntegration = new System.Windows.Forms.ToolStripMenuItem();
            this.maVenteDeTickets = new System.Windows.Forms.ToolStripMenuItem();
            this.mPropos = new System.Windows.Forms.ToolStripMenuItem();
            this.mpPropos = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnColore = new ISET2020userControles.BoutonColore();
            this.frequence1 = new SpiroContrôleEntree.Frequence();
            this.spirographe21 = new ISET2020UserControlSpiro.Spirographe2();
            this.maExpressionRégulière = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spirographe21)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.msMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mControle,
            this.mAppli,
            this.mPropos});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(829, 33);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // mControle
            // 
            this.mControle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mcProgression,
            this.mcListe,
            this.mcEditeur,
            this.mcClavierSouris});
            this.mControle.Name = "mControle";
            this.mControle.Size = new System.Drawing.Size(100, 29);
            this.mControle.Text = "Contrôles";
            // 
            // mcProgression
            // 
            this.mcProgression.Name = "mcProgression";
            this.mcProgression.Size = new System.Drawing.Size(269, 30);
            this.mcProgression.Text = "Barres de progression";
            this.mcProgression.Click += new System.EventHandler(this.mcProgression_Click);
            // 
            // mcListe
            // 
            this.mcListe.Name = "mcListe";
            this.mcListe.Size = new System.Drawing.Size(269, 30);
            this.mcListe.Text = "Liste";
            this.mcListe.Click += new System.EventHandler(this.mcListe_Click);
            // 
            // mcEditeur
            // 
            this.mcEditeur.Name = "mcEditeur";
            this.mcEditeur.Size = new System.Drawing.Size(269, 30);
            this.mcEditeur.Text = "Editeur de texte";
            this.mcEditeur.Click += new System.EventHandler(this.mcEditeur_Click);
            // 
            // mcClavierSouris
            // 
            this.mcClavierSouris.Name = "mcClavierSouris";
            this.mcClavierSouris.Size = new System.Drawing.Size(269, 30);
            this.mcClavierSouris.Text = "Clavier - Souris";
            this.mcClavierSouris.Click += new System.EventHandler(this.mcClavierSouris_Click);
            // 
            // mAppli
            // 
            this.mAppli.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maSpirographe,
            this.maHorloge,
            this.spirographe2ToolStripMenuItem,
            this.maNavigateurFichier,
            this.malectureGPS,
            this.maProcessusEtThreads,
            this.maBDBasique,
            this.maBDDataset,
            this.maBDCouche,
            this.dinerPhilo,
            this.maSerialisation,
            this.maIntegration,
            this.maVenteDeTickets,
            this.maExpressionRégulière});
            this.mAppli.Name = "mAppli";
            this.mAppli.Size = new System.Drawing.Size(122, 29);
            this.mAppli.Text = "Applications";
            // 
            // maSpirographe
            // 
            this.maSpirographe.Name = "maSpirographe";
            this.maSpirographe.Size = new System.Drawing.Size(312, 30);
            this.maSpirographe.Text = "Spirographe";
            this.maSpirographe.Click += new System.EventHandler(this.maSpirographe_Click);
            // 
            // maHorloge
            // 
            this.maHorloge.Name = "maHorloge";
            this.maHorloge.Size = new System.Drawing.Size(312, 30);
            this.maHorloge.Text = "Horloge";
            this.maHorloge.Click += new System.EventHandler(this.maHorloge_Click);
            // 
            // spirographe2ToolStripMenuItem
            // 
            this.spirographe2ToolStripMenuItem.Name = "spirographe2ToolStripMenuItem";
            this.spirographe2ToolStripMenuItem.Size = new System.Drawing.Size(312, 30);
            this.spirographe2ToolStripMenuItem.Text = "Spirographe2";
            this.spirographe2ToolStripMenuItem.Click += new System.EventHandler(this.spirographe2ToolStripMenuItem_Click);
            // 
            // maNavigateurFichier
            // 
            this.maNavigateurFichier.Name = "maNavigateurFichier";
            this.maNavigateurFichier.Size = new System.Drawing.Size(312, 30);
            this.maNavigateurFichier.Text = "Navigateur fichiers";
            this.maNavigateurFichier.Click += new System.EventHandler(this.maNavigateurFichier_Click);
            // 
            // malectureGPS
            // 
            this.malectureGPS.Name = "malectureGPS";
            this.malectureGPS.Size = new System.Drawing.Size(312, 30);
            this.malectureGPS.Text = "Lecture GPS";
            this.malectureGPS.Click += new System.EventHandler(this.malectureGPS_Click);
            // 
            // maProcessusEtThreads
            // 
            this.maProcessusEtThreads.Name = "maProcessusEtThreads";
            this.maProcessusEtThreads.Size = new System.Drawing.Size(312, 30);
            this.maProcessusEtThreads.Text = "Processus et threads";
            this.maProcessusEtThreads.Click += new System.EventHandler(this.maProcessusEtThreads_Click);
            // 
            // maBDBasique
            // 
            this.maBDBasique.Name = "maBDBasique";
            this.maBDBasique.Size = new System.Drawing.Size(312, 30);
            this.maBDBasique.Text = "Base de données (basique)";
            this.maBDBasique.Click += new System.EventHandler(this.maBDBasique_Click);
            // 
            // maBDDataset
            // 
            this.maBDDataset.Name = "maBDDataset";
            this.maBDDataset.Size = new System.Drawing.Size(312, 30);
            this.maBDDataset.Text = "Base de données (Dataset)";
            this.maBDDataset.Click += new System.EventHandler(this.maBDDataset_Click);
            // 
            // maBDCouche
            // 
            this.maBDCouche.Name = "maBDCouche";
            this.maBDCouche.Size = new System.Drawing.Size(312, 30);
            this.maBDCouche.Text = "Base de données (Couches)";
            this.maBDCouche.Click += new System.EventHandler(this.maBDCouche_Click);
            // 
            // dinerPhilo
            // 
            this.dinerPhilo.Name = "dinerPhilo";
            this.dinerPhilo.Size = new System.Drawing.Size(312, 30);
            this.dinerPhilo.Text = "Diner des Philosophes";
            this.dinerPhilo.Click += new System.EventHandler(this.dinerPhilo_Click);
            // 
            // maSerialisation
            // 
            this.maSerialisation.Name = "maSerialisation";
            this.maSerialisation.Size = new System.Drawing.Size(312, 30);
            this.maSerialisation.Text = "Sérialisation";
            this.maSerialisation.Click += new System.EventHandler(this.maSerialisation_Click);
            // 
            // maIntegration
            // 
            this.maIntegration.Name = "maIntegration";
            this.maIntegration.Size = new System.Drawing.Size(312, 30);
            this.maIntegration.Text = "Intégration";
            this.maIntegration.Click += new System.EventHandler(this.maIntegration_Click);
            // 
            // maVenteDeTickets
            // 
            this.maVenteDeTickets.Name = "maVenteDeTickets";
            this.maVenteDeTickets.Size = new System.Drawing.Size(312, 30);
            this.maVenteDeTickets.Text = "Vente de tickets";
            this.maVenteDeTickets.Click += new System.EventHandler(this.maVenteDeTickets_Click);
            // 
            // mPropos
            // 
            this.mPropos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mpPropos});
            this.mPropos.Name = "mPropos";
            this.mPropos.Size = new System.Drawing.Size(98, 29);
            this.mPropos.Text = "A Propos";
            // 
            // mpPropos
            // 
            this.mpPropos.Name = "mpPropos";
            this.mpPropos.Size = new System.Drawing.Size(171, 30);
            this.mpPropos.Text = "A propos";
            this.mpPropos.Click += new System.EventHandler(this.mpPropos_Click);
            // 
            // BtnColore
            // 
            this.BtnColore.CouleurDroite = System.Drawing.Color.Red;
            this.BtnColore.CouleurGauche = System.Drawing.Color.Yellow;
            this.BtnColore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnColore.Location = new System.Drawing.Point(12, 47);
            this.BtnColore.Name = "BtnColore";
            this.BtnColore.Size = new System.Drawing.Size(766, 101);
            this.BtnColore.TabIndex = 1;
            this.BtnColore.Text = "Bouton DLL";
            this.BtnColore.TransparenceDroite = 120;
            this.BtnColore.TransparenceGauche = 100;
            this.BtnColore.UseVisualStyleBackColor = true;
            this.BtnColore.Click += new System.EventHandler(this.boutonColore_Click);
            // 
            // frequence1
            // 
            this.frequence1.Entrees.Add(((SpiroContrôleEntree.MonPoint)(resources.GetObject("frequence1.Entrees"))));
            this.frequence1.Entrees.Add(((SpiroContrôleEntree.MonPoint)(resources.GetObject("frequence1.Entrees1"))));
            this.frequence1.Entrees.Add(((SpiroContrôleEntree.MonPoint)(resources.GetObject("frequence1.Entrees2"))));
            this.frequence1.Entrees.Add(((SpiroContrôleEntree.MonPoint)(resources.GetObject("frequence1.Entrees3"))));
            this.frequence1.Location = new System.Drawing.Point(384, 154);
            this.frequence1.Name = "frequence1";
            this.frequence1.Size = new System.Drawing.Size(394, 294);
            this.frequence1.TabIndex = 3;
            this.frequence1.Trait = System.Drawing.Color.Black;
            this.frequence1.Xmax = 100;
            this.frequence1.Xmin = 0;
            this.frequence1.Ymax = 100;
            this.frequence1.Ymin = 0;
            // 
            // spirographe21
            // 
            this.spirographe21.Location = new System.Drawing.Point(12, 154);
            this.spirographe21.Name = "spirographe21";
            this.spirographe21.Size = new System.Drawing.Size(366, 294);
            this.spirographe21.TabIndex = 2;
            this.spirographe21.TabStop = false;
            // 
            // maExpressionRégulière
            // 
            this.maExpressionRégulière.Name = "maExpressionRégulière";
            this.maExpressionRégulière.Size = new System.Drawing.Size(312, 30);
            this.maExpressionRégulière.Text = "Expression régulière";
            this.maExpressionRégulière.Click += new System.EventHandler(this.maExpressionRégulière_Click);
            // 
            // EcranPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 471);
            this.Controls.Add(this.frequence1);
            this.Controls.Add(this.spirographe21);
            this.Controls.Add(this.BtnColore);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "EcranPrincipal";
            this.Text = "Manipulations diverses et variées";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EcranPrincipal_FormClosing);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spirographe21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem mControle;
        private System.Windows.Forms.ToolStripMenuItem mcProgression;
        private System.Windows.Forms.ToolStripMenuItem mcListe;
        private System.Windows.Forms.ToolStripMenuItem mcEditeur;
        private System.Windows.Forms.ToolStripMenuItem mAppli;
        private System.Windows.Forms.ToolStripMenuItem mPropos;
        private System.Windows.Forms.ToolStripMenuItem mpPropos;
        private System.Windows.Forms.ToolStripMenuItem maHorloge;
        private System.Windows.Forms.ToolStripMenuItem mcClavierSouris;
        private System.Windows.Forms.ToolStripMenuItem spirographe2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maNavigateurFichier;
        private ISET2020userControles.BoutonColore BtnColore;
        private SpiroContrôleEntree.Frequence frequence1;
        private System.Windows.Forms.ToolStripMenuItem malectureGPS;
        private System.Windows.Forms.ToolStripMenuItem maProcessusEtThreads;
        private System.Windows.Forms.ToolStripMenuItem maBDBasique;
        private System.Windows.Forms.ToolStripMenuItem maBDDataset;
        private System.Windows.Forms.ToolStripMenuItem maBDCouche;
        private System.Windows.Forms.ToolStripMenuItem dinerPhilo;
        private System.Windows.Forms.ToolStripMenuItem maSpirographe;
        private ISET2020UserControlSpiro.Spirographe2 spirographe21;
        private System.Windows.Forms.ToolStripMenuItem maSerialisation;
        private System.Windows.Forms.ToolStripMenuItem maIntegration;
        private System.Windows.Forms.ToolStripMenuItem maVenteDeTickets;
        private System.Windows.Forms.ToolStripMenuItem maExpressionRégulière;
        //private ISET2020UserControlSpiro.Spirographe2 spirographe21;
    }
}