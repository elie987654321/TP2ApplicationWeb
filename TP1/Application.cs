namespace TP1
{
    public class Application
    {
        static void Main(string[] args)
        {
            String chemin = Environment.CurrentDirectory;
            String racineProjet = Directory.GetParent(chemin).Parent.Parent.FullName;
            String fichierJson = racineProjet + "/" + "catalogueDeJeux.json";
            String fichierJson2 = racineProjet + "/" + "fichierDeJeux.json";

            Catalogue catalogue = new Catalogue();

            Jeu jeu1 = new Jeu("Hogwarts Legacy : L'Héritage de Poudlard", Jeu.TypeDeJeu.Monde_Ouvert,
                new Evaluation(Evaluation.Cote.EXCELLENT, "Hogwarts Legacy : L'Héritage de Poudlard est un RPG d'action-aventure " +
                "immersif en monde ouvert. Vous pouvez prendre le contrôle et vous retrouver au centre de votre propre " +
                "aventure dans le Monde des sorciers."), new DateTime(2023, 02, 10), "Environ 35 heures",
                "Warner Bros. Games", "Avalanche Software", "https://www.youtube.com/watch?v=M8ApyJqnME0",
                "https://store.steampowered.com/app/990080/Hogwarts_Legacy_LHritage_de_Poudlard/?l=french",
                "https://www.bing.com/search?q=c%23+png+type+variable+select+png&qs=n&form=QBRE&sp=-1&ghc=1&pq=" +
                "c%23+png+type+variable+select+png&sc=9-31&sk=&cvid=8FA287FEAC2B4C03BB25637C3B5D4475&ghsh=0&ghacc=0&ghpl=");

            Jeu jeu3 = new Jeu("Hogwarts Legacy : L'Héritage de Poudlard", Jeu.TypeDeJeu.Monde_Ouvert,
                new Evaluation(Evaluation.Cote.EXCELLENT, "Hogwarts Legacy : L'Héritage de Poudlard est un RPG d'action-aventure " +
                "immersif en monde ouvert. Vous pouvez prendre le contrôle et vous retrouver au centre de votre propre " +
                "aventure dans le Monde des sorciers."), new DateTime(2023, 02, 10), "Environ 35 heures",
                "Warner Bros. Games", "Avalanche Software", "https://www.youtube.com/watch?v=M8ApyJqnME0",
                "https://store.steampowered.com/app/990080/Hogwarts_Legacy_LHritage_de_Poudlard/?l=french",
                "https://www.bing.com/search?q=c%23+png+type+variable+select+png&qs=n&form=QBRE&sp=-1&ghc=1&pq=" +
                "c%23+png+type+variable+select+png&sc=9-31&sk=&cvid=8FA287FEAC2B4C03BB25637C3B5D4475&ghsh=0&ghacc=0&ghl=");

            Jeu jeu2 = new Jeu("Winnie de", Jeu.TypeDeJeu.Crime,
                new Evaluation(Evaluation.Cote.EXCELLENT, "all L'Héritage de Poudlard est un RPG d'action-aventure " +
                "immersif en monde ouvert. Vous pouvez prendre le contrôle et vous retrouver au centre de votre propre " +
                "aventure dans le Monde des sorciers."), new DateTime(2023, 02, 10), "Environ 35 heures",
                "Warner Bros. Games", "Avalanche Software", "https://www.youtube.com/watch?v=M8ApyJqnME0",
                "https://store.steampowered.com/app/990080/Hogwarts_Legacy_LHritage_de_Poudlard/?l=french",
                "https://www.bing.com/search?q=c%23+png+type+variable+select+png&qs=n&form=QBRE&sp=-1&ghc=1&pq=" +
                "c%23+png+type+variable+select+png&sc=9-31&sk=&cvid=8FA287FEAC2B4C03BB25637C3B5D4475&ghsh=0&ghacc=0&ghpl=");

            catalogue.Ajouter(jeu1, "sd");
            catalogue.Ajouter(jeu2, null);

            catalogue.Sauvegarder(fichierJson);





        }
    }
}