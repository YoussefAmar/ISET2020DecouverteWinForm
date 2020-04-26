namespace ISET_2020_Découverte_WinForm
{
    partial class EcranHorloge
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
            this.components = new System.ComponentModel.Container();
            this.tHorloge = new System.Windows.Forms.Timer(this.components);
            this.pbHorloge = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHorloge)).BeginInit();
            this.SuspendLayout();
            // 
            // tHorloge
            // 
            this.tHorloge.Interval = 1000;
            this.tHorloge.Tick += new System.EventHandler(this.tHorloge_Tick);
            // 
            // pbHorloge
            // 
            this.pbHorloge.Location = new System.Drawing.Point(0, 0);
            this.pbHorloge.Name = "pbHorloge";
            this.pbHorloge.Size = new System.Drawing.Size(777, 444);
            this.pbHorloge.TabIndex = 0;
            this.pbHorloge.TabStop = false;
            this.pbHorloge.Paint += new System.Windows.Forms.PaintEventHandler(this.pbHorloge_Paint);
            // 
            // EcranHorloge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.pbHorloge);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranHorloge";
            this.Text = "FicHorloge";
            this.Load += new System.EventHandler(this.EcranHorloge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHorloge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tHorloge;
        private System.Windows.Forms.PictureBox pbHorloge;
    }
}