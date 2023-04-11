using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TP2.Models
{
    public class ListeUtilisateurs
    {
        private  List<Utilisateur> liste;

        public ListeUtilisateurs()
        {
            liste = new List<Utilisateur>();
        }

        public void Sauvegarder(string fichier)
        {
            string invalide = "Votre fichier n'est pas valide, veuillez entrez un fichier valide";

            if (System.IO.Path.HasExtension(fichier))
            {
                if (File.Exists(fichier))
                {
                    string json = JsonConvert.SerializeObject(this.liste, Formatting.Indented, new StringEnumConverter());
                    File.WriteAllText(@fichier, json);
                    Console.WriteLine("La sauvegarde a bien ete effectue");
                }
                else
                {
                    Console.WriteLine(invalide);

                }
            }
            else
            {
                Console.WriteLine(invalide);
            }
        }

        public void Charger(string fichier)
        {
           this.liste = JsonConvert.DeserializeObject<List<Utilisateur>>(File.ReadAllText(@fichier));
        }

        public void AjouterUtilisateur(Utilisateur utilisateur)
        {
            this.liste.Add(utilisateur);
        }

        public void SupprimerUtilisateur(string identifiantUnique)
        {
            this.liste = (List<Utilisateur>)
                        ( from x in this.liste
                         where x.IdentifiantUnique != identifiantUnique
                         select x);
        }


        //Retourne null si l'utilisateur la combinaison pseudo/mot de passe ne correspond a aucun utilisateur
        public Utilisateur Connexion(string pseudo, string motDePasse)
        {
            int i = 0;
            Utilisateur u ;

            do {
                u = this.liste[i];
                i++;
            } while ((!(u.Pseudo == pseudo && u.MotDePasse == motDePasse)) && i < liste.Count - 1);

            return u;
        }
    }
}
