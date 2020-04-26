namespace ISET_2020_Découverte_WinForm
{
    partial class EcranSerialisation
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
            this.bClassePreparer = new System.Windows.Forms.Button();
            this.bHardSerialiser = new System.Windows.Forms.Button();
            this.bSerialiserVolee = new System.Windows.Forms.Button();
            this.bSerialiserUniversellement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bClassePreparer
            // 
            this.bClassePreparer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClassePreparer.Location = new System.Drawing.Point(12, 12);
            this.bClassePreparer.Name = "bClassePreparer";
            this.bClassePreparer.Size = new System.Drawing.Size(602, 107);
            this.bClassePreparer.TabIndex = 0;
            this.bClassePreparer.Text = "Sérialiser classe préparée";
            this.bClassePreparer.UseVisualStyleBackColor = true;
            this.bClassePreparer.Click += new System.EventHandler(this.bClassePreparer_Click);
            // 
            // bHardSerialiser
            // 
            this.bHardSerialiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bHardSerialiser.Location = new System.Drawing.Point(12, 125);
            this.bHardSerialiser.Name = "bHardSerialiser";
            this.bHardSerialiser.Size = new System.Drawing.Size(602, 107);
            this.bHardSerialiser.TabIndex = 1;
            this.bHardSerialiser.Text = "Hard Sérialiser";
            this.bHardSerialiser.UseVisualStyleBackColor = true;
            this.bHardSerialiser.Click += new System.EventHandler(this.bHardSerialiser_Click);
            // 
            // bSerialiserVolee
            // 
            this.bSerialiserVolee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSerialiserVolee.Location = new System.Drawing.Point(12, 238);
            this.bSerialiserVolee.Name = "bSerialiserVolee";
            this.bSerialiserVolee.Size = new System.Drawing.Size(602, 107);
            this.bSerialiserVolee.TabIndex = 2;
            this.bSerialiserVolee.Text = "Sérialiser à la volée";
            this.bSerialiserVolee.UseVisualStyleBackColor = true;
            this.bSerialiserVolee.Click += new System.EventHandler(this.bSerialiserVolee_Click);
            // 
            // bSerialiserUniversellement
            // 
            this.bSerialiserUniversellement.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSerialiserUniversellement.Location = new System.Drawing.Point(12, 351);
            this.bSerialiserUniversellement.Name = "bSerialiserUniversellement";
            this.bSerialiserUniversellement.Size = new System.Drawing.Size(602, 107);
            this.bSerialiserUniversellement.TabIndex = 3;
            this.bSerialiserUniversellement.Text = "Sérialiser universellement";
            this.bSerialiserUniversellement.UseVisualStyleBackColor = true;
            this.bSerialiserUniversellement.Click += new System.EventHandler(this.bSerialiserUniversellement_Click);
            // 
            // EcranSerialisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 467);
            this.Controls.Add(this.bSerialiserUniversellement);
            this.Controls.Add(this.bSerialiserVolee);
            this.Controls.Add(this.bHardSerialiser);
            this.Controls.Add(this.bClassePreparer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranSerialisation";
            this.Text = "Serialisation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bClassePreparer;
        private System.Windows.Forms.Button bHardSerialiser;
        private System.Windows.Forms.Button bSerialiserVolee;
        private System.Windows.Forms.Button bSerialiserUniversellement;
    }
}