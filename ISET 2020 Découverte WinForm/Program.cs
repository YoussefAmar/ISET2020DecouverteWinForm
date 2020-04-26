using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; // Pour les processus

namespace ISET_2020_Découverte_WinForm
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!IsRunning())
            {
                //Application.Run(new EcranAcceuil());
                Application.Run(new EcranPrincipal());
            }

            else MessageBox.Show("Instance déjà ouverte");
        }
        public static bool IsRunning()
        {
            //On cherche le processus pour le fermer

            Process pActu = Process.GetCurrentProcess();
            //On prend tout les processus actifs pour chercher actu dans toute la liste acti
            Process[] pActi = Process.GetProcesses();

            foreach(Process p in pActi)
            {
                if (pActu.Id != p.Id)

                    if (p.ProcessName == pActu.ProcessName)

                        return true;
            }

            return false;
        }

    }
}
