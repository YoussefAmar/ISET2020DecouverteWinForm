using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISET2018_CouClasses;
using ISET2018_CouGestion;


namespace ISET_2020_Découverte_WinForm
{
    public partial class EcranBDCouche : Form
    {
        private DataTable dtPersonne;
        private BindingSource bsPersonne;
        private string sConnexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= C:\Users\banon\OneDrive\Documents\IS2\Progra-event\ISET2020DecouverteWinForm\ISET 2020 Découverte WinForm\BD_Perso.mdf;Integrated Security=True;Connect Timeout=30"; 
        public EcranBDCouche()
        {
            InitializeComponent();
        }

        private void Activer(bool lPrincipal)
        {
                dgvPersonne.Enabled = lPrincipal;
                tbID.Enabled = tbPre.Enabled = tbNom.Enabled = !lPrincipal;
                dtpNai.Enabled = !lPrincipal;
                btnConfirmer.Enabled = btnAnnuler.Enabled = !lPrincipal;
                btnEditer.Enabled = btnAjouter.Enabled = btnSupprimer.Enabled = lPrincipal;          
        }

        private void RemplirDGV()
        {
            dtPersonne = new DataTable();
            dtPersonne.Columns.Add(new DataColumn("ID",System.Type.GetType("System.Int32")));
            dtPersonne.Columns.Add(new DataColumn("Afficher"));

           List <C_Personne> lTmp =  new G_Personne(sConnexion).Lire("Nom");

            foreach(C_Personne p in lTmp)
                dtPersonne.Rows.Add(p.ID, p.PRE + " " + p.NOM);


            //Lie les données à la vue
            bsPersonne = new BindingSource { DataSource = dtPersonne };
            dgvPersonne.DataSource = bsPersonne;
        }

        private void EcranBDCouche_Load(object sender, EventArgs e)
        {
            RemplirDGV();
            if (dgvPersonne.Rows.Count > 0)

                Activer(true);
            else
                Activer(false);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            tbID.Text = tbPre.Text = tbNom.Text = "";
            dtpNai.Value = DateTime.Today;
            Activer(false);
        }

        private void btnEditer_Click(object sender, EventArgs e)
        {
            if (dgvPersonne.SelectedRows.Count > 0)
            {
                tbID.Text = dgvPersonne.SelectedRows[0].Cells["ID"].Value.ToString();
                C_Personne pTmp = new G_Personne(sConnexion).Lire_ID(int.Parse(tbID.Text));
                tbPre.Text = pTmp.PRE;
                tbNom.Text = pTmp.NOM;

                dtpNai.Value = (pTmp.NAI == null ? DateTime.Today : (DateTime)pTmp.NAI); //DateTime ? donne une date ou une valeur nul, 
                                                                                         //il faut une condition pour savoir laquelle on a
                Activer(false);
            }
            else
                MessageBox.Show("Selectionner l'enregistrement à editer");
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvPersonne.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Supprimer l'enregistrement ?", "Confirmer", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int iID = (int)dgvPersonne.SelectedRows[0].Cells["ID"].Value;
                    new G_Personne(sConnexion).Supprimer(iID);
                    bsPersonne.RemoveCurrent();
                }
                else
                    MessageBox.Show("Selectionner l'enregistrement à supprimer");
            }
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (tbNom.Text == "")
                MessageBox.Show("Renseigner le nom de la personne !!");
            else
            {

                if (tbID.Text == "")
                //Ajout
                {
                    int iID = new G_Personne(sConnexion).Ajouter(tbNom.Text, tbPre.Text, dtpNai.Value);
                    tbID.Text = iID.ToString();
                    dtPersonne.Rows.Add(iID, tbPre.Text + " " + tbNom.Text);
                }

                else
                //Modification
                {
                    int iID = new G_Personne(sConnexion).Modifier(int.Parse(tbID.Text), tbNom.Text, tbPre.Text, dtpNai.Value);
                    dgvPersonne.SelectedRows[0].Cells["Afficher"].Value = tbPre.Text + " " + tbNom.Text;
                    bsPersonne.EndEdit();
                }
            }
            Activer(true);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Activer(true);
        }
    }
}
