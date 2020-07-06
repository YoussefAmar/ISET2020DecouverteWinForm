namespace ISET_2020_Découverte_WinForm
{
    partial class EcranExpressionReguliere
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
            this.lExpressionReguliere = new System.Windows.Forms.Label();
            this.tbExpressionReguliere = new System.Windows.Forms.TextBox();
            this.cbIsValide = new System.Windows.Forms.CheckBox();
            this.cbIsCorrespondance = new System.Windows.Forms.CheckBox();
            this.cbIsRespectCasse = new System.Windows.Forms.CheckBox();
            this.cbRemplacer = new System.Windows.Forms.CheckBox();
            this.cbSeparer = new System.Windows.Forms.CheckBox();
            this.tbRemplacement = new System.Windows.Forms.TextBox();
            this.lRemplacement = new System.Windows.Forms.Label();
            this.lATraiter = new System.Windows.Forms.Label();
            this.rtbATraiter = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lExpressionReguliere
            // 
            this.lExpressionReguliere.AutoSize = true;
            this.lExpressionReguliere.Location = new System.Drawing.Point(13, 13);
            this.lExpressionReguliere.Name = "lExpressionReguliere";
            this.lExpressionReguliere.Size = new System.Drawing.Size(152, 20);
            this.lExpressionReguliere.TabIndex = 0;
            this.lExpressionReguliere.Text = "Expression régulière";
            // 
            // tbExpressionReguliere
            // 
            this.tbExpressionReguliere.Location = new System.Drawing.Point(17, 37);
            this.tbExpressionReguliere.Name = "tbExpressionReguliere";
            this.tbExpressionReguliere.Size = new System.Drawing.Size(1282, 26);
            this.tbExpressionReguliere.TabIndex = 1;
            this.tbExpressionReguliere.Text = "\\bc[a-z]*-?[a-z]*\\b";
            this.tbExpressionReguliere.TextChanged += new System.EventHandler(this.tbExpressionReguliere_TextChanged);
            // 
            // cbIsValide
            // 
            this.cbIsValide.AutoSize = true;
            this.cbIsValide.Enabled = false;
            this.cbIsValide.Location = new System.Drawing.Point(17, 87);
            this.cbIsValide.Name = "cbIsValide";
            this.cbIsValide.Size = new System.Drawing.Size(87, 24);
            this.cbIsValide.TabIndex = 2;
            this.cbIsValide.Text = "Validité";
            this.cbIsValide.UseVisualStyleBackColor = true;
            // 
            // cbIsCorrespondance
            // 
            this.cbIsCorrespondance.AutoSize = true;
            this.cbIsCorrespondance.Enabled = false;
            this.cbIsCorrespondance.Location = new System.Drawing.Point(143, 87);
            this.cbIsCorrespondance.Name = "cbIsCorrespondance";
            this.cbIsCorrespondance.Size = new System.Drawing.Size(153, 24);
            this.cbIsCorrespondance.TabIndex = 3;
            this.cbIsCorrespondance.Text = "Correspondance";
            this.cbIsCorrespondance.UseVisualStyleBackColor = true;
            // 
            // cbIsRespectCasse
            // 
            this.cbIsRespectCasse.AutoSize = true;
            this.cbIsRespectCasse.Location = new System.Drawing.Point(342, 86);
            this.cbIsRespectCasse.Name = "cbIsRespectCasse";
            this.cbIsRespectCasse.Size = new System.Drawing.Size(179, 24);
            this.cbIsRespectCasse.TabIndex = 4;
            this.cbIsRespectCasse.Text = "Respect de la casse";
            this.cbIsRespectCasse.UseVisualStyleBackColor = true;
            this.cbIsRespectCasse.CheckedChanged += new System.EventHandler(this.cbIsRespectCasse_CheckedChanged);
            // 
            // cbRemplacer
            // 
            this.cbRemplacer.AutoSize = true;
            this.cbRemplacer.Location = new System.Drawing.Point(566, 86);
            this.cbRemplacer.Name = "cbRemplacer";
            this.cbRemplacer.Size = new System.Drawing.Size(112, 24);
            this.cbRemplacer.TabIndex = 5;
            this.cbRemplacer.Text = "Remplacer";
            this.cbRemplacer.UseVisualStyleBackColor = true;
            this.cbRemplacer.CheckedChanged += new System.EventHandler(this.cbRemplacer_CheckedChanged);
            // 
            // cbSeparer
            // 
            this.cbSeparer.AutoSize = true;
            this.cbSeparer.Location = new System.Drawing.Point(727, 86);
            this.cbSeparer.Name = "cbSeparer";
            this.cbSeparer.Size = new System.Drawing.Size(92, 24);
            this.cbSeparer.TabIndex = 6;
            this.cbSeparer.Text = "Séparer";
            this.cbSeparer.UseVisualStyleBackColor = true;
            this.cbSeparer.CheckedChanged += new System.EventHandler(this.cbSeparer_CheckedChanged);
            // 
            // tbRemplacement
            // 
            this.tbRemplacement.Location = new System.Drawing.Point(16, 151);
            this.tbRemplacement.Name = "tbRemplacement";
            this.tbRemplacement.Size = new System.Drawing.Size(1282, 26);
            this.tbRemplacement.TabIndex = 8;
            // 
            // lRemplacement
            // 
            this.lRemplacement.AutoSize = true;
            this.lRemplacement.Location = new System.Drawing.Point(12, 127);
            this.lRemplacement.Name = "lRemplacement";
            this.lRemplacement.Size = new System.Drawing.Size(175, 20);
            this.lRemplacement.TabIndex = 7;
            this.lRemplacement.Text = "Texte de remplacement";
            // 
            // lATraiter
            // 
            this.lATraiter.AutoSize = true;
            this.lATraiter.Location = new System.Drawing.Point(13, 191);
            this.lATraiter.Name = "lATraiter";
            this.lATraiter.Size = new System.Drawing.Size(106, 20);
            this.lATraiter.TabIndex = 9;
            this.lATraiter.Text = "Texte à traiter";
            // 
            // rtbATraiter
            // 
            this.rtbATraiter.Location = new System.Drawing.Point(16, 215);
            this.rtbATraiter.Name = "rtbATraiter";
            this.rtbATraiter.Size = new System.Drawing.Size(1282, 365);
            this.rtbATraiter.TabIndex = 10;
            this.rtbATraiter.Text = "Considère considère Client client Cela cela";
            this.rtbATraiter.Leave += new System.EventHandler(this.rtbATraiter_Leave);
            // 
            // EcranExpressionReguliere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 592);
            this.Controls.Add(this.rtbATraiter);
            this.Controls.Add(this.lATraiter);
            this.Controls.Add(this.tbRemplacement);
            this.Controls.Add(this.lRemplacement);
            this.Controls.Add(this.cbSeparer);
            this.Controls.Add(this.cbRemplacer);
            this.Controls.Add(this.cbIsRespectCasse);
            this.Controls.Add(this.cbIsCorrespondance);
            this.Controls.Add(this.cbIsValide);
            this.Controls.Add(this.tbExpressionReguliere);
            this.Controls.Add(this.lExpressionReguliere);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranExpressionReguliere";
            this.Text = "FicExpressionReguliere";
            this.Load += new System.EventHandler(this.EcranExpressionReguliere_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lExpressionReguliere;
        private System.Windows.Forms.TextBox tbExpressionReguliere;
        private System.Windows.Forms.CheckBox cbIsValide;
        private System.Windows.Forms.CheckBox cbIsCorrespondance;
        private System.Windows.Forms.CheckBox cbIsRespectCasse;
        private System.Windows.Forms.CheckBox cbRemplacer;
        private System.Windows.Forms.CheckBox cbSeparer;
        private System.Windows.Forms.TextBox tbRemplacement;
        private System.Windows.Forms.Label lRemplacement;
        private System.Windows.Forms.Label lATraiter;
        private System.Windows.Forms.RichTextBox rtbATraiter;
    }
}