using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ISET_2020_Découverte_WinForm
{
    public partial class EcranBDDataset : Form
    {
        public EcranBDDataset()
        {
            InitializeComponent();
        }

        private void EcranBDDataset_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dspClient.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.dspClient.Client);

            //Un composant TableAdapter remplit un ensemble de données avec des données de la base de données
            //TableAdapters peut également effectuer des ajouts, des mises à jour et des suppressions sur la base de données pour persister les modifications que vous apportez à l’ensemble de données
        }
        private void Activer(bool lPrincipal)
        {
            dgvClient.Enabled = lPrincipal;
            tbID.Enabled = tbPre.Enabled = tbNom.Enabled = !lPrincipal;
            dtpNai.Enabled = !lPrincipal;
            btnConfirmer.Enabled = btnAnnuler.Enabled = !lPrincipal;
            btn1er.Enabled = btnPrecedent.Enabled = btnSuivant.Enabled = btnDernier.Enabled = !lPrincipal;
            btnEditer.Enabled = btnAjouter.Enabled = btnSupprimer.Enabled = lPrincipal;
        }

        private void Valider() //essaye d'envoyer a la BD ce qui se passe au niveau du dataset (cache de données)
        {
            try
            {
                MessageBox.Show(clientTableAdapter.Update(dspClient.Client)
                + " mise(s) à jour effectuée(s)"); //Mise a jour des infos du dataset

                if(tbID.Text == "-1") //Si l'élement n'est pas déjà présent dans la bdd
                {
                    OleDbConnection oConn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=perso.mdb"); //crée la connexion à la ndd
                    oConn.Open(); //ouverture de la connexion
                    OleDbCommand oComm = new OleDbCommand("SELECT MAX(NUMCLI) FROM CLIENT", oConn); //procédure prenant le plus grand ID client
                    int iTmp =(int) oComm.ExecuteScalar(); //Sélectionne la 1er variable de la 1er colonne obtneu via la procédure et Placement dans variable temporaire avec cast
                    tbID.Text = iTmp.ToString(); //Placement de la variable dans la textbox
                    oConn.Close(); //Fermeture de la connexion
                }
            }

            catch { MessageBox.Show("Echec de la mise à jour"); }
        }

        private void btn1er_Click(object sender, EventArgs e)
        {
            clientBindingSource.MoveFirst(); //Passe au 1er element de la liste, bindingsource utilisé car on le fait dans le formulaire
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {//cest precedent, pas suivant
            clientBindingSource.MovePrevious();
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {//Suivant pas precedent
            clientBindingSource.MoveNext();
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            clientBindingSource.MoveLast();
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            clientBindingSource.EndEdit(); //fin de l'edition, après on regarde si il y a eu des changements
            if (dspClient.HasChanges()) //Si le dataset de donnée a été modifier
            {
                Valider();
            }
            else
                MessageBox.Show("Pas de modification");

            Activer(true);

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            clientBindingSource.CancelEdit(); //Annule les modifications
            Activer(true);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            clientBindingSource.AddNew(); //Ajout d'un nouvel élément
            Activer(false);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Supprimer " + tbPre.Text + " " + tbNom.Text + " ?", "Confirmer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                clientBindingSource.RemoveAt(clientBindingSource.Position);
                Valider();
            }
        }

        private void btnEditer_Click(object sender, EventArgs e)
        {
            Activer(false);
        }

        private void clientBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            btn1er.Enabled = btnSuivant.Enabled = (clientBindingSource.Position > 0);
            btnPrecedent.Enabled = btnDernier.Enabled = (clientBindingSource.Position < clientBindingSource.Count - 1);
            lblPosition.Text = (1 + clientBindingSource.Position) + "/" + clientBindingSource.Count;
        }
    }
}
