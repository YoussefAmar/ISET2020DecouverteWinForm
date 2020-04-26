namespace ISET_2020_Découverte_WinForm
{
    partial class EcranLectureGPS
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
            this.cbPortCOM = new System.Windows.Forms.ComboBox();
            this.btnConnecter = new System.Windows.Forms.Button();
            this.tbLongitude = new System.Windows.Forms.TextBox();
            this.tbLatitude = new System.Windows.Forms.TextBox();
            this.btnLecture = new System.Windows.Forms.Button();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.spGPS = new System.IO.Ports.SerialPort(this.components);
            this.tChrono = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cbPortCOM
            // 
            this.cbPortCOM.FormattingEnabled = true;
            this.cbPortCOM.Items.AddRange(new object[] {
            "COM 1",
            "COM 2",
            "COM 3",
            "COM 4",
            "COM 5",
            "COM 6"});
            this.cbPortCOM.Location = new System.Drawing.Point(24, 12);
            this.cbPortCOM.Name = "cbPortCOM";
            this.cbPortCOM.Size = new System.Drawing.Size(329, 28);
            this.cbPortCOM.TabIndex = 0;
            // 
            // btnConnecter
            // 
            this.btnConnecter.Location = new System.Drawing.Point(24, 58);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.Size = new System.Drawing.Size(329, 61);
            this.btnConnecter.TabIndex = 1;
            this.btnConnecter.Text = "Connecter";
            this.btnConnecter.UseVisualStyleBackColor = true;
            this.btnConnecter.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbLongitude
            // 
            this.tbLongitude.Location = new System.Drawing.Point(24, 136);
            this.tbLongitude.Name = "tbLongitude";
            this.tbLongitude.Size = new System.Drawing.Size(329, 26);
            this.tbLongitude.TabIndex = 2;
            // 
            // tbLatitude
            // 
            this.tbLatitude.Location = new System.Drawing.Point(24, 181);
            this.tbLatitude.Name = "tbLatitude";
            this.tbLatitude.Size = new System.Drawing.Size(329, 26);
            this.tbLatitude.TabIndex = 3;
            // 
            // btnLecture
            // 
            this.btnLecture.Location = new System.Drawing.Point(24, 225);
            this.btnLecture.Name = "btnLecture";
            this.btnLecture.Size = new System.Drawing.Size(329, 61);
            this.btnLecture.TabIndex = 4;
            this.btnLecture.Text = "Lecture";
            this.btnLecture.UseVisualStyleBackColor = true;
            this.btnLecture.Click += new System.EventHandler(this.btnLecture_Click);
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(24, 307);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(329, 61);
            this.btnAfficher.TabIndex = 5;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // tChrono
            // 
            this.tChrono.Tick += new System.EventHandler(this.tChrono_Tick);
            // 
            // EcranLectureGPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 395);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.btnLecture);
            this.Controls.Add(this.tbLatitude);
            this.Controls.Add(this.tbLongitude);
            this.Controls.Add(this.btnConnecter);
            this.Controls.Add(this.cbPortCOM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranLectureGPS";
            this.Text = "FicLectureGPS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPortCOM;
        private System.Windows.Forms.Button btnConnecter;
        private System.Windows.Forms.TextBox tbLongitude;
        private System.Windows.Forms.TextBox tbLatitude;
        private System.Windows.Forms.Button btnLecture;
        private System.Windows.Forms.Button btnAfficher;
        private System.IO.Ports.SerialPort spGPS;
        private System.Windows.Forms.Timer tChrono;
    }
}