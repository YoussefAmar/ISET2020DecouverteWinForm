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
    public partial class EcranPrincipal : Form
    {
        // EcranAcceuil FenMaman;

        /*  public EcranPrincipal(EcranAcceuil fen)
          {
              InitializeComponent();
              FenMaman = fen;
          }*/

        public EcranPrincipal()
        {
            InitializeComponent();
        }
         
        private void EcranPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
           // FenMaman.Close();
        }

        private void NonImplemente(object sender, EventArgs e)
        {
            MessageBox.Show("Fonctionnalité non implémentée");
        }

        private void mpPropos_Click(object sender, EventArgs e)
        {
            Ecranpropos fen = new Ecranpropos(this);

            fen.Show();
        }

        private void mcProgression_Click(object sender, EventArgs e)
        {
            EcranProgression fen = new EcranProgression(this);

            fen.ShowDialog();
        }

        private void mcListe_Click(object sender, EventArgs e)
        {
            EcranListe f = new EcranListe();
            f.ShowDialog();
        }

        private void mcEditeur_Click(object sender, EventArgs e)
        {
            EcranEditeur f = new EcranEditeur();
            f.ShowDialog();
        }

        private void maSpirographe_Click(object sender, EventArgs e)
        {
            EcranSpirographe f = new EcranSpirographe();
            f.ShowDialog();
        }

        private void maHorloge_Click(object sender, EventArgs e)
        {
            EcranHorloge f = new EcranHorloge();
            f.ShowDialog();
        }

        private void mcClavierSouris_Click(object sender, EventArgs e)
        {
            EcranClavierSouris f = new EcranClavierSouris();
            f.ShowDialog();
        }

        private void spirographe2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranSpirographe2 f = new EcranSpirographe2();
            f.ShowDialog();
        }

        private void maNavigateurFichier_Click(object sender, EventArgs e)
        {
            EcranNavigateur f = new EcranNavigateur();
            f.ShowDialog();
        }

        private void boutonColore_Click(object sender, EventArgs e)
        {
            MessageBox.Show(("Vous avez cliqué sur la couleur"));
        }

        private void malectureGPS_Click(object sender, EventArgs e)
        {
            EcranLectureGPS f = new EcranLectureGPS();
            f.ShowDialog();
        }

        private void maProcessusEtThreads_Click(object sender, EventArgs e)
        {
            EcranProcessusThreads f = new EcranProcessusThreads();
                f.ShowDialog();
        }

        private void maBDBasique_Click(object sender, EventArgs e)
        {
            EcranBDBasique f = new EcranBDBasique();
            f.ShowDialog();
        }

        private void maBDDataset_Click(object sender, EventArgs e)
        {
            EcranBDDataset f = new EcranBDDataset();
            f.ShowDialog();
        }

        private void maBDCouche_Click(object sender, EventArgs e)
        {
            EcranBDCouche f = new EcranBDCouche();
            f.ShowDialog();
        }

        private void dinerPhilo_Click(object sender, EventArgs e)
        {
            EcranPhilosophes f = new EcranPhilosophes();
            f.ShowDialog();
        }

        private void maSerialisation_Click(object sender, EventArgs e)
        {
            EcranSerialisation f = new EcranSerialisation();
            f.ShowDialog();
        }

        private void maIntegration_Click(object sender, EventArgs e)
        {
            EcranIntegration f = new EcranIntegration();
            f.ShowDialog();
        }
    }
}
