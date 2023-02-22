using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Catalogue
    {   
        // Attribut
        private List<Jeu> listeDeJeux;

        // Constructeur par defaut
        public Catalogue()
        {
            this.listeDeJeux = new List<Jeu>();
        }

        // Methodes
        public void Ajouter(int decision, Jeu jeu, string fichier)
        {
            // Ajoute un jeu
            if (decision == 1)
            {
                this.listeDeJeux.Add(jeu);
            }
            // Ajoute une liste de jeux à partir d'un fichier json
            else if (decision == 2)
            {
                List<Jeu> l;

                l = JsonConvert.DeserializeObject<List<Jeu>>(File.ReadAllText(@fichier));

                this.listeDeJeux.AddRange(l);
            }
        }

        public void Modifier(string numeroDuJeu, Jeu jeu)
        {
            //this.listeDeJeux.Remove(numeroDuJeu);
            //this.listeDeJeux.Add(numeroDuJeu, jeu);
        }

        public void Supprimer(int decision, string numeroDuJeu)
        {
            if(decision == 1)
            {
                //this.listeDeJeux.Remove(numeroDuJeu);
            }
            else if (decision == 2)
            {
                this.listeDeJeux.Clear();
            }

        }

        public void Sauvegarder(string fichier)
        {
            string jsonListe = JsonConvert.SerializeObject(this.listeDeJeux, Formatting.Indented);
            File.WriteAllText(@fichier, jsonListe);
        }

        // ToString
        public override string ToString()
        {
            string data = "";

            foreach (Jeu jeu in this.listeDeJeux)
            {
                data += jeu.ToString() + "\n";

            }
            return data;
        }
    }
}
