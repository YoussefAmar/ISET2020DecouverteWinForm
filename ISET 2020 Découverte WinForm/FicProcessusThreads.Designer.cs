namespace ISET_2020_Découverte_WinForm
{
    partial class EcranProcessusThreads
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
            this.btnProcessus1 = new System.Windows.Forms.Button();
            this.btnProcessus2 = new System.Windows.Forms.Button();
            this.btnProcessus3 = new System.Windows.Forms.Button();
            this.btnThread1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbConsole
            // 
            this.lbConsole.FormattingEnabled = true;
            this.lbConsole.ItemHeight = 20;
            this.lbConsole.Location = new System.Drawing.Point(12, 12);
            this.lbConsole.Name = "lbConsole";
            this.lbConsole.Size = new System.Drawing.Size(776, 224);
            this.lbConsole.TabIndex = 0;
            // 
            // btnProcessus1
            // 
            this.btnProcessus1.Location = new System.Drawing.Point(12, 268);
            this.btnProcessus1.Name = "btnProcessus1";
            this.btnProcessus1.Size = new System.Drawing.Size(104, 55);
            this.btnProcessus1.TabIndex = 1;
            this.btnProcessus1.Text = "Processus version 1";
            this.btnProcessus1.UseVisualStyleBackColor = true;
            this.btnProcessus1.Click += new System.EventHandler(this.btnProcessus1_Click);
            // 
            // btnProcessus2
            // 
            this.btnProcessus2.Location = new System.Drawing.Point(185, 268);
            this.btnProcessus2.Name = "btnProcessus2";
            this.btnProcessus2.Size = new System.Drawing.Size(104, 55);
            this.btnProcessus2.TabIndex = 2;
            this.btnProcessus2.Text = "Processus version 2";
            this.btnProcessus2.UseVisualStyleBackColor = true;
            this.btnProcessus2.Click += new System.EventHandler(this.btnProcessus2_Click);
            // 
            // btnProcessus3
            // 
            this.btnProcessus3.Location = new System.Drawing.Point(376, 268);
            this.btnProcessus3.Name = "btnProcessus3";
            this.btnProcessus3.Size = new System.Drawing.Size(104, 55);
            this.btnProcessus3.TabIndex = 3;
            this.btnProcessus3.Text = "Processus version 3";
            this.btnProcessus3.UseVisualStyleBackColor = true;
            this.btnProcessus3.Click += new System.EventHandler(this.btnProcessus3_Click);
            // 
            // btnThread1
            // 
            this.btnThread1.Location = new System.Drawing.Point(12, 349);
            this.btnThread1.Name = "btnThread1";
            this.btnThread1.Size = new System.Drawing.Size(104, 55);
            this.btnThread1.TabIndex = 4;
            this.btnThread1.Text = "Thread version 1";
            this.btnThread1.UseVisualStyleBackColor = true;
            this.btnThread1.Click += new System.EventHandler(this.btnThread1_Click);
            // 
            // EcranProcessusThreads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThread1);
            this.Controls.Add(this.btnProcessus3);
            this.Controls.Add(this.btnProcessus2);
            this.Controls.Add(this.btnProcessus1);
            this.Controls.Add(this.lbConsole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranProcessusThreads";
            this.Text = "FicProcessusThreads";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EcranProcessusThreads_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbConsole;
        private System.Windows.Forms.Button btnProcessus1;
        private System.Windows.Forms.Button btnProcessus2;
        private System.Windows.Forms.Button btnProcessus3;
        private System.Windows.Forms.Button btnThread1;
    }
}