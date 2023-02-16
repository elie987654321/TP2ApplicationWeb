using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class Jeu
    {
        // Enumeration
        public enum TypeDeJeu {
            
        }

        // Attributs
        private string nomDuJeu;
        private TypeDeJeu typeDeJeu;
        private Evaluation evaluation;
        private DateTime dateProduction;
        private string duree;
        private string auteur;
        private string producteur;
        private string extrait;
        private string complet;
        private string image;

        // Accesseurs et mutateurs
        public string NomDuJeu { get => nomDuJeu; set => nomDuJeu = value; }
        private TypeDeJeu TypeDeJeu1 { get => typeDeJeu; set => typeDeJeu = value; }
        internal Evaluation Evaluation { get => evaluation; set => evaluation = value; }
        public DateTime DateProduction { get => dateProduction; set => dateProduction = value; }
        public string Duree { get => duree; set => duree = value; }
        public string Auteur { get => auteur; set => auteur = value; }
        public string Producteur { get => producteur; set => producteur = value; }
        public string Extrait { get => extrait; set => extrait = value; }
        public string Complet { get => complet; set => complet = value; }
        public string Image { get => image; set => image = value; }

 


        // Constructeur par defaut
        public Jeu()
        {
            this.nomDuJeu = "";
            this.TypeDeJeu1 = new TypeDeJeu();
            this.evaluation = new Evaluation();
            this.DateProduction = new DateTime();
            this.Duree = "";
            this.Auteur = "";
            this.Producteur = "";
            this.Extrait = "";
            this.Complet = "";
            this.Image = "";
        }

        // Constructeur complet
        public Jeu(string nomDuJeu, TypeDeJeu typeDeJeu, Evaluation evaluation, DateTime dateProduction, string duree, string auteur, string producteur, string extrait, string complet, string image)
        {
            this.nomDuJeu = nomDuJeu;
            this.typeDeJeu = typeDeJeu;
            this.evaluation = evaluation;
            this.dateProduction = dateProduction;
            this.duree = duree;
            this.auteur = auteur;
            this.producteur = producteur;
            this.extrait = extrait;
            this.complet = complet;
            this.image = image;
        }


        // Constructeur avec le nom du jeu seul
        public Jeu(string nomDuJeu)
        {
            this.NomDuJeu = nomDuJeu;
        }

        // Comparaison
        public static bool operator==(Jeu jeu1, Jeu jeu2)
        {
           return jeu1.NomDuJeu == jeu2.NomDuJeu;
        }

        public static bool operator!=(Jeu jeu1, Jeu jeu2)
        {
            return jeu1.NomDuJeu == jeu2.NomDuJeu;
        }

        // ToString
        public override string ToString() {
            return NomDuJeu.ToString();
        }
    }
}
