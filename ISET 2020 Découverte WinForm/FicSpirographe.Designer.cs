namespace ISET_2020_Découverte_WinForm
{
    partial class EcranSpirographe
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
            this.gbParametre = new System.Windows.Forms.GroupBox();
            this.lblProfondeur = new System.Windows.Forms.Label();
            this.tbProfondeur = new System.Windows.Forms.TrackBar();
            this.tbDensite = new System.Windows.Forms.TrackBar();
            this.lblDensite = new System.Windows.Forms.Label();
            this.tbSommets = new System.Windows.Forms.TrackBar();
            this.lblSommets = new System.Windows.Forms.Label();
            this.dCouleur = new System.Windows.Forms.ColorDialog();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnFond = new System.Windows.Forms.Button();
            this.btnTrait = new System.Windows.Forms.Button();
            this.gbParametre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProfondeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDensite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSommets)).BeginInit();
            this.SuspendLayout();
            // 
            // gbParametre
            // 
            this.gbParametre.Controls.Add(this.btnFond);
            this.gbParametre.Controls.Add(this.lblProfondeur);
            this.gbParametre.Controls.Add(this.btnTrait);
            this.gbParametre.Controls.Add(this.tbProfondeur);
            this.gbParametre.Controls.Add(this.btnGo);
            this.gbParametre.Controls.Add(this.tbDensite);
            this.gbParametre.Controls.Add(this.lblDensite);
            this.gbParametre.Controls.Add(this.tbSommets);
            this.gbParametre.Controls.Add(this.lblSommets);
            this.gbParametre.Location = new System.Drawing.Point(12, 2);
            this.gbParametre.Name = "gbParametre";
            this.gbParametre.Size = new System.Drawing.Size(232, 331);
            this.gbParametre.TabIndex = 0;
            this.gbParametre.TabStop = false;
            this.gbParametre.Text = "groupBox1";
            // 
            // lblProfondeur
            // 
            this.lblProfondeur.AutoSize = true;
            this.lblProfondeur.Location = new System.Drawing.Point(-4, 157);
            this.lblProfondeur.Name = "lblProfondeur";
            this.lblProfondeur.Size = new System.Drawing.Size(227, 20);
            this.lblProfondeur.TabIndex = 5;
            this.lblProfondeur.Text = "Profondeur de dessin (20 à 80)";
            // 
            // tbProfondeur
            // 
            this.tbProfondeur.Location = new System.Drawing.Point(-9, 180);
            this.tbProfondeur.Maximum = 80;
            this.tbProfondeur.Minimum = 20;
            this.tbProfondeur.Name = "tbProfondeur";
            this.tbProfondeur.Size = new System.Drawing.Size(232, 69);
            this.tbProfondeur.TabIndex = 4;
            this.tbProfondeur.TickFrequency = 5;
            this.tbProfondeur.Value = 40;
            // 
            // tbDensite
            // 
            this.tbDensite.Location = new System.Drawing.Point(0, 108);
            this.tbDensite.Maximum = 20;
            this.tbDensite.Minimum = 5;
            this.tbDensite.Name = "tbDensite";
            this.tbDensite.Size = new System.Drawing.Size(223, 69);
            this.tbDensite.TabIndex = 3;
            this.tbDensite.Value = 10;
            // 
            // lblDensite
            // 
            this.lblDensite.AutoSize = true;
            this.lblDensite.Location = new System.Drawing.Point(-4, 85);
            this.lblDensite.Name = "lblDensite";
            this.lblDensite.Size = new System.Drawing.Size(194, 20);
            this.lblDensite.TabIndex = 2;
            this.lblDensite.Text = "Densité de dessin (5 à 20)";
            // 
            // tbSommets
            // 
            this.tbSommets.Location = new System.Drawing.Point(0, 45);
            this.tbSommets.Maximum = 8;
            this.tbSommets.Minimum = 3;
            this.tbSommets.Name = "tbSommets";
            this.tbSommets.Size = new System.Drawing.Size(223, 69);
            this.tbSommets.TabIndex = 1;
            this.tbSommets.Value = 5;
            // 
            // lblSommets
            // 
            this.lblSommets.AutoSize = true;
            this.lblSommets.Location = new System.Drawing.Point(0, 22);
            this.lblSommets.Name = "lblSommets";
            this.lblSommets.Size = new System.Drawing.Size(205, 20);
            this.lblSommets.TabIndex = 0;
            this.lblSommets.Text = "Nombre de sommets (3 à 8)";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(15, 255);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(197, 33);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "G O";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnFond
            // 
            this.btnFond.Image = global::ISET_2020_Découverte_WinForm.Properties.Resources.ICFond;
            this.btnFond.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFond.Location = new System.Drawing.Point(113, 293);
            this.btnFond.Name = "btnFond";
            this.btnFond.Size = new System.Drawing.Size(99, 32);
            this.btnFond.TabIndex = 3;
            this.btnFond.Text = "Fond";
            this.btnFond.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFond.UseVisualStyleBackColor = true;
            this.btnFond.Click += new System.EventHandler(this.btnFond_Click);
            // 
            // btnTrait
            // 
            this.btnTrait.Image = global::ISET_2020_Découverte_WinForm.Properties.Resources.ICTrait;
            this.btnTrait.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrait.Location = new System.Drawing.Point(15, 293);
            this.btnTrait.Name = "btnTrait";
            this.btnTrait.Size = new System.Drawing.Size(92, 32);
            this.btnTrait.TabIndex = 2;
            this.btnTrait.Text = "Trait";
            this.btnTrait.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrait.UseVisualStyleBackColor = true;
            this.btnTrait.Click += new System.EventHandler(this.btnTrait_Click);
            // 
            // EcranSpirographe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 328);
            this.Controls.Add(this.gbParametre);
            this.MinimumSize = new System.Drawing.Size(384, 384);
            this.Name = "EcranSpirographe";
            this.Text = "FicSpirographe";
            this.Load += new System.EventHandler(this.EcranSpirographe_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EcranSpirographe_Paint);
            this.gbParametre.ResumeLayout(false);
            this.gbParametre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProfondeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDensite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSommets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbParametre;
        private System.Windows.Forms.TrackBar tbSommets;
        private System.Windows.Forms.Label lblSommets;
        private System.Windows.Forms.Label lblProfondeur;
        private System.Windows.Forms.TrackBar tbProfondeur;
        private System.Windows.Forms.TrackBar tbDensite;
        private System.Windows.Forms.Label lblDensite;
        private System.Windows.Forms.ColorDialog dCouleur;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnTrait;
        private System.Windows.Forms.Button btnFond;
    }
}