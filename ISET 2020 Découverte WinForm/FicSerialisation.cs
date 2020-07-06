using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization; //namespace pour faire de la sérialisation
using System.Xml; //Permet de manipuler du XML
using System.IO; //Input Output

namespace ISET_2020_Découverte_WinForm
{
    public partial class EcranSerialisation : Form
    {
        public EcranSerialisation()
        {
            InitializeComponent();
        }
        #region classe preparee
        private void bClassePreparer_Click(object sender, EventArgs e)
        {
            PersonneSerialisable ps = new PersonneSerialisable(1,"Largo","Winch", new DateTime(1975, 7, 15));
            ps.Lst.Add("Danitza");
            ps.Lst.Add("Charity");
            ps.Lst.Add("Marylin");
            ps.SerialiserFichier("ClassePreparee.xml"); // Nom de sFichier, tout le contenu de ps est envoyé pour être sérialiser

            PersonneSerialisable psbis = PersonneSerialisable.DeserialiserFichier("ClassePreparee.xml"); //Récupére les infos désérialiser

            MessageBox.Show("Vérification : " + psbis.Prenom + " " + psbis.Nom + " (" + psbis.ID.ToString() + ")"); //Affiche des variables

            for (int i = 0; i < psbis.Lst.Count; i++)
                MessageBox.Show("Conquête " + (1 + i).ToString() + " : " + psbis.Lst[i]); //Affiches les éléments de la liste
        }

        [Serializable]
        //Indique que la classe en dessous est sérialisable
        [XmlRoot()]
        //Fait apparaitre les données encodées sous forme de noeud dans le fichier xml
        public class PersonneSerialisable
        {//Classe utilisé pour la sérialisation

            [XmlAttribute("Identifiant")] //Désigne une classe comme propriété dans le fichier xml, la classe utilisée n'apparaitra pas comme un champ (ID)
            public int ID { get; set; }
            //Utiliser les propriété pour sérialiser, compliqué avec seulements les champs

            [XmlElement("Prénom")] //Considére la classe comme un champ utilisé dans le fichier xml
            public string Prenom { get; set; }

            [XmlElement("Nom")]
            public string Nom { get; set; }

            [XmlIgnore] //Ignore la classe, n'apparait pas dans le fichier xlm
            public DateTime Naissance { get; set; }

            [XmlArray("Liste")] //liste de champ

            [XmlArrayItem("Conquête")] //Objet dans la liste
            public List<string> Lst { get; set; }

            public PersonneSerialisable()
            {//Constructeur par défaut qui va instancier la liste

                Lst = new List<string>();
            }

            public PersonneSerialisable(int ID_, string Pre_, string Nom_, DateTime Nai_) : this()
            {//Constructeur avec paramètre
                ID = ID_;
                Prenom = Pre_;
                Nom = Nom_;
                Naissance = Nai_;
            }

            public void SerialiserFichier(string sFichier)
            {
                using (StreamWriter sw = new StreamWriter(sFichier)) //Ouverture du flux du fichier pour écrire les données dedans
                {
                    XmlSerializer xs = new XmlSerializer(this.GetType());
                    //Permet de sérialiser ou désérialiser des objets vers ou depuis xml, type de l'objet en argument

                    xs.Serialize(sw, this); //Envoie les données dans le fichier à l'aide du serialiseur
                                            //Argument 1 fichier où l'on sérialise, argument 2 données à sérialiser

                    sw.Close();
                }
            }

            public static PersonneSerialisable DeserialiserFichier(string sFichier)
            {
                using (StreamReader sr = new StreamReader(sFichier)) //Lis les données dans le fichier pour les transmettre à une classe
                {
                    XmlSerializer xs = new XmlSerializer(typeof(PersonneSerialisable));

                    PersonneSerialisable oTmp = (PersonneSerialisable) xs.Deserialize(sr);
                    //Serialiseur renvoie n'importe quoi, un cast est nécessaire pour récupérer nos données personneSerialisable

                    sr.Close();

                    return (oTmp); //renvoie les données récupérée
                }
                    
            }

        }

        #endregion

        public class Personne
        {
            public int ID { get; set; }
            //Utiliser les propriété pour sérialiser, compliqué avec seulements les champs
            public string Prenom { get; set; }
            public string Nom { get; set; }
            public DateTime Naissance { get; set; }
            public List<string> Lst { get; set; }

            public Personne()
            {//Constructeur par défaut qui va instancier la liste

                Lst = new List<string>();
            }

            public Personne(int ID_, string Pre_, string Nom_, DateTime Nai_) : this()
            {//Constructeur avec paramètre
                ID = ID_;
                Prenom = Pre_;
                Nom = Nom_;
                Naissance = Nai_;
            }
        }

        #region hard
        private void bHardSerialiser_Click(object sender, EventArgs e)
        {
            Personne p = new Personne(1, "Youssef", "Winch", new DateTime(1975, 7, 15));

            p.Lst.Add("Danitza");
            p.Lst.Add("Charity");
            p.Lst.Add("Marylin");

            SerialiserHard("Hard.xml", p); // Nom de sFichier, tout le contenu de ps est envoyé pour être sérialiser

            Personne pbis = DeserialiserHard("Hard.xml"); //Récupére les infos désérialiser

            MessageBox.Show("Vérification : " + pbis.Prenom + " " + pbis.Nom + " (" + pbis.ID.ToString() + ")"); //Affiche des variables

            for (int i = 0; i < pbis.Lst.Count; i++)
                MessageBox.Show("Conquête" + (1 + i).ToString() + " : " + pbis.Lst[i]); //Affiches les éléments de la liste
        }

        public void SerialiserHard(string sFichier, Personne aPer)
        {
            using (XmlTextWriter xw = new XmlTextWriter(sFichier,Encoding.UTF8))
            {//Encodage du fichier xml ainsi que le fichier dans lequel on veut sauver les données

                xw.WriteStartDocument(); //En tête de fichier

                xw.WriteStartElement("Personne"); //Element personne de l'objet à sauver dans le fichier

                xw.WriteAttributeString("Identifiant", aPer.ID.ToString()); //écrit dans le fichier l'Attribut ID de personne

                xw.WriteAttributeString("Prénom", aPer.Prenom);

                xw.WriteAttributeString("Nom", aPer.Nom);

                xw.WriteStartElement("Liste"); //Element liste de l'objet à sauver dans le fichier

                foreach(string c in aPer.Lst) //Foreach pour écrire tout les string de la liste dans le fichier

                    xw.WriteAttributeString("Conquête", c);

                xw.WriteEndElement(); //Fin de Lst

                xw.WriteEndElement(); //Fin de Personne

                xw.WriteEndDocument(); //Fin de l'en tete

                xw.Close(); //Fermeture du fichier

            }
        }

        public Personne DeserialiserHard(string sFichier)
        {
            Personne pRep = new Personne();
            using (XmlTextReader xr = new XmlTextReader(sFichier))
            {
                while (xr.Read())
                //Tant qu'il y a quelque chose à lire dans le fichier

                    if (xr.Name == "Personne") //On rentre seulement quand on rencontre la balise personne
                    {
                        xr.MoveToAttribute("Identifiant"); //On se déplace vers l'attribut identifiant pour récupérer l'id de la personne
                        pRep.ID = xr.ReadContentAsInt(); //Récupération de l'id sous forme de int
                        xr.Read(); //Passage à l'élément suivant
                        pRep.Prenom = xr.ReadElementContentAsString(); //Va recherche la valeur et passe directement au suivant par après
                        pRep.Nom = xr.ReadElementContentAsString();

                        if (xr.Name == "Liste" && !xr.IsEmptyElement) //On vérifie que la liste est bien instanciée et qu'il y a bien des éléments dedans
                        {
                            xr.Read();

                            while (xr.Name == "Conquête")

                                pRep.Lst.Add(xr.ReadElementContentAsString()); //On ajoute les éléments de la liste tant qu'il y en a dans conquête                           

                        }

                        xr.Read(); //On passe à la balise suivante pour cloturer la lecture car on est dans une boucle while read()
                    }
                

                xr.Close(); //Fermeture du fichier
            }

           return pRep;
        }
        #endregion

        #region volee
        private void bSerialiserVolee_Click(object sender, EventArgs e)
        {
            Personne p = new Personne(1, "Largo", "Winch", new DateTime(1975, 7, 15));

            p.Lst.Add("Danitza");
            p.Lst.Add("Charity");
            p.Lst.Add("Marylin");

            SerialiserVolee("Volee.xml", p); // Nom de sFichier, tout le contenu de ps est envoyé pour être sérialiser

            Personne pbis = DeserialiserVolee("Volee.xml"); //Récupére les infos désérialiser

            MessageBox.Show("Vérification : " + pbis.Prenom + " " + pbis.Nom + " (" + pbis.ID.ToString() + ")"); //Affiche des variables

            for (int i = 0; i < pbis.Lst.Count; i++)
                MessageBox.Show("Conquête" + (1 + i).ToString() + " : " + pbis.Lst[i]); //Affiches les éléments de la liste
        }

        public void SerialiserVolee(string sFichier, Personne aPer)
        {
            XmlSerializer xs = new XmlSerializer(aPer.GetType()); //Permet de transmet tout les éléments de nos classes en balises xml automatiquement
            StreamWriter sw = new StreamWriter(sFichier);

            xs.Serialize(sw, aPer); //Demande de serialisation dans le flux 

            sw.Close();
        }

        public Personne DeserialiserVolee(string sFichier)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Personne)); //Permet de transmet tout les éléments de nos classes en balises xml automatiquement
            StreamReader sr = new StreamReader(sFichier);

            Personne pRep = (Personne)xs.Deserialize(sr); //Récupération des données à partir du streamreader

            sr.Close();

            return pRep;
        }
        #endregion

        #region universelle
        public class UtilitaireSerialisation //Classe générale pour s'adapter à n'importe quel classe
        {
            public static void Serialiser<T>(string sFichier, T tArg) //se base sur un type générique pour utiliser tout type de données
            {
                XmlSerializer xs = new XmlSerializer(typeof(T)); //Permet de transmet tout les éléments de nos classes en balises xml automatiquement
                StreamWriter sw = new StreamWriter(sFichier);

                xs.Serialize(sw, tArg); //Demande de serialisation dans le flux 

                sw.Close();
            }

            public static T Deserialiser<T>(string sFichier) //On travail sur un objet de type T et on le renvoi
            {
                XmlSerializer xs = new XmlSerializer(typeof(T)); //Permet de transmet tout les éléments de nos classes en balises xml automatiquement
                StreamReader sr = new StreamReader(sFichier);

                T pRep = (T)xs.Deserialize(sr); //Récupération des données à partir du streamreader

                sr.Close();

                return pRep;
            }
        }

        private void bSerialiserUniversellement_Click(object sender, EventArgs e)
        {
            List<Personne> pListe = new List<Personne>();

            Personne p = new Personne(1, "Largo", "Winch", new DateTime(1975, 7, 15));

            p.Lst.Add("Danitza");
            p.Lst.Add("Charity");
            p.Lst.Add("Marylin");

            pListe.Add(p);

            p = new Personne(2, "Simon", "Ovronnaz", new DateTime(1972, 11, 15));

            pListe.Add(p);

            UtilitaireSerialisation.Serialiser<List<Personne>>("Universel.xml", pListe);

            List<Personne> pListebis = UtilitaireSerialisation.Deserialiser<List<Personne>>("Universel.xml");

            foreach (Personne pbis in pListebis)
            {
                MessageBox.Show("Vérification : " + pbis.Prenom + " " + pbis.Nom + " (" + pbis.ID.ToString() + ")"); //Affiche des variables

                for (int i = 0; i < pbis.Lst.Count; i++)
                    MessageBox.Show("Conquête" + (1 + i).ToString() + " : " + pbis.Lst[i]); //Affiches les éléments de la liste
            }
        }
        #endregion
    }
}
