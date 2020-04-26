namespace ISET_2020_Découverte_WinForm
{
    partial class EcranSpirographe2
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
            this.pbGraphe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraphe)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGraphe
            // 
            this.pbGraphe.Location = new System.Drawing.Point(1, 21);
            this.pbGraphe.Name = "pbGraphe";
            this.pbGraphe.Size = new System.Drawing.Size(800, 400);
            this.pbGraphe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbGraphe.TabIndex = 0;
            this.pbGraphe.TabStop = false;
            this.pbGraphe.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGraphe_Paint);
            // 
            // EcranSpirographe2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbGraphe);
            this.Name = "EcranSpirographe2";
            this.Text = "FicSpirographe2";
            this.Load += new System.EventHandler(this.EcranSpirographe2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGraphe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGraphe;
    }
}