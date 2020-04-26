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
    public partial class EcranLectureGPS : Form
    {
        public EcranLectureGPS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //btnConnecter

            if(cbPortCOM.SelectedIndex >= 0)
             {
                try
                {
                    if (spGPS.IsOpen)
                    {
                        spGPS.Close();

                        //Le tick recherche toute les secondes la trames qui passe et quand on arrête de lire on doit aussi arrêter le chrono
                    }

                    spGPS.PortName = cbPortCOM.Text;

                    //Selectionner au combo box, on récupere la valeur affichée dans le combobox

                    spGPS.Open();
                    tChrono.Start();
                    btnLecture.Text = "Arrêter la lecture";
                }


                catch (Exception ex)

                {
                    MessageBox.Show("Problème : " + ex.Message);
                }
            }

            else

                MessageBox.Show("Sélectionner un port");

        }

        private void btnLecture_Click(object sender, EventArgs e)
        {
            //Arrête ou démarre la lecture donc controle le chrono

            tChrono.Enabled = !tChrono.Enabled;

            if (tChrono.Enabled)
                btnLecture.Text = "Arrêter la lecture";
            else
                btnLecture.Text = "Débuter la lecture";
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            if (tbLongitude.Text == "" || tbLongitude.Text == "")
                MessageBox.Show("Pas de données lues donc pas de carte");
            else
            {
                EcranCarte f = new EcranCarte(tbLongitude.Text, tbLatitude.Text);
                f.ShowDialog();
            }
        }

        private void tChrono_Tick(object sender, EventArgs e)
        { 
            /*
            $GPGGA,123519,4807.038,N,01131.324,E,1,08,0.9,545.4,M,46.9,M, , *42
            123519 = Acquisition du FIX à 12:35:19 UTC
            4807.038,N = Latitude 48 deg 07.038' N
            01131.324,E = Longitude 11 deg 31.324' E
            1 = Fix qualification: (0 = non valide, 1 = Fix GPS, 2 = Fix DGPS)
            08 = Nombre de satellites en poursuite.
            0.9 = DOP(Horizontal dilution of position) Dilution horizontale.
            545.4,M = Altitude, en Mètres, au dessus du MSL(mean see level) niveau moyen des Océans.
            46.9,M = Correction de la hauteur de la géoïde en Mètres par rapport à l'ellipsoïde WGS84 (MSL).
            (Champ vide) = nombre de secondes écoulées depuis la dernière mise à jour DGPS.
            (Champ vide) = Identification de la station DGPS.
            *42 = Checksum
            */

            if (spGPS.IsOpen)
            {
                string sData = spGPS.ReadExisting();
                //on lit ce que le gps envoi
                //puis on divise le sdata pour récupérer les trames et ce dont on a besoin
                string[] sTrames = sData.Split('$');

                for(int i=0; i< sTrames.Length; i++)
                {
                    string[] sContenu = sTrames[i].Split(',');

                    if(sContenu[0] == "GPGGA" && sContenu.Length == 15)
                    {
                        /*
                       $GPGGA,123519,4807.038,N,01131.324,E,1,08,0.9,545.4,M,46.9,M, , *42
                        123519 = Acquisition du FIX à 12:35:19 UTC
                       4807.038,N = Latitude 48 deg 07.038' N
                        01131.324,E = Longitude 11 deg 31.324' E
                       1 = Fix qualification: (0 = non valide, 1 = Fix GPS, 2 = Fix DGPS)
                        08 = Nombre de satellites en poursuite.
                       0.9 = DOP(Horizontal dilution of position) Dilution horizontale.
                       545.4,M = Altitude, en Mètres, au dessus du MSL(mean see level) niveau moyen des Océans.
                       46.9,M = Correction de la hauteur de la géoïde en Mètres par rapport à l'ellipsoïde WGS84 (MSL).
                       (Champ vide) = nombre de secondes écoulées depuis la dernière mise à jour DGPS.
                       (Champ vide) = Identification de la station DGPS.
                       *42 = Checksum
                        */

                        double dLat = double.Parse(sContenu[2].Replace('.', ','));
                        //dans dLat je met 4807,038
                        dLat /= 100;
                        //On déplace la virgule pour avoir 48,07038
                        tbLatitude.Text = sContenu[3]+((int)dLat).ToString();
                        //Dans la textebox on place N48
                        dLat -= (int)dLat;
                        //Il nous rest que 0,07038
                        dLat = dLat * 100 / 60;
                        //On a 0,1173
                        tbLatitude.Text += dLat.ToString().Substring(1).Replace(',','.');
                        //Substring vire le nombre d'élement indiqué (ici 1 pour le 0)


                        double dLon = double.Parse(sContenu[4].Replace('.', ','));
                        dLon /= 100;
                        tbLongitude.Text = sContenu[5] + ((int)dLon).ToString();
                        dLon -= (int)dLon;
                        dLon = dLon * 100 / 60;
                        tbLongitude.Text += dLon.ToString().Substring(1).Replace(',', '.');

                    }
                }

            }

        }
    }
}
