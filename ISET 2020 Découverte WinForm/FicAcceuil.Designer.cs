namespace ISET_2020_Découverte_WinForm
{
    partial class EcranAcceuil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnPousser = new System.Windows.Forms.Button();
            this.btnEntrer = new System.Windows.Forms.Button();
            this.pbDemarrage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDemarrage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Découverte de C#";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPousser
            // 
            this.btnPousser.BackColor = System.Drawing.Color.DarkGray;
            this.btnPousser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPousser.Location = new System.Drawing.Point(21, 224);
            this.btnPousser.Name = "btnPousser";
            this.btnPousser.Size = new System.Drawing.Size(161, 33);
            this.btnPousser.TabIndex = 2;
            this.btnPousser.Text = "P o u s s e r";
            this.btnPousser.UseVisualStyleBackColor = false;
            this.btnPousser.Click += new System.EventHandler(this.btnPousser_Click);
            // 
            // btnEntrer
            // 
            this.btnEntrer.BackColor = System.Drawing.Color.DarkGray;
            this.btnEntrer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEntrer.Location = new System.Drawing.Point(188, 224);
            this.btnEntrer.Name = "btnEntrer";
            this.btnEntrer.Size = new System.Drawing.Size(161, 33);
            this.btnEntrer.TabIndex = 3;
            this.btnEntrer.Text = "E n t r e r";
            this.btnEntrer.UseVisualStyleBackColor = false;
            this.btnEntrer.Click += new System.EventHandler(this.btnEntrer_Click);
            // 
            // pbDemarrage
            // 
            this.pbDemarrage.Image = global::ISET_2020_Découverte_WinForm.Properties.Resources._46519517_515989682215356_2729004365699350528_n;
            this.pbDemarrage.Location = new System.Drawing.Point(150, 127);
            this.pbDemarrage.Name = "pbDemarrage";
            this.pbDemarrage.Size = new System.Drawing.Size(79, 67);
            this.pbDemarrage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDemarrage.TabIndex = 1;
            this.pbDemarrage.TabStop = false;
            // 
            // EcranAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(376, 282);
            this.Controls.Add(this.btnEntrer);
            this.Controls.Add(this.btnPousser);
            this.Controls.Add(this.pbDemarrage);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranAcceuil";
            this.Text = "Bienvenue, Welcome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EcranAcceuil_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbDemarrage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPousser;
        private System.Windows.Forms.PictureBox pbDemarrage;
        private System.Windows.Forms.Button btnEntrer;
    }
}

