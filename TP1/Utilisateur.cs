using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Utilisateur
    {
        // Enumeration
        public enum Role
        {
            Utilisateur,
            Admin,
            Technicien
        }

        // Attributs
        private string identifiantUnique;
        private string pseudo;
        private string motDePasse;
        private string nom;
        private string prenom;
        private Role role;
        private List<Jeu> favoris;
        private List<Evaluation> evaluations;

        // Constructeur par defaut
        public Utilisateur()
        {
            this.identifiantUnique = "";
            this.pseudo = "";
            this.motDePasse = "";
            this.nom = "";
            this.prenom = "";
            this.role = new Role();
            this.favoris = new List<Jeu>();
            this.evaluations = new List<Evaluation>();
        }

        // Constructeur complet sans les favoris et évaluations
        public Utilisateur(string identifiantUnique, string pseudo, string motDePasse, string nom, string prenom, Role role)
        {
            this.identifiantUnique = identifiantUnique;
            this.pseudo = pseudo;
            this.motDePasse = motDePasse;
            this.nom = nom;
            this.prenom = prenom;
            this.role = role;
        }

        // Methodes
        public void AjouterFavori()
        {

        }

        public void AjouterEvaluation()
        {

        }

    }
}
