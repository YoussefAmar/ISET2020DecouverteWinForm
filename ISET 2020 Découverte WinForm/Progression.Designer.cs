namespace ISET_2020_Découverte_WinForm
{
    partial class EcranProgression
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
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.pbPrincipal = new System.Windows.Forms.ProgressBar();
            this.lblSecondaire = new System.Windows.Forms.Label();
            this.pbSecondaire = new System.Windows.Forms.ProgressBar();
            this.btnExecuter = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.ForeColor = System.Drawing.Color.Brown;
            this.lblPrincipal.Location = new System.Drawing.Point(40, 9);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(193, 32);
            this.lblPrincipal.TabIndex = 0;
            this.lblPrincipal.Text = "Copie (global)";
            // 
            // pbPrincipal
            // 
            this.pbPrincipal.Location = new System.Drawing.Point(46, 61);
            this.pbPrincipal.Name = "pbPrincipal";
            this.pbPrincipal.Size = new System.Drawing.Size(310, 59);
            this.pbPrincipal.Step = 1;
            this.pbPrincipal.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbPrincipal.TabIndex = 1;
            // 
            // lblSecondaire
            // 
            this.lblSecondaire.AutoSize = true;
            this.lblSecondaire.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSecondaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondaire.ForeColor = System.Drawing.Color.Brown;
            this.lblSecondaire.Location = new System.Drawing.Point(40, 132);
            this.lblSecondaire.Name = "lblSecondaire";
            this.lblSecondaire.Size = new System.Drawing.Size(192, 32);
            this.lblSecondaire.TabIndex = 2;
            this.lblSecondaire.Text = "Copie (fichier)";
            // 
            // pbSecondaire
            // 
            this.pbSecondaire.Location = new System.Drawing.Point(46, 182);
            this.pbSecondaire.Name = "pbSecondaire";
            this.pbSecondaire.Size = new System.Drawing.Size(310, 59);
            this.pbSecondaire.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbSecondaire.TabIndex = 3;
            // 
            // btnExecuter
            // 
            this.btnExecuter.ForeColor = System.Drawing.Color.Blue;
            this.btnExecuter.Location = new System.Drawing.Point(25, 291);
            this.btnExecuter.Name = "btnExecuter";
            this.btnExecuter.Size = new System.Drawing.Size(138, 41);
            this.btnExecuter.TabIndex = 4;
            this.btnExecuter.Text = "Executer";
            this.btnExecuter.UseVisualStyleBackColor = true;
            this.btnExecuter.Click += new System.EventHandler(this.btnExecuter_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnQuitter.Location = new System.Drawing.Point(198, 291);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(138, 41);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnPartir_Click);
            // 
            // EcranProgression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 344);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnExecuter);
            this.Controls.Add(this.pbSecondaire);
            this.Controls.Add(this.lblSecondaire);
            this.Controls.Add(this.pbPrincipal);
            this.Controls.Add(this.lblPrincipal);
            this.Name = "EcranProgression";
            this.Text = "Barre de progression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.ProgressBar pbPrincipal;
        private System.Windows.Forms.Label lblSecondaire;
        private System.Windows.Forms.ProgressBar pbSecondaire;
        private System.Windows.Forms.Button btnExecuter;
        private System.Windows.Forms.Button btnQuitter;
    }
}