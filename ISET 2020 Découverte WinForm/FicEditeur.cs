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
    public partial class EcranEditeur : Form
    {
        public EcranEditeur()
        {
            InitializeComponent();
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pbNouveau_Click(object sender, EventArgs e)
        {

        }


        private bool lModifie;

        private string sFichier;
       
        private void EcranEditeur_Load(object sender, EventArgs e)
        {
            lModifie = false;
            sFichier = ""; 

        }

        private void FichierEnregistrer()
        {
            if(sFichier =="")
            {//Si un fichier existe pas

                if (dEnregistrer.ShowDialog() == DialogResult.OK)

                    sFichier = dEnregistrer.FileName;
                //On envoie le nom du fichier du savedialog dans la variable sfichier pour créer le fichier
                //Le filtre et la création du fichier est gérer en graphique
            }

            if (sFichier !="")
            {
                rtbTexte.SaveFile(sFichier); //Enregistre le contenu de la box dans un fichier indiqué déjà existant (ici sfichier)
                lModifie = false;

            }

        }

        private void VerifierSauver()
        {
            if (lModifie)

                if (MessageBox.Show("Enregistrer la mise à jour ?", "Texte modifié", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    FichierEnregistrer();  
        }

        private void mfNouveau_Click(object sender, EventArgs e)
        {
            VerifierSauver(); //On demande à l'user si il veut sauvegarder
            sFichier = "";
            lModifie = false;
            rtbTexte.Clear();
            //On clear toutes les variables ainsi que la box
        }

        private void mfOuvrir_Click(object sender, EventArgs e)
        {
            VerifierSauver();

            if(dOuvrir.ShowDialog() == DialogResult.OK)
            {
                sFichier = dOuvrir.FileName; //Opendialog permettant d'ouvrir un fichier avec la bonne extension (gérer en graphique)
                rtbTexte.LoadFile(sFichier); //Methode de la rich box, charge les données du fichiers dans celle ci
            }

            lModifie = false;
        }

        private void mfEnregistrer_Click(object sender, EventArgs e)
        {
            FichierEnregistrer();
        }

        private void mfQuitter_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void rtbTexte_TextChanged(object sender, EventArgs e)
        {
            lModifie = true; //Le texte a été modifié
        }

        private void meCopier_Click(object sender, EventArgs e)
        {
            rtbTexte.Copy(); //Methode de la richbox permettant de copier  une sélection
        }

        private void meCouper_Click(object sender, EventArgs e)
        {
            rtbTexte.Cut(); //Methode de la richbox permettant de couper  une sélection
        }

        private void meColler_Click(object sender, EventArgs e)
        {
            rtbTexte.Paste(); //Methode de la richbox permettant de coller  une sélection
        }

        private void mfjGauche_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Left; //Modification de la variable d'alignement de la rich box
        }

        private void mfjDroite_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void mfjCentre_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void mfPolice_Click(object sender, EventArgs e)
        {
            if (dPolice.ShowDialog() == DialogResult.OK)
                rtbTexte.SelectionFont = new Font(dPolice.Font, dPolice.Font.Style); 
            //Ouvre une fenêtre fontdialog grâce à dPolice (graphique) permettant de modifier le font
        }

        private void mfcGras_Click(object sender, EventArgs e)
        {
            //System.Drawing.Font PoliceActuelle = rtbTexte.SelectionFont;
            //System.Drawing.FontStyle StyleNouveau;

            if (rtbTexte.SelectionFont.Bold)
            {//Le bold fonctionne comme un boleen, si il est vrai on rentre ici

                rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, rtbTexte.SelectionFont.Style ^ FontStyle.Bold);
                //On definit le texte actuel = un nouveau fond (non bold donc faux) & font bold (vrai)
                // bold actuel = faux & vrai donc faux, le texte n'est plus en bold

                //StyleNouveau = FontStyle.Regular;
            }

            else
            {//Cas où bold est faux, texte non gras

                //StyleNouveau = FontStyle.Bold;

                rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, rtbTexte.SelectionFont.Style | FontStyle.Bold);
                //On definit le texte actuel = un nouveau fond (non bold donc faux) ou font bold (vrai)
                // bold actuel = faux ou vrai donc vrai, le texte devient bold

                //rtbTexte.SelectionFont = new Font(PoliceActuelle.FontFamily, PoliceActuelle.Size, StyleNouveau);
            }
        }

        private void mfcItalique_Click(object sender, EventArgs e)
        {
            //System.Drawing.Font PoliceActuelle = rtbTexte.SelectionFont;
            //System.Drawing.FontStyle StyleNouveau;

            if (rtbTexte.SelectionFont.Italic)
            {
                //StyleNouveau = FontStyle.Regular;

                rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, rtbTexte.SelectionFont.Style ^ FontStyle.Italic);

            }

            else
            {
                //StyleNouveau = FontStyle.Italic;

                rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, rtbTexte.SelectionFont.Style | FontStyle.Italic);

                //rtbTexte.SelectionFont = new Font(PoliceActuelle.FontFamily, PoliceActuelle.Size, StyleNouveau);
            }
        }

        private void mfcSouligner_Click(object sender, EventArgs e)
        {
            //System.Drawing.Font PoliceActuelle = rtbTexte.SelectionFont;
            //System.Drawing.FontStyle StyleNouveau;

            if (rtbTexte.SelectionFont.Underline)
            {
                //StyleNouveau = FontStyle.Regular;

                rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, rtbTexte.SelectionFont.Style ^ FontStyle.Underline);
            }

            else
            {

                //StyleNouveau = FontStyle.Underline;

                rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, rtbTexte.SelectionFont.Style | FontStyle.Underline);

                // rtbTexte.SelectionFont = new Font(PoliceActuelle.FontFamily, PoliceActuelle.Size, StyleNouveau);

            }
        }

        private void EcranEditeur_FormClosing(object sender, FormClosingEventArgs e)
        {
            VerifierSauver();
        }
    }
}
