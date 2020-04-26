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
    public partial class EcranClavierSouris : Form
    {
        private int nbGauche, nbDroit;

        public EcranClavierSouris()
        {
            InitializeComponent();
        }

        private void btnRAZ_Click(object sender, EventArgs e)
        {
            lbClavier.Items.Clear();
            nbGauche = nbDroit = 0;
            RemplirSouris();
        }

        private void EcranClavierSouris_Load(object sender, EventArgs e)
        {
            btnRAZ_Click(null, null);
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pZoneSouris_MouseMove(object sender, MouseEventArgs e)
        {
           tbX.Text = e.X.ToString();
           tbY.Text = e.Y.ToString();
        }

        private void EcranClavierSouris_MouseDown(object sender, MouseEventArgs e)
        {
            switch(e.Button)
            {
                case MouseButtons.Left :
                    nbGauche++;
                    break;

                case MouseButtons.Right:
                    nbDroit++;
                    break;
            }
            RemplirSouris();
        }

        private void tbGauche_KeyDown(object sender, KeyEventArgs e)
        {
            lbClavier.Items.Insert(0, "KeyDown : Code : " + e.KeyCode + ", Valeur : " + e.KeyValue);
        }

        private void tbGauche_KeyUp(object sender, KeyEventArgs e)
        {
            lbClavier.Items.Insert(0, "KeyUp : Code : " + e.KeyCode + ", Valeur : " + e.KeyValue);
        }

        private void tbGauche_KeyPress(object sender, KeyPressEventArgs e)
        {
            lbClavier.Items.Insert(0, "KeyPress : Caractère : " + e.KeyChar);
        }

        private void RemplirSouris()
        {
            tbGauche.Text = nbGauche.ToString();
            tbDroite.Text = nbDroit.ToString();
        }

    }
}
