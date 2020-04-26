namespace ISET_2020_Découverte_WinForm
{
    partial class Ecranpropos
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
            this.plabel1 = new System.Windows.Forms.Label();
            this.plabel3 = new System.Windows.Forms.Label();
            this.plabel4 = new System.Windows.Forms.Label();
            this.plabel2 = new System.Windows.Forms.Label();
            this.pimage = new System.Windows.Forms.PictureBox();
            this.btnConfirmer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pimage)).BeginInit();
            this.SuspendLayout();
            // 
            // plabel1
            // 
            this.plabel1.AutoSize = true;
            this.plabel1.Location = new System.Drawing.Point(179, 34);
            this.plabel1.Name = "plabel1";
            this.plabel1.Size = new System.Drawing.Size(89, 20);
            this.plabel1.TabIndex = 0;
            this.plabel1.Text = "Version 1.0";
            // 
            // plabel3
            // 
            this.plabel3.AutoSize = true;
            this.plabel3.Location = new System.Drawing.Point(12, 224);
            this.plabel3.Name = "plabel3";
            this.plabel3.Size = new System.Drawing.Size(162, 20);
            this.plabel3.TabIndex = 1;
            this.plabel3.Text = "Logiciel sous garantie";
            // 
            // plabel4
            // 
            this.plabel4.AutoSize = true;
            this.plabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plabel4.Location = new System.Drawing.Point(80, 264);
            this.plabel4.Name = "plabel4";
            this.plabel4.Size = new System.Drawing.Size(136, 20);
            this.plabel4.TabIndex = 2;
            this.plabel4.Text = "DO NOT STEAL";
            this.plabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // plabel2
            // 
            this.plabel2.Location = new System.Drawing.Point(12, 152);
            this.plabel2.Name = "plabel2";
            this.plabel2.Size = new System.Drawing.Size(304, 46);
            this.plabel2.TabIndex = 3;
            this.plabel2.Text = "Pour plus d\'information demandé au programmeur";
            // 
            // pimage
            // 
            this.pimage.Image = global::ISET_2020_Découverte_WinForm.Properties.Resources._46519517_515989682215356_2729004365699350528_n;
            this.pimage.InitialImage = global::ISET_2020_Découverte_WinForm.Properties.Resources._46519517_515989682215356_2729004365699350528_n;
            this.pimage.Location = new System.Drawing.Point(24, 34);
            this.pimage.Name = "pimage";
            this.pimage.Size = new System.Drawing.Size(96, 82);
            this.pimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pimage.TabIndex = 4;
            this.pimage.TabStop = false;
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(97, 300);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(119, 32);
            this.btnConfirmer.TabIndex = 5;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // Ecranpropos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 344);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.pimage);
            this.Controls.Add(this.plabel2);
            this.Controls.Add(this.plabel4);
            this.Controls.Add(this.plabel3);
            this.Controls.Add(this.plabel1);
            this.Name = "Ecranpropos";
            this.Text = "Apropos";
            ((System.ComponentModel.ISupportInitialize)(this.pimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label plabel1;
        private System.Windows.Forms.Label plabel3;
        private System.Windows.Forms.Label plabel4;
        private System.Windows.Forms.Label plabel2;
        private System.Windows.Forms.PictureBox pimage;
        private System.Windows.Forms.Button btnConfirmer;
    }
}