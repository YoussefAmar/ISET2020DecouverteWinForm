using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; //On va manipuler des threads
using System.IO;

namespace ISET_2020_Découverte_WinForm
{
    public partial class EcranVenteTickets : Form
    {
        private int nbTickets, nbVendeurs, nbVendus;
        private int[,] ChargeVendeurs;
        List<int> lListe; //liste d'attente avant d'être traité par un vendeur
        private Mutex mListe; //Un mutex est un objet système qui permet de synchroniser différents processes et assure qu'il y en ai qu'un qui soit exécuter à chaque moment
        private StreamWriter sw;

        public EcranVenteTickets()
        {
            InitializeComponent();
        }

        private void bSimuler_Click(object sender, EventArgs e)
        {
            sw = new StreamWriter("VerifVentes.txt");
            lListe = new List<int>(); //Liste de reception d'appel
            Thread tAppel = new Thread(Appel); //Fonction qui sera executer dans le thread
            Thread[] tVendeurs;
            int nSomme = 0;
            lbResultats.Items.Clear();
            nbVendeurs = tbNbVendeurs.Value;
            nbTickets = tbNbTickets.Value;
            nbVendus = 0;
            ChargeVendeurs = new int[nbVendeurs, 2];
            tVendeurs = new Thread[nbVendeurs];
            mListe = new Mutex();

            for(int i = 0; i < nbVendeurs; i++)
            {
                ParameterizedThreadStart pts = new ParameterizedThreadStart(Vente);
                tVendeurs[i] = new Thread(pts);
                tVendeurs[i].Start(i);
            }

            tAppel.Start();

            for (int i = 0; i < nbVendeurs; i++)
            {
                tVendeurs[i].Join(); //On passera à la ligne suivante seulement lorsque les 4 fonctions associé au vendeur seront à l'arrêt donc quand tout les tickets auront été vendus
            }

            for (int i = 0; i < nbVendeurs; i++)
            {
                lbResultats.Items.Add("Vendeur " + (1 + i).ToString() + " : " + ChargeVendeurs[i, 0].ToString() + " ("+ ((double)ChargeVendeurs[i, 1]/ ChargeVendeurs[i, 0]).ToString("N2") + ")");
                nSomme += ChargeVendeurs[i, 0];
            }

            lbResultats.Items.Add("Total : " + nSomme.ToString());

           sw.Close();
        }

        private void Appel()
        {
            Random rAppel = new Random(); //Random pour générer un temps de traitement aléatoire

            while(true) //Traitement
            {
                //Reçoit un appel et l'enregistre, on va attendre d'avoir la main sur le mutex

                mListe.WaitOne();

                if(nbVendus == nbTickets) //On sort du traitement
                {
                    mListe.ReleaseMutex(); //Libérer le mutex après utilisation
                    break;
                }

                nbVendus++; //Un nouveau ticket a été vendu
                lListe.Add(nbVendus); //Ajouter dans la liste l'appel entrant
                sw.WriteLine("Appel : " + nbVendus.ToString());
                mListe.ReleaseMutex(); //Libérer le mutex après utilisation
                System.Threading.Thread.Sleep(rAppel.Next(5, 20)); //On va attendre un certains temps avant de prendre le prochain appel
            }
        }

        private void Vente(object i) //On doit savoir quel vendeur (i) traite la vente en argument
        {
            Random rTraitement = new Random();
            int tTraitement = 0; //Temps de traitement à enregistré

            while(true)
            {
                mListe.WaitOne();

                if(lListe.Count > 0) //Si il y a quelqu'un dans la liste on traite la vente
                {
                    tTraitement = rTraitement.Next(60, 100);

                    ChargeVendeurs[(int)i, 0]++; //Nombre de vente traitées incrémentée

                    ChargeVendeurs[(int)i, 1] += tTraitement;

                    lListe.RemoveAt(0); //On retire la personne de la liste

                    sw.WriteLine("Vente : " + ((int)i).ToString());
                }

                else // pas de tickets vendu ou plus de tickets à vendre
                {
                    if(nbVendus == nbTickets)
                    {
                        mListe.ReleaseMutex();
                        break;
                    }

                    tTraitement = 1;

                }

                mListe.ReleaseMutex();
                Thread.Sleep(tTraitement);
            }

        }
    }
}
