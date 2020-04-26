using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISET_2020_Découverte_WinForm
{
    public partial class EcranAcceuil : Form
    {
      private  int i = 2;

        public EcranAcceuil()
        {
            InitializeComponent();
        }

        private void btnPousser_Click(object sender, EventArgs e)
        {
            if (i%2 == 0)

            {
                label1.Text = "Curieux !!!";
                pbDemarrage.Image = ISET_2020_Découverte_WinForm.Properties.Resources.HEL;
            }
             if( i%2 != 0)

            {
                label1.Text = "Découverte de C#";
                pbDemarrage.Image = ISET_2020_Découverte_WinForm.Properties.Resources._46519517_515989682215356_2729004365699350528_n;
    
            }

            i++;

            /* pbDemarrage.Visible = true;
               pbCurieux.Visible = true;
               rajout d'une picturebox
            */
        }

        private void EcranAcceuil_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*if (MessageBox.Show(this, "Souhaitez-vous quitter", "Votre Souhait", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 

            e.Cancel = false;

            else

            e.Cancel = true;
            */
        }

        private void btnEntrer_Click(object sender, EventArgs e)
        {
            /*
            EcranPrincipal fen = new EcranPrincipal(this);
            fen.Show();
            Hide();
            */
            Close();
        }
    }
}
