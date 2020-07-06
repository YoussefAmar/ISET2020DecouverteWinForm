using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace ISET_2020_Découverte_WinForm
{
    /*  Amar (Monsieur)  #1
        Ghanima (Mondamoiseau)  #2
        Arbre (Indéfini)  #3

        fichier
    */
    public partial class EcranListe : Form
    {

        private string sFichier = "";
        [DllImport("user32.dll", EntryPoint = "SendMessage")]

        //It means that the method declared below it is not in .NET - it is in a external (native) DLL file and the above declaration allows us to use it as if it was a .NET method
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private const int lbLire = 0x0199;
        private const int lbEcrire = 0x019A;
        public EcranListe()
        {
            InitializeComponent();
            Activer(true);
        }

        private void Activer(bool lPrincipal)
        {
            lbPersonne.Enabled = lPrincipal;
            btnOuvrir.Enabled = btnSave.Enabled = btnAjouter.Enabled = btnSupprimer.Enabled = lPrincipal;
            pDetail.Enabled = !lPrincipal;
        }

        private void btnOuvrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            //Affiche une boite de dialogue standard qui invite l'utilisateur à ouvrir un fichier

            ofd.Filter = "Fichiers texte (*.txt)|*.txt|Tous fichiers|*.*";

            //Détermine les types de fichier que l'on peut ouvrir ou enregistrer : partie 1 : texte pour user, partie 2 : (après la barre) type de fichier

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lbPersonne.Items.Clear();
                //Clear les éléments de la listebox lbPersonne

                sFichier = ofd.FileName;
                //Envoi le nom du fichier ouvert dans sFichier

                lbFichier.Text = sFichier.Substring(sFichier.LastIndexOf("\\") + 1);
                //Récupère le nom du fichier dans le chemin complet, substring permet de commencer au dernier \\ et donc d'obtenir que le nom du fichier

                StreamReader sr = new StreamReader(sFichier);
                //Lecteur de données du fichier ouvert

                string sLecture;

                while((sLecture = sr.ReadLine()) != null) //sLecture prend le string contenu dans sr à chaque passage, 1er : "Amar (Monsieur) #1"
                {   //Tant qu'il y a des éléments à lire dans le fichier

                    string[] aTmp = sLecture.Split('#'); //Indication du séparateur de données pour séparer les éléments de la liste à l'écriture/lecture
                    int n = lbPersonne.Items.Add(aTmp[0]); //Ajout de la personne dans la list box ainsi que comptage du nombre de personne dans la liste

                    //aTmp[0] : "Amar (Monsieur) " aTmp[1] : 1

                    SendMessage(lbPersonne.Handle, lbEcrire, n, int.Parse(aTmp[1]));
                    //Utilisation de la méthode dans user32.dll 
                }

                sr.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            //Emplacement de sauvegarde d'un fichier

            sfd.Filter = "Fichiers texte (*.txt)|*.txt|Tous fichiers|*.*";
            //type de fichier pouvant être sauvegardé

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                sFichier = sfd.FileName;
                StreamWriter sw = new StreamWriter(sFichier);
                //Ecriture dans le fichier sFichier qui obtient le chemin du fichier à sauvegardé

                for(int i = 0; i < lbPersonne.Items.Count; i++)
                {
                    int nPos = SendMessage(lbPersonne.Handle, lbLire, i, 0); //Variable incrémentée selon la personne lue
                    sw.WriteLine(lbPersonne.Items[i].ToString() + " #" + nPos.ToString()); //Sauvegarde des infos dans le fichiers avec un splitteur
                }
                sw.Close();

                lbFichier.Text = sFichier.Substring(sFichier.LastIndexOf("\\") + 1);
                //Nom du fichier sans le chemin
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Activer(false);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex >= 0) //Index de la personne à supprimer > 0
            {
                if (MessageBox.Show("Supprimer " + lbPersonne.Text, "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    int InfoActuel;

                    int InfoSupprimer = SendMessage(lbPersonne.Handle, lbLire, lbPersonne.SelectedIndex, 0);

                    for (int i = lbPersonne.SelectedIndex; i < lbPersonne.Items.Count; i++)
                    {
                        InfoActuel = SendMessage(lbPersonne.Handle, lbLire, i, 0);

                        if (InfoActuel > InfoSupprimer)
                        {
                            InfoActuel--;

                            SendMessage(lbPersonne.Handle, lbEcrire, i, InfoActuel); //Décrémente la position de tout les éléments de la liste au dessus du supprimé
                        }

                    }

                    lbPersonne.Items.Remove(lbPersonne.SelectedItem); //Supprime la personne sélectionner de la listbox
                }
            }
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
           int n = lbPersonne.Items.Add(tbNom.Text + " (" + cbQualité.Text + ")"); //Ajout d'une personne à la liste donc ajout d'une incrémentation
           SendMessage(lbPersonne.Handle, lbEcrire, n, lbPersonne.Items.Count);
           Activer(true);
        }

        private void btnAnuller_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void lbPersonne_DoubleClick(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex >= 0)
            {
                int nPos = SendMessage(lbPersonne.Handle,lbLire, lbPersonne.SelectedIndex, 0);
                MessageBox.Show(lbPersonne.Text + "en position " + (1 + lbPersonne.SelectedIndex).ToString() + " (tri)," + nPos + " (encodage)");
            }
            else
                MessageBox.Show("Pas d'élément sélectionné");
        }
    }
}
