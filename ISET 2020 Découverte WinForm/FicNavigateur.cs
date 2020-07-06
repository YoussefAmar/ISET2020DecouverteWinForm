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

namespace ISET_2020_Découverte_WinForm
{
    public partial class EcranNavigateur : Form
    {
        private TreeNode tnRacine;

        private string NomFichier(string sFichier)
        {
            return sFichier.Substring(1 + sFichier.LastIndexOf('\\'));
        }

        public EcranNavigateur()
        {
            InitializeComponent();
        }

        private void tsbQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsPetitesIcones_Click(object sender, EventArgs e)
        {
            lvFichier.View = View.SmallIcon;
        }

        private void tsGrandesIcones_Click(object sender, EventArgs e)
        {
            lvFichier.View = View.LargeIcon;
        }

        private void tsListe_Click(object sender, EventArgs e)
        {
            lvFichier.View = View.List;
        }

        private void tsDetail_Click(object sender, EventArgs e)
        {
            lvFichier.View = View.Details;
        }

        private void EcranNavigateur_Load(object sender, EventArgs e)
        {
            LireDisques();
        }

        private void LireDisques()
        {
            Cursor Curseur = Cursor.Current;
            Cursor = Cursors.WaitCursor;
            tsslMessage.Text = "Lecture de l'arborescence 'Répertoire'";
            tvRepertoire.Nodes.Clear();

            tnRacine = new TreeNode("Poste de travail", 0, 0);

            tvRepertoire.Nodes.Add(tnRacine);
            string[] OrdiDisques = Environment.GetLogicalDrives(); //stocke dans un tableau les lecteurs de l'ordi

            foreach(string NomDisque in OrdiDisques)
            {
                TreeNode tnDisque = new TreeNode(NomDisque,1,1);
                tnRacine.Nodes.Add(tnDisque);
                LireRepertoire(NomDisque, tnDisque.Nodes);
            }

            lvFichier.Items.Clear();

            tsslMessage.Text = "";

            Cursor = Curseur; //On est plus en attente

        }

        private void LireRepertoire(string nd, TreeNodeCollection tr)
        {
            if(Directory.Exists(nd))
            {
                try
                {
                    string[] sRepertoires = Directory.GetDirectories(nd); //récupères les sous répertoires

                    string s1 = "", s2 = "";

                    foreach(string RepNom in sRepertoires)
                    {
                        s1 = NomFichier(RepNom);
                        s2 = s1.ToUpper();

                        TreeNode tnCourant;

                        if (s2 == "RECYCLED" || s2 == "RECYCLER")
                        {
                            tnCourant = new TreeNode(s1, 4, 4);

                            //1er 4 image affichée par défaut, 2eme 4 image que l'on selectionne
                        }

                        else
                            tnCourant = new TreeNode(s1, 2, 3);

                        tr.Add(tnCourant);

                        LireRepertoire(RepNom, tnCourant.Nodes);

                        //Va lire l'arbo complète de l'ordi à l'aide de la récursivité
                    }

                }

                catch { }

            }
        }

        private void tvRepertoire_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode tnCourant = e.Node;

            if (tnCourant == tnRacine)
            {


                string[] sTmp = { "Poste de travail", "", "", "" };
                //Descriptif : taille, date création, date modification

                lvFichier.Items.Add(new ListViewItem(sTmp, 0));
            }

            else
            {
                string sRep = tnCourant.FullPath;

                sRep = sRep.Remove(0, 1 + sRep.IndexOf('\\'));

                try
                {
                    lvFichier.Items.Clear();

                    if (!Directory.Exists(sRep))
                    {
                        string[] sTmp = { "Poste de travail", "", "", "" };

                        lvFichier.Items.Add(new ListViewItem(sTmp, 0));
                    }

                    else
                        LireFichier(sRep);

                }

                catch(IOException fot)
                {
                    MessageBox.Show("Erreur lors de l'accès à" + sRep + "(" + fot + ")");

                    tvRepertoire.Focus();
                }

            }
        }

        private void LireFichier(string sRep)
        {
            Cursor Curseur = Cursor.Current;
            Cursor = Cursors.WaitCursor;
            tsslMessage.Text = "Lecture des fichiers dans" + sRep;
            lvFichier.Items.Clear();

            try
            {
                string[] sFic = Directory.GetFiles(sRep);

                string[] sCol = new string[4];

                string sTmp1 = "";

                FileInfo fiFic;

                //Infos du fichier

                long taFic;

                //Taille du fichier

                foreach(string sf in sFic)
                {
                    sTmp1 = sf.ToUpper();

                    if(sTmp1 != "PAGEFILE.SYS")
                    {
                        fiFic = new FileInfo(sf);
                        taFic = fiFic.Length;
                        sCol[0] = NomFichier(sf);

                        if (taFic > 1024 * 1024 * 1024)

                            sCol[1] = (taFic / (1024 * 1024 * 1024)).ToString() + " gb";

                       else if (taFic > 1024 * 1024)

                            sCol[1] = (taFic / (1024 * 1024)).ToString() + " mb";

                        else if (taFic > 1024)

                            sCol[1] = (taFic / (1024)).ToString() + " kb";

                        else

                            sCol[1] = (taFic).ToString() + " b";

                        sCol[2] = fiFic.CreationTime.ToString("dd/MM/yyyy");
                        sCol[3] = fiFic.LastWriteTime.ToString("dd/MM/yyyy");
                        lvFichier.Items.Add(new ListViewItem(sCol, 0));
                    }
                }

            }
            catch(IOException e)
            {
                MessageBox.Show("Erreur lors de l'accès à" + sRep + "(" + e.Message + ")");
            }

            tsslMessage.Text = "";
            Cursor = Curseur;

        }

    }
}
