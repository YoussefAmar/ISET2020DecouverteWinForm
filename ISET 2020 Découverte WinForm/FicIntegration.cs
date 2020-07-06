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
    public partial class EcranIntegration : Form
    {
        static private double fctPolynome(double x)
        {
            return x * x + 1;
        }

        static private double fctTrignometrique(double x)
        {
            return Math.Cos(x);
        }

        delegate double FonctionAIntegrer(double x); //type permettant de pointer vers une fonction double ici

        public EcranIntegration()
        {
            InitializeComponent();
        }

        private double IntegrationTrapeze(FonctionAIntegrer f, double bg, double bd, int n)
        {
            double Aire = f(bg) + f(bd);
            double p = (bd - bg) / n;
            double x = bg + p;

            for(int j = 0; j < n - 1; j++)
            {
                Aire += 2 * f(x);
                x += p;
            }

            return Aire * p / 2;
        }

        private void bPolynome_Click(object sender, EventArgs e)
        {
            double a, b; //Récupère les deux bornes avec lequelles on va séparer la fonction en plusieurs trapèzes
            int nInt; //Nombre d'intervalles

            //Vérifie si les valeurs dans les textboxs sont numériques et applicable dans la variable

            if (double.TryParse(tbgauche.Text, out a) && double.TryParse(tbdroite.Text, out b) && int.TryParse(tbNbInt.Text, out nInt))
            {
                lbResultats.Items.Clear(); //Vide la box pour un nouveau début d'ajout d'infos
                lbResultats.Items.Add("Méthodes des trapèzes");
                lbResultats.Items.Add("  Polynôme : x*x + 1");

                //On va faire 5 fois la simulation => boucle jusqu'à 5 et doubler le nombre de trapèze à chaque passage

                for(int i = 0; i < 5; i++)
                {
                 /* double Aire = a * a + 1 + b * b + 1; //Aire total sous la courbe intégrée
                    double p = (b - a) / nInt; //Pas : distance des bornes divisé par le nombre de trapèze, pas des trapèzes
                    double x = a + p; //distance à partir de a de la fin du 1er trapèze, permet d'augmenter le nombre de trapèze

                    for(int j = 0; j < nInt - 1; j++) //Calcul du résultat
                    {
                        Aire += 2 * (x * x + 1);
                        x += p;
                    }*/

                    lbResultats.Items.Add("   Nb Int : " + nInt.ToString() + " => " + IntegrationTrapeze(fctPolynome, a , b , nInt).ToString());

                    nInt *= 2;
                }

            }
        }

        private void bTrigonometrique_Click(object sender, EventArgs e)
        {
            double a, b; //Récupère les deux bornes avec lequelles on va séparer la fonction en plusieurs trapèzes
            int nInt; //Nombre d'intervalles

            //Vérifie si les valeurs dans les textboxs sont numériques et applicable dans la variable

            if (double.TryParse(tbgauche.Text, out a) && double.TryParse(tbdroite.Text, out b) && int.TryParse(tbNbInt.Text, out nInt))
            {
                lbResultats.Items.Clear(); //Vide la box pour un nouveau début d'ajout d'infos
                lbResultats.Items.Add("Méthodes des trapèzes");
                lbResultats.Items.Add("  Trigonométrique : cos(x)");

                //On va faire 5 fois la simulation => boucle jusqu'à 5 et doubler le nombre de trapèze à chaque passage

                for (int i = 0; i < 5; i++)
                {
                 /* double Aire = Math.Cos(a) + Math.Cos(b); //Aire total sous la courbe intégrée
                    double p = (b - a) / nInt; //Pas : distance des bornes divisé par le nombre de trapèze, pas des trapèzes
                    double x = a + p; //distance à partir de a de la fin du 1er trapèze, permet d'augmenter le nombre de trapèze

                    for (int j = 0; j < nInt - 1; j++) //Calcul du résultat
                    {
                        Aire += 2 * (Math.Cos(x));
                        x += p;
                    }*/

                    lbResultats.Items.Add("   Nb Int : " + nInt.ToString() + " => " + IntegrationTrapeze(fctTrignometrique , a , b, nInt).ToString());

                    nInt *= 2;
                }

            }
        }

        private void bIntegration_Click(object sender, EventArgs e)
        {
            double a, b; //Récupère les deux bornes avec lequelles on va séparer la fonction en plusieurs trapèzes
            int nInt; //Nombre d'intervalles

            //Vérifie si les valeurs dans les textboxs sont numériques et applicable dans la variable

            if (double.TryParse(tbgauche.Text, out a) && double.TryParse(tbdroite.Text, out b) && int.TryParse(tbNbInt.Text, out nInt))
            {
                lbResultats.Items.Clear(); //Vide la box pour un nouveau début d'ajout d'infos
                lbResultats.Items.Add("Méthodes des trapèzes");

                if(((Button)sender).Name == "bPolynome")

                    lbResultats.Items.Add("  Polynôme : x*x + 1");

                else if(((Button)sender).Name == "bTrigonometrique")

                    lbResultats.Items.Add("  Trigonométrique : cos(x)");

                //On va faire 5 fois la simulation => boucle jusqu'à 5 et doubler le nombre de trapèze à chaque passage

                for (int i = 0; i < 5; i++)
                {
                    if (((Button)sender).Name == "bPolynome")

                        lbResultats.Items.Add("   Nb Int : " + nInt.ToString() + " => " + IntegrationTrapeze(fctPolynome, a, b, nInt).ToString());

                    else if (((Button)sender).Name == "bTrigonometrique")

                        lbResultats.Items.Add("   Nb Int : " + nInt.ToString() + " => " + IntegrationTrapeze(fctTrignometrique, a, b, nInt).ToString());

                    nInt *= 2;
                }

            }
        }

    }
}
