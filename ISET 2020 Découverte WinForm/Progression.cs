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
    public partial class EcranProgression : Form
    {
        EcranPrincipal fenFiston;
        public EcranProgression(EcranPrincipal fen)
        {
            InitializeComponent();

            fenFiston = fen;
        }

        private void btnPartir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExecuter_Click(object sender, EventArgs e)
        {
            int i, j, pas,nbfic;

            Cursor Curseur = Cursor;

            Cursor = Cursors.WaitCursor;
            Random delai = new Random();
            btnExecuter.Enabled = btnQuitter.Enabled = false;

            nbfic = 5 + delai.Next(11);
            pbPrincipal.Maximum = nbfic;
            pbPrincipal.Value = 0;

            for(i=0; i<nbfic; i++)
            {
                pbSecondaire.Value = 0;

                pas = 5 + 9 * delai.Next(20);

                for(j=0; j< 20; j++)
                {
                    pbSecondaire.Value = (1 + j) * 5;
                    System.Threading.Thread.Sleep(pas);
                }

                pbPrincipal.Value++;
            }

            Cursor = Curseur;

            btnQuitter.Enabled = true;
        }
    }
}
