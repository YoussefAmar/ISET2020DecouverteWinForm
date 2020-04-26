namespace ISET_2020_Découverte_WinForm
{
    partial class EcranBDBasique
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
            this.lbConsole = new System.Windows.Forms.ListBox();
            this.btnLecture = new System.Windows.Forms.Button();
            this.btnCalcul = new System.Windows.Forms.Button();
            this.btnInsertion = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbConsole
            // 
            this.lbConsole.FormattingEnabled = true;
            this.lbConsole.ItemHeight = 20;
            this.lbConsole.Location = new System.Drawing.Point(12, 12);
            this.lbConsole.Name = "lbConsole";
            this.lbConsole.Size = new System.Drawing.Size(320, 424);
            this.lbConsole.TabIndex = 0;
            // 
            // btnLecture
            // 
            this.btnLecture.Location = new System.Drawing.Point(660, 12);
            this.btnLecture.Name = "btnLecture";
            this.btnLecture.Size = new System.Drawing.Size(106, 41);
            this.btnLecture.TabIndex = 1;
            this.btnLecture.Text = "Lecture";
            this.btnLecture.UseVisualStyleBackColor = true;
            this.btnLecture.Click += new System.EventHandler(this.btnLecture_Click);
            // 
            // btnCalcul
            // 
            this.btnCalcul.Location = new System.Drawing.Point(660, 85);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(106, 41);
            this.btnCalcul.TabIndex = 2;
            this.btnCalcul.Text = "Calcul";
            this.btnCalcul.UseVisualStyleBackColor = true;
            this.btnCalcul.Click += new System.EventHandler(this.btnCalcul_Click);
            // 
            // btnInsertion
            // 
            this.btnInsertion.Location = new System.Drawing.Point(660, 395);
            this.btnInsertion.Name = "btnInsertion";
            this.btnInsertion.Size = new System.Drawing.Size(106, 41);
            this.btnInsertion.TabIndex = 3;
            this.btnInsertion.Text = "Insertion";
            this.btnInsertion.UseVisualStyleBackColor = true;
            this.btnInsertion.Click += new System.EventHandler(this.btnInsertion_Click);
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(660, 301);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(100, 26);
            this.tbNom.TabIndex = 4;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(660, 345);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(100, 26);
            this.tbPrenom.TabIndex = 5;
            // 
            // EcranBDBasique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.btnInsertion);
            this.Controls.Add(this.btnCalcul);
            this.Controls.Add(this.btnLecture);
            this.Controls.Add(this.lbConsole);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranBDBasique";
            this.Text = "Accès de base à une BD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbConsole;
        private System.Windows.Forms.Button btnLecture;
        private System.Windows.Forms.Button btnCalcul;
        private System.Windows.Forms.Button btnInsertion;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
    }
}