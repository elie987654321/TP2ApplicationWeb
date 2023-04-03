namespace TP2
{
    public static class Dev
    {
        public static void CreerFichierJSonUtilisateur()
        {
            String chemin = Environment.CurrentDirectory;

            Utilisateur utilisateur1 = new Utilisateur();
            utilisateur1.Prenom = "Bob";
            utilisateur1.Nom = "Bobob";
            utilisateur1.MotDePasse = "secret";
            utilisateur1.Role = Utilisateur.RoleDUtilisateur.Utilisateur;
            utilisateur1.IdentifiantUnique = "bob123";

            Evaluation eval1 = new Evaluation();
            eval1.Cote = Evaluation.CoteDeJeu.BON;
            eval1.Description = "Pas pire comme jeu";

            utilisateur1.AjouterEvaluation(eval1);

            Jeu jeu = new Jeu();
            jeu.Auteur = "Bob";
            jeu.DateProduction = DateTime.Now;
            jeu.Duree = "20192 heures";
            jeu.NomDuJeu = "Un jeu";
            jeu.Producteur = "Bob le producteur";
            jeu.TypeDeJeu = Jeu.TypeJeu.Monde_Ouvert;

            utilisateur1.AjouterFavori(jeu);

            utilisateur1.Sauvegarder(chemin + "/wwwroot/json/utilisateurs.json");
        }
    }
}
