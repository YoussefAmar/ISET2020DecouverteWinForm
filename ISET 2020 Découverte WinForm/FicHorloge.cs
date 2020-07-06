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
    public partial class EcranHorloge : Form
    {
       private Color TraitP,FondP,aF,bF,cF;

        int s = 0, m = 0, h = 0;

        // Variable de temps initalisé ici pour pouvoir être utilisable partout dans le programme

        public EcranHorloge()
        {
            InitializeComponent();
        }

        private void pbHorloge_Paint(object sender, PaintEventArgs e)
        {
            TraitP = Color.Black;
            FondP = Color.Gray;

            // Couleur des heures

            aF = Color.DarkRed;
            bF = Color.Black;
            cF = Color.DarkGreen;

            // Couleur des aiguilles

            int xc = ClientSize.Width / 2;
            int yc = ClientSize.Height / 2;

            //Coordonnée du centre de l'écran


            int rayon = Math.Min(ClientSize.Height / 3, ClientSize.Width / 3);
            int tailleP = 6;

            //Rayon du cercle de l'horloge et taille des heures

            int[] xP = new int[12];
            int[] yP = new int[12];

            //Groupes de point constituant les heures

            for (int i = 0; i < 12; i++)
            {
                xP[i] = (int)(xc + rayon * Math.Cos(i * 2 * Math.PI / 12));
                yP[i] = (int)(yc + rayon * Math.Sin(i * 2 * Math.PI / 12));

                //Répartition des points en cercle

                e.Graphics.DrawEllipse(new Pen(TraitP), xP[i], yP[i], tailleP, tailleP);

                e.Graphics.FillEllipse(new SolidBrush(FondP), xP[i], yP[i], tailleP, tailleP);

                //Dessin des points

            }

            e.Graphics.DrawLine(new Pen(cF), xc, yc, (int)(xc + rayon*3/4 * Math.Cos(m * 2 * Math.PI / 60 - Math.PI / 2)), (int)(yc + rayon*3/4 * Math.Sin(m * 2 * Math.PI / 60 - Math.PI / 2)));

            //Aiguille des minutes, on dessine une ligne reliant deux point : point 1 est au centre de l'horloge, point 2 se trouve à 2pi (cercle entier) 
            //diviser par 60 (minutes) fois les minutes actuelles, on retire PI/2 pour décaler le départ de l'aiguille et on divise le rayon pour réduire sa longueur

            e.Graphics.DrawLine(new Pen(bF), xc, yc, (int)(xc + rayon/2 * Math.Cos( (h%12) * 2 * Math.PI / 12 - Math.PI / 2)), (int)(yc + rayon/2 * Math.Sin( (h%12) * 2 * Math.PI / 12 - Math.PI / 2)));

            //Aiguille des heures, on dessine une ligne reliant deux point : point 1 est au centre de l'horloge, point 2 se trouve à 2pi (cercle entier) 
            //diviser par 12 (heures), comme on peut dépasser 12 heures (14 heures par exemple) on prend le modulo de 12 pour rester dans les normes établies
            //on retire PI/2 pour décaler le départ de l'aiguille et on divise le rayon pour réduire sa longueur

            e.Graphics.DrawLine(new Pen(aF), xc, yc, (int)(xc+ rayon * Math.Cos(s * 2 *Math.PI / 60 - Math.PI / 2)), (int)(yc + rayon * Math.Sin(s * 2 * Math.PI / 60 - Math.PI / 2)));

            //Aiguille des secondes, on dessine une ligne reliant deux point : point 1 est au centre de l'horloge, point 2 se trouve à 2pi (cercle entier) 
            //diviser par 60 (secondes) fois les secondes actuelles, on retire PI/2 pour décaler le départ de l'aiguille
        }

        private void EcranHorloge_Load(object sender, EventArgs e)
         {
            tHorloge.Enabled = true;
         }

        private void tHorloge_Tick(object sender, EventArgs e)
        {
            pbHorloge.Invalidate();

            s = DateTime.Now.Second;
            m = DateTime.Now.Minute;
            h = DateTime.Now.Hour;

            //Invalidate permet de coordonnée le tick avec la pictureBox
            // on initialise nos variables au moments actuels à chaque passage du tick (1000 ms)

        }

    }
}
