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
    public partial class EcranSpirographe : Form
    {
        private Color Trait, Fond;
        private GraphicsPath DessinSauve;

        //Le dessin est enregistré en même temps qu'il est créer via le GraphicsPath

        public EcranSpirographe()
        {
            InitializeComponent();
        }

        private double d(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnFond_Click(object sender, EventArgs e)
        {
            dCouleur.Color = Fond;

            if (dCouleur.ShowDialog() == DialogResult.OK)
            {
                Fond = dCouleur.Color;

                Invalidate(false); // Rafraichit l'affichage
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int nbSommets = tbSommets.Value, nbDensite = tbDensite.Value, nbProfondeur =100 - tbProfondeur.Value;

            DessinSauve = new GraphicsPath();

            Rectangle r = new Rectangle(new Point(248, 0), ClientSize);

            Graphics gr = CreateGraphics();

            gr.FillRectangle(new SolidBrush(Fond), r);

            int xc = 248 +(ClientSize.Width - 248)/2;

            int yc = ClientSize.Height/2;

            int rayon = 9 * Math.Min(ClientSize.Width - 248, ClientSize.Height) / 20;

            int[] sX = new int[nbSommets + 1];
            int[] sY = new int[nbSommets + 1];

            for(int i = 0; i < nbSommets; i++)
            {
                sX[i] = (int)(xc + rayon * Math.Cos(i * 2 * Math.PI / nbSommets));
                sY[i] = (int)(yc + rayon * Math.Sin(i * 2 * Math.PI / nbSommets));
            }

            sX[nbSommets] = sX[0];
            sY[nbSommets] = sY[0];

            int x1, y1, x2, y2;

            //On va dessiner tant qu'on est pas assez proche du centre

            while(d(sX[0],sY[0],xc,yc) > rayon*nbProfondeur/100)
            {
                x1 = sX[0];
                y1 = sY[0];

                for(int i = 1; i <= nbSommets; i++)
                {
                    x2 = sX[i];
                    y2 = sY[i];

                    gr.DrawLine(new Pen(Trait), x1, y1, x2, y2);
                    DessinSauve.AddLine(x1, y1, x2, y2);
                    //Ligne dessinée, on passe à la ligne suivante

                    x1 = x2; y1 = y2;

                    Application.DoEvents();
                    //Permet d'interrompre l'appli en cas de soucis

                    Thread.Sleep(15);

                }

                for(int i = 0; i < nbSommets; i++)
                {
                    sX[i] = sX[i] + (sX[i + 1] - sX[i]) / nbDensite;
                    sY[i] = sY[i] + (sY[i + 1] - sY[i]) / nbDensite;
                }

                sX[nbSommets] = sX[0];
                sY[nbSommets] = sY[0];

            }

        }

        private void btnTrait_Click(object sender, EventArgs e)
        {
            dCouleur.Color = Trait;

            if(dCouleur.ShowDialog() == DialogResult.OK)
            {
                Trait = dCouleur.Color;

                Invalidate(false); // Rafraichit l'affichage
            }
        }

        private void EcranSpirographe_Load(object sender, EventArgs e)
        {

            Trait = Color.Red;
            Fond = Color.DarkBlue;

        }

        private void EcranSpirographe_Paint(object sender, PaintEventArgs e)
        {

            if(DessinSauve != null)
            {
                Rectangle r = new Rectangle(new Point(248, 0), ClientSize);

                e.Graphics.FillRectangle(new SolidBrush(Fond), r);

                e.Graphics.DrawPath(new Pen(Trait), DessinSauve);
            }
        }
    }
}
