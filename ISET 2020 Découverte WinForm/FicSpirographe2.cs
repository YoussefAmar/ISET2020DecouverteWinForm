using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;


namespace ISET_2020_Découverte_WinForm
{
    public partial class EcranSpirographe2 : Form
    {

        List<Point> gPoints = new List<Point>();

        //Liste de point du graphe

        public EcranSpirographe2()
        {
            InitializeComponent();
        }

        private void EcranSpirographe2_Load(object sender, EventArgs e)
        {
            gPoints.Clear();

            gPoints = Generer();

            // Au lancement on reset et génére nos points

        }

        private void pbGraphe_Paint(object sender, PaintEventArgs e)
        {
                Rectangle r = new Rectangle(0, 0, pbGraphe.Width, pbGraphe.Height);

                e.Graphics.FillRectangle(new SolidBrush(Color.White), r);

            //Fond de l'écran

                Dessine(e);

            //On trace le graphique

        }

        private List<Point> Generer()
        {
            //Générer la liste de points
            
            Random rng = new Random();

            int nb = rng.Next(10,21);

            //Nombre de point aléatoire entre 10 et 20

            int x = 0, y;

            for(int i = 0; i < nb; i++)
            {
                x = rng.Next(5, 25) + x;

                //Les x des points sont croissants

                y = rng.Next(-100, 100);

                //y entre 100 et -100

                Point p = new Point(x, y);

                //On initialise le point avec son x et son y

                gPoints.Add(p);

                //Ajout du point dans la liste

            }

            return gPoints;
        }

        private int Delta(List<Point> liste)
        {
            int min = 0;
            int max = 0;

            foreach(Point p in liste)
            {
                if (p.Y > max)

                    max = p.Y;

                //On prend le point le plus haut du graphique

                if (p.Y < min)

                    min = p.Y;

                //On prend le point le plus bas du graphique

            }

            return max + Math.Abs(min);
        }

        private void Dessine(PaintEventArgs e)
        {
            
            
            int eX = pbGraphe.Width / gPoints[gPoints.Count - 1].X;

            //Largeur de la box divisé par la position du dernier points

            int eY = pbGraphe.Height / Delta(gPoints);

            //Hauteur de la box divisé par la somme du plus grand Y et du plus petit

            int yc = pbGraphe.Height/2;
            int xc = pbGraphe.Location.X;

            //Position du x en haut à gauche

            Rectangle ligne = new Rectangle(xc, yc, pbGraphe.Width, 5);

            e.Graphics.DrawRectangle(new Pen(Color.Red), ligne);
            e.Graphics.FillRectangle(Brushes.Red, ligne);

            //Traçage de la ligne d'abscisse

            for (int i = 1; i < gPoints.Count; i++)
            {
                e.Graphics.DrawLine(new Pen(Color.Blue), gPoints[i - 1].X * eX + xc, gPoints[i - 1].Y * eY + yc, gPoints[i].X * eX + xc, gPoints[i].Y * eY + yc);

                //Traçage de chaque ligne reliant le point précédent au suivant avec l'écart ajouté afin d'adapter la ligne à la fenêtre

                //e.Graphics.DrawLine(new Pen(Color.Blue), gPoints[i].X * eX + xc, gPoints[i - 1].Y * eY + yc, gPoints[i].X * eX + xc, gPoints[i].Y * eY + yc);

                //Cette commande trace une ligne de plus entre les points afin d'avoir des formes rectangulaires (modifié le dernier du premier drawline par [i-1])

                e.Graphics.DrawString("(" + (gPoints[i - 1].X).ToString() + "," + (gPoints[i - 1].Y).ToString() +")",new Font("Arial",8, FontStyle.Bold), Brushes.Black ,new Point(gPoints[i - 1].X * eX + xc - 20, gPoints[i - 1].Y * eY + yc));

            }

            e.Graphics.DrawString("(" + (gPoints[gPoints.Count - 1].X).ToString() + "," + (gPoints[gPoints.Count - 1].Y).ToString() + ")", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(gPoints[gPoints.Count - 1].X * eX + xc - 30, gPoints[gPoints.Count - 1].Y * eY + yc));

            //Dessin texte des coordonées des points
        }


    }
}
