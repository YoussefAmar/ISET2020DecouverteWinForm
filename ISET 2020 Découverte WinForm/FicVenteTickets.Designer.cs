namespace ISET_2020_Découverte_WinForm
{
    partial class EcranVenteTickets
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
            this.tbNbVendeurs = new System.Windows.Forms.TrackBar();
            this.lNbVendeur = new System.Windows.Forms.Label();
            this.lNbTickets = new System.Windows.Forms.Label();
            this.tbNbTickets = new System.Windows.Forms.TrackBar();
            this.bSimuler = new System.Windows.Forms.Button();
            this.lbResultats = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbNbVendeurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNbTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNbVendeurs
            // 
            this.tbNbVendeurs.Location = new System.Drawing.Point(12, 41);
            this.tbNbVendeurs.Minimum = 2;
            this.tbNbVendeurs.Name = "tbNbVendeurs";
            this.tbNbVendeurs.Size = new System.Drawing.Size(466, 69);
            this.tbNbVendeurs.TabIndex = 0;
            this.tbNbVendeurs.Value = 4;
            // 
            // lNbVendeur
            // 
            this.lNbVendeur.AutoSize = true;
            this.lNbVendeur.Location = new System.Drawing.Point(12, 9);
            this.lNbVendeur.Name = "lNbVendeur";
            this.lNbVendeur.Size = new System.Drawing.Size(156, 20);
            this.lNbVendeur.TabIndex = 1;
            this.lNbVendeur.Text = "Nombre de vendeurs";
            // 
            // lNbTickets
            // 
            this.lNbTickets.AutoSize = true;
            this.lNbTickets.Location = new System.Drawing.Point(16, 114);
            this.lNbTickets.Name = "lNbTickets";
            this.lNbTickets.Size = new System.Drawing.Size(137, 20);
            this.lNbTickets.TabIndex = 3;
            this.lNbTickets.Text = "Nombre de tickets";
            // 
            // tbNbTickets
            // 
            this.tbNbTickets.Location = new System.Drawing.Point(16, 146);
            this.tbNbTickets.Maximum = 1000;
            this.tbNbTickets.Minimum = 200;
            this.tbNbTickets.Name = "tbNbTickets";
            this.tbNbTickets.Size = new System.Drawing.Size(466, 69);
            this.tbNbTickets.TabIndex = 2;
            this.tbNbTickets.TickFrequency = 100;
            this.tbNbTickets.Value = 300;
            // 
            // bSimuler
            // 
            this.bSimuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSimuler.Location = new System.Drawing.Point(20, 231);
            this.bSimuler.Name = "bSimuler";
            this.bSimuler.Size = new System.Drawing.Size(458, 85);
            this.bSimuler.TabIndex = 4;
            this.bSimuler.Text = "Simuler";
            this.bSimuler.UseVisualStyleBackColor = true;
            this.bSimuler.Click += new System.EventHandler(this.bSimuler_Click);
            // 
            // lbResultats
            // 
            this.lbResultats.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultats.FormattingEnabled = true;
            this.lbResultats.ItemHeight = 26;
            this.lbResultats.Location = new System.Drawing.Point(20, 333);
            this.lbResultats.Name = "lbResultats";
            this.lbResultats.Size = new System.Drawing.Size(522, 264);
            this.lbResultats.TabIndex = 5;
            // 
            // EcranVenteTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 682);
            this.Controls.Add(this.lbResultats);
            this.Controls.Add(this.bSimuler);
            this.Controls.Add(this.lNbTickets);
            this.Controls.Add(this.tbNbTickets);
            this.Controls.Add(this.lNbVendeur);
            this.Controls.Add(this.tbNbVendeurs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranVenteTickets";
            this.Text = "FicVenteTickets";
            ((System.ComponentModel.ISupportInitialize)(this.tbNbVendeurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNbTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbNbVendeurs;
        private System.Windows.Forms.Label lNbVendeur;
        private System.Windows.Forms.Label lNbTickets;
        private System.Windows.Forms.TrackBar tbNbTickets;
        private System.Windows.Forms.Button bSimuler;
        private System.Windows.Forms.ListBox lbResultats;
    }
}