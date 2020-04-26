using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; //Pour gérer les processus
using System.Threading; //Pour gérer les threads

namespace ISET_2020_Découverte_WinForm
{
    public partial class EcranProcessusThreads : Form
    {
        private Process pProcessus = null;
        private List<string> lCommun = null;
        private Random r = new Random();

        public EcranProcessusThreads()
        {
            InitializeComponent();
        }

        private void btnProcessus1_Click(object sender, EventArgs e)
        {
            lbConsole.Items.Clear();
            lbConsole.Items.Add("Chargement du bloc notes");
            Process.Start("notepad");
            lbConsole.Items.Add("Bloc notes chargé");
        }

        private void btnProcessus2_Click(object sender, EventArgs e)
        {
            if (pProcessus == null || pProcessus.HasExited)
            {
                lbConsole.Items.Clear();
                lbConsole.Items.Add("Chargement du bloc notes");
                //pProcessus = Process.Start("notepad");
                pProcessus = new Process();
                pProcessus.StartInfo.FileName = "notepad";
                pProcessus.Start();
                //Start info permet d'obtenir un certain nombre d'information
                //pProcessus.Exited += new EventHandler(myProcess_Exited);
                lbConsole.Items.Add("Bloc notes chargé");
                pProcessus.WaitForExit();
                lbConsole.Items.Add("Début : " + pProcessus.StartTime);
                lbConsole.Items.Add("Fin : " + pProcessus.ExitTime);
                lbConsole.Items.Add("Durée : " + (pProcessus.ExitTime - pProcessus.StartTime));
                //On garde le processus dans une variable
            }
        }

        private void EcranProcessusThreads_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(pProcessus != null)
            {
                if(!pProcessus.HasExited)
                {
                    pProcessus.Kill();
                    pProcessus.WaitForExit();
                    //On le tue et on attend qu'on soit sorti
                }
            }
        }

        private void myProcess_Exited(object sender, System.EventArgs e)
        {
            
        }

        private void btnProcessus3_Click(object sender, EventArgs e)
        {
            Process p = new Process();

            p.StartInfo.FileName = "ISET2020_Programme_secondaire";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            lbConsole.Items.Clear();

            try
            {
                lbConsole.Items.Add("Chargement de ISET2020_Programme_secondaire");
                p.Start();
                lbConsole.Items.Add("Transfert de données");
                p.StandardInput.WriteLine("Largo");
                p.StandardInput.WriteLine("Winch");

                lbConsole.Items.Add("Récupération du traitement");

                lbConsole.Items.Add(" - " +  p.StandardOutput.ReadToEnd());

            }
            catch { lbConsole.Items.Add("Problème d'exécution"); }
        }

        private void btnThread1_Click(object sender, EventArgs e)
        {
            // Thread sont les fonctions d'un processus que l'on peut appeler
            lbConsole.Items.Clear();
            lCommun = new List <string>();
            Thread ta = new Thread(new ThreadStart(a));
            Thread tb = new Thread(new ThreadStart(b));
            ta.Start();
            tb.Start();
            ta.Join();
            tb.Join();
            foreach (string s in lCommun)

            lbConsole.Items.Add(s);
            lbConsole.Items.Add("FINI");

        }

        private void a()
        {
            for (int i = 0; i < 500; i++)

                //lbConsole.Items.Add("A");
                lCommun.Add("A");
                Thread.Sleep(r.Next(10));
        }

        private void b()
        {
            for (int i = 0; i < 500; i++)

                //lbConsole.Items.Add("B");
                lCommun.Add("B");
                Thread.Sleep(r.Next(10));
        }

    }
}
