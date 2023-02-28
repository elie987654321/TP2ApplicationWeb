namespace TP1
{
    public class Jeu
    {
        // Enumeration
        public enum TypeJeu
        {
            Monde_Ouvert,
            FPS,
            Simulation_De_Ferme,
            Survie,
            Horreur,
            Roguelike,
            Strategie,
            Sport,
            Crime
        }

        // Attributs
        private string nomDuJeu;
        private TypeJeu typeDeJeu;
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
        public TypeJeu TypeDeJeu { get => typeDeJeu; set => typeDeJeu = value; }
        public Evaluation Evaluation { get => evaluation; set => evaluation = value; }
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
            this.TypeDeJeu = new TypeJeu();
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
        public Jeu(string nomDuJeu, TypeJeu typeDeJeu, Evaluation evaluation, DateTime dateProduction, string duree, string auteur, string producteur, string extrait, string complet, string image)
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
        public static bool operator ==(Jeu jeu1, Jeu jeu2)
        {
            return jeu1.NomDuJeu == jeu2.NomDuJeu;
        }

        public static bool operator !=(Jeu jeu1, Jeu jeu2)
        {
            return jeu1.NomDuJeu != jeu2.NomDuJeu;
        }

        // ToString
        public override string ToString()
        {
            return $"{this.nomDuJeu} :\n" +
                $"   Type de jeu - {this.typeDeJeu}\n" +
                $"   Evaluation - {this.evaluation}\n" +
                $"   Date de production - {this.dateProduction}\n" +
                $"   Duree - {this.duree}\n" +
                $"   Auteur - {this.auteur}\n" +
                $"   Producteur - {this.Producteur}\n" +
                $"   Lien de l'extrait - {this.extrait}\n" +
                $"   Lien vers le jeu complet - {this.complet}\n" +
                $"   Lien vers l'image - {this.Image}\n";
        }
    }
}
