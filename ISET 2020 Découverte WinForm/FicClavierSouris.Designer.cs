namespace ISET_2020_Découverte_WinForm
{
    partial class EcranClavierSouris
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
            this.lbClavier = new System.Windows.Forms.ListBox();
            this.btnRAZ = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.pZoneSouris = new System.Windows.Forms.Panel();
            this.lbGauche = new System.Windows.Forms.Label();
            this.tbGauche = new System.Windows.Forms.TextBox();
            this.lbDroit = new System.Windows.Forms.Label();
            this.lbX = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
            this.tbDroite = new System.Windows.Forms.TextBox();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbClavier
            // 
            this.lbClavier.FormattingEnabled = true;
            this.lbClavier.ItemHeight = 20;
            this.lbClavier.Location = new System.Drawing.Point(0, 0);
            this.lbClavier.Name = "lbClavier";
            this.lbClavier.Size = new System.Drawing.Size(247, 344);
            this.lbClavier.TabIndex = 0;
            // 
            // btnRAZ
            // 
            this.btnRAZ.Location = new System.Drawing.Point(0, 358);
            this.btnRAZ.Name = "btnRAZ";
            this.btnRAZ.Size = new System.Drawing.Size(80, 32);
            this.btnRAZ.TabIndex = 1;
            this.btnRAZ.Text = "R a Z";
            this.btnRAZ.UseVisualStyleBackColor = true;
            this.btnRAZ.Click += new System.EventHandler(this.btnRAZ_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(123, 358);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(89, 30);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // pZoneSouris
            // 
            this.pZoneSouris.Location = new System.Drawing.Point(257, 132);
            this.pZoneSouris.Name = "pZoneSouris";
            this.pZoneSouris.Size = new System.Drawing.Size(417, 276);
            this.pZoneSouris.TabIndex = 3;
            this.pZoneSouris.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EcranClavierSouris_MouseDown);
            this.pZoneSouris.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pZoneSouris_MouseMove);
            // 
            // lbGauche
            // 
            this.lbGauche.AutoSize = true;
            this.lbGauche.Location = new System.Drawing.Point(253, 52);
            this.lbGauche.Name = "lbGauche";
            this.lbGauche.Size = new System.Drawing.Size(103, 20);
            this.lbGauche.TabIndex = 4;
            this.lbGauche.Text = "Click Gauche";
            // 
            // tbGauche
            // 
            this.tbGauche.Location = new System.Drawing.Point(256, 75);
            this.tbGauche.Name = "tbGauche";
            this.tbGauche.Size = new System.Drawing.Size(100, 26);
            this.tbGauche.TabIndex = 5;
            // 
            // lbDroit
            // 
            this.lbDroit.AutoSize = true;
            this.lbDroit.Location = new System.Drawing.Point(372, 52);
            this.lbDroit.Name = "lbDroit";
            this.lbDroit.Size = new System.Drawing.Size(80, 20);
            this.lbDroit.TabIndex = 6;
            this.lbDroit.Text = "Click Droit";
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Location = new System.Drawing.Point(474, 52);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(80, 20);
            this.lbX.TabIndex = 7;
            this.lbX.Text = "Position X";
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Location = new System.Drawing.Point(583, 52);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(80, 20);
            this.lbY.TabIndex = 8;
            this.lbY.Text = "Position Y";
            // 
            // tbDroite
            // 
            this.tbDroite.Location = new System.Drawing.Point(362, 75);
            this.tbDroite.Name = "tbDroite";
            this.tbDroite.Size = new System.Drawing.Size(100, 26);
            this.tbDroite.TabIndex = 9;
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(468, 75);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(100, 26);
            this.tbX.TabIndex = 10;
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(574, 75);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(100, 26);
            this.tbY.TabIndex = 11;
            // 
            // EcranClavierSouris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 432);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.tbDroite);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.lbX);
            this.Controls.Add(this.lbDroit);
            this.Controls.Add(this.tbGauche);
            this.Controls.Add(this.lbGauche);
            this.Controls.Add(this.pZoneSouris);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnRAZ);
            this.Controls.Add(this.lbClavier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranClavierSouris";
            this.Text = "Suivis du clavier et de la souris";
            this.Load += new System.EventHandler(this.EcranClavierSouris_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbGauche_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGauche_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbGauche_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbClavier;
        private System.Windows.Forms.Button btnRAZ;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Panel pZoneSouris;
        private System.Windows.Forms.Label lbGauche;
        private System.Windows.Forms.TextBox tbGauche;
        private System.Windows.Forms.Label lbDroit;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.TextBox tbDroite;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
    }
}