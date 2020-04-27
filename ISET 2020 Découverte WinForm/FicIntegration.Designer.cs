namespace ISET_2020_Découverte_WinForm
{
    partial class EcranIntegration
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
            this.lgauche = new System.Windows.Forms.Label();
            this.tbgauche = new System.Windows.Forms.TextBox();
            this.tbdroite = new System.Windows.Forms.TextBox();
            this.ldroite = new System.Windows.Forms.Label();
            this.tbNbInt = new System.Windows.Forms.TextBox();
            this.lNbInt = new System.Windows.Forms.Label();
            this.lbResultats = new System.Windows.Forms.ListBox();
            this.bPolynome = new System.Windows.Forms.Button();
            this.bTrigonometrique = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lgauche
            // 
            this.lgauche.AutoSize = true;
            this.lgauche.Location = new System.Drawing.Point(12, 40);
            this.lgauche.Name = "lgauche";
            this.lgauche.Size = new System.Drawing.Size(66, 20);
            this.lgauche.TabIndex = 0;
            this.lgauche.Text = "Gauche";
            // 
            // tbgauche
            // 
            this.tbgauche.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbgauche.Location = new System.Drawing.Point(12, 63);
            this.tbgauche.Name = "tbgauche";
            this.tbgauche.Size = new System.Drawing.Size(100, 26);
            this.tbgauche.TabIndex = 1;
            this.tbgauche.Text = "0";
            this.tbgauche.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbdroite
            // 
            this.tbdroite.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdroite.Location = new System.Drawing.Point(222, 63);
            this.tbdroite.Name = "tbdroite";
            this.tbdroite.Size = new System.Drawing.Size(100, 26);
            this.tbdroite.TabIndex = 3;
            this.tbdroite.Text = "4";
            this.tbdroite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ldroite
            // 
            this.ldroite.AutoSize = true;
            this.ldroite.Location = new System.Drawing.Point(222, 40);
            this.ldroite.Name = "ldroite";
            this.ldroite.Size = new System.Drawing.Size(52, 20);
            this.ldroite.TabIndex = 2;
            this.ldroite.Text = "Droite";
            // 
            // tbNbInt
            // 
            this.tbNbInt.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNbInt.Location = new System.Drawing.Point(413, 63);
            this.tbNbInt.Name = "tbNbInt";
            this.tbNbInt.Size = new System.Drawing.Size(100, 26);
            this.tbNbInt.TabIndex = 5;
            this.tbNbInt.Text = "2";
            this.tbNbInt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lNbInt
            // 
            this.lNbInt.AutoSize = true;
            this.lNbInt.Location = new System.Drawing.Point(413, 40);
            this.lNbInt.Name = "lNbInt";
            this.lNbInt.Size = new System.Drawing.Size(95, 20);
            this.lNbInt.TabIndex = 4;
            this.lNbInt.Text = "Nb intervalle";
            // 
            // lbResultats
            // 
            this.lbResultats.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultats.FormattingEnabled = true;
            this.lbResultats.ItemHeight = 22;
            this.lbResultats.Location = new System.Drawing.Point(12, 109);
            this.lbResultats.Name = "lbResultats";
            this.lbResultats.Size = new System.Drawing.Size(501, 312);
            this.lbResultats.TabIndex = 6;
            // 
            // bPolynome
            // 
            this.bPolynome.Location = new System.Drawing.Point(12, 427);
            this.bPolynome.Name = "bPolynome";
            this.bPolynome.Size = new System.Drawing.Size(496, 73);
            this.bPolynome.TabIndex = 7;
            this.bPolynome.Text = "Polynôme : x * x + 1";
            this.bPolynome.UseVisualStyleBackColor = true;
            this.bPolynome.Click += new System.EventHandler(this.bIntegration_Click);
            // 
            // bTrigonometrique
            // 
            this.bTrigonometrique.Location = new System.Drawing.Point(12, 506);
            this.bTrigonometrique.Name = "bTrigonometrique";
            this.bTrigonometrique.Size = new System.Drawing.Size(496, 73);
            this.bTrigonometrique.TabIndex = 8;
            this.bTrigonometrique.Text = "Trygonométrique : cos(x)";
            this.bTrigonometrique.UseVisualStyleBackColor = true;
            this.bTrigonometrique.Click += new System.EventHandler(this.bIntegration_Click);
            // 
            // EcranIntegration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 655);
            this.Controls.Add(this.bTrigonometrique);
            this.Controls.Add(this.bPolynome);
            this.Controls.Add(this.lbResultats);
            this.Controls.Add(this.tbNbInt);
            this.Controls.Add(this.lNbInt);
            this.Controls.Add(this.tbdroite);
            this.Controls.Add(this.ldroite);
            this.Controls.Add(this.tbgauche);
            this.Controls.Add(this.lgauche);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranIntegration";
            this.Text = "Intégration (méthode des trapèzes)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lgauche;
        private System.Windows.Forms.TextBox tbgauche;
        private System.Windows.Forms.TextBox tbdroite;
        private System.Windows.Forms.Label ldroite;
        private System.Windows.Forms.TextBox tbNbInt;
        private System.Windows.Forms.Label lNbInt;
        private System.Windows.Forms.ListBox lbResultats;
        private System.Windows.Forms.Button bPolynome;
        private System.Windows.Forms.Button bTrigonometrique;
    }
}