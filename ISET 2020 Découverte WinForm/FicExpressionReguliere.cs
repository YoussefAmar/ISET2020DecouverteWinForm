using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; //Relatif au expression régulière

namespace ISET_2020_Découverte_WinForm
{
    public partial class EcranExpressionReguliere : Form
    {
        private bool Validite(string sExpReg) //Valide la syntaxe de l'expression reguliere
        {
            try //Si l'expression rég est correct on entre dans le return true, sinon on va dans le catch
            {
                Regex tmp = new Regex(sExpReg); //Texte de l'Expression régulière en question placée en paramètre afin de creer l'expression reguliere sous forme d'objet
                return true;
            }

            catch { return false; }
        }

        private bool Correspondance(string sExpReg, string sAVerifier, RegexOptions roParam) //Recherche de l'expression régulière dans le texte afin d'identifier une correspondance par vrai ou faux
        {
            if(Validite(sExpReg)) //Si l'expression reg est correct
            {
                Regex exp = new Regex(sExpReg, roParam);
                return exp.IsMatch(sAVerifier); //Renvoie vrai ou faux si une correspondance a été trouver avec l'expression reg 

            }

            return false; //Pas de correspondance trouvee
        }

        private MatchCollection Correspondances(string sExpReg, string sAVerifier, RegexOptions roParam) //Recherche toutes les correspondance de l'expression reg
        {

            if (Validite(sExpReg)) //Si l'expression reg est correct
            {
                Regex exp = new Regex(sExpReg, roParam);
                return exp.Matches(sAVerifier); //Recherche toutes les occurences similaire à l'expression reg
            }

            return null; //Pas de correspondance trouvee
        }

        private void MettreEnEvidence(MatchCollection mc, RichTextBox rtb) //Mets en evidence les occurences obtenues
        {
            rtb.Select(0, rtb.Text.Length); //Selectionne tout le texte de la box
            rtb.SelectionBackColor = Color.Transparent; //Colorie le fond en blanc

            foreach(Match m in mc) //pour tout les mots trouvé, on prend l'index d'où ils sont ainsi que leur longueur et on les colores en orange
            {
                rtb.Select(m.Index, m.Length);
                rtb.SelectionBackColor = Color.Orange;
            }
        }

        private string Remplacer(string sExpReg, string sAVerifier, RegexOptions roParam, string sRemplacement) //Recherche de l'expression régulière dans le texte afin de renvoier un texte de remplacement en réponse
        {
            if (Validite(sExpReg)) //Si l'expression reg est correct
            {
                Regex exp = new Regex(sExpReg, roParam);
                return exp.Replace(sAVerifier, sRemplacement); //Remplace la correspondance par le texte sRemplacement 

            }

            return "Expression régulière incorrecte"; //Pas de correspondance trouvee
        }

        private string[] Separer(string sExpReg, string sAVerifier, RegexOptions roParam) //Recherche de l'expression régulière dans le texte afin de le séparer du reste du texte
        {
            if (Validite(sExpReg)) //Si l'expression reg est correct
            {
                Regex exp = new Regex(sExpReg, roParam);
                return exp.Split(sAVerifier); //sépare la correspondance du reste du texte

            }

            return new string[] { "Expression régulière incorrecte" }; //Pas de correspondance trouvee
        }

        public EcranExpressionReguliere()
        {
            InitializeComponent();
        }

        private void tbExpressionReguliere_TextChanged(object sender, EventArgs e) //Evenement de changement de texte dans la textbox
        {
            if(cbIsValide.Checked = Validite(tbExpressionReguliere.Text)) //Si l'expression reg est valide alors la box est checké mais aussi...
            {
                cbIsCorrespondance.Checked = Correspondance(tbExpressionReguliere.Text, rtbATraiter.Text, cbIsRespectCasse.Checked ? RegexOptions.None : RegexOptions.IgnoreCase); //Respect de la casse checker ou non

                MettreEnEvidence(Correspondances(tbExpressionReguliere.Text, rtbATraiter.Text, cbIsRespectCasse.Checked ? RegexOptions.None : RegexOptions.IgnoreCase), rtbATraiter); //Mise en evidence du texte selon l'expression reg
            }
        }

        private void rtbATraiter_Leave(object sender, EventArgs e) //Lorsque je quitte la box de texte et que j'ai donc finis d'ecrire mon texte
        {
            tbExpressionReguliere_TextChanged(null, null);
        }

        private void cbIsRespectCasse_CheckedChanged(object sender, EventArgs e) //Case modifier
        {
            rtbATraiter_Leave(null, null);
        }

        private void cbRemplacer_CheckedChanged(object sender, EventArgs e) //Checkage de la case remplacement
        {
            if(Validite(tbExpressionReguliere.Text) && cbRemplacer.Checked) //Si la case est cochee et que l'expression rege est validee
            {
                MessageBox.Show(Remplacer(tbExpressionReguliere.Text, rtbATraiter.Text, cbIsRespectCasse.Checked ? RegexOptions.None : RegexOptions.IgnoreCase, tbRemplacement.Text)); //Affichage du remplacement par le texte indique
            }

            cbRemplacer.Checked = false;

        }

        private void cbSeparer_CheckedChanged(object sender, EventArgs e)
        {
            if (Validite(tbExpressionReguliere.Text) && cbSeparer.Checked) //Si la case est cochee et que l'expression rege est validee
            {
               string [] atmp = Separer(tbExpressionReguliere.Text, rtbATraiter.Text, cbIsRespectCasse.Checked ? RegexOptions.None : RegexOptions.IgnoreCase); //Affichage du remplacement par le texte indique
               
               foreach(string s in atmp)
                {
                    MessageBox.Show(s);
                }

            }

            cbSeparer.Checked = false;
        }

        private void EcranExpressionReguliere_Load(object sender, EventArgs e)
        {
            tbExpressionReguliere_TextChanged(null,null);
        }
    }
}
