namespace TP1
{
    public class Application
    {
        static void Main(string[] args)
        {
            // Fichiers JSON
            String chemin = Environment.CurrentDirectory;
            String racineProjet = Directory.GetParent(chemin).Parent.Parent.FullName;
            String fichierJson1 = racineProjet + "/" + "catalogueDeJeux.json";
            String fichierJson2 = racineProjet + "/" + "fichierDeJeux.json";

            // Notre catalogue
            Catalogue catalogue = new Catalogue();

            // Nos 10 jeux
            Jeu jeu1 = new Jeu("Hogwarts Legacy : L'Héritage de Poudlard", Jeu.TypeJeu.Monde_Ouvert,
                new Evaluation(Evaluation.CoteDeJeu.EXCELLENT, "Hogwarts Legacy : L'Héritage de Poudlard est un RPG d'action-aventure " +
                "immersif en monde ouvert. Vous pouvez prendre le contrôle et vous retrouver au centre de votre propre " +
                "aventure dans le Monde des sorciers."), new DateTime(2023, 02, 10), "Environ 35 heures",
                "Warner Bros. Games", "Avalanche Software", "https://www.youtube.com/watch?v=M8ApyJqnME0",
                "https://store.steampowered.com/app/990080/Hogwarts_Legacy_LHritage_de_Poudlard/?l=french",
                "https://w0.peakpx.com/wallpaper/461/931/HD-wallpaper-hogwarts-legacy-poster.jpg");

            Jeu jeu2 = new Jeu("Borderlands 3", Jeu.TypeJeu.FPS,
                new Evaluation(Evaluation.CoteDeJeu.TRES_BON, "Le shooter-looter est de retour avec ses trilliards de flingues pour une aventure " +
                "complètement folle ! Affrontez de nouveaux mondes et ennemis dans la peau de l'un des quatre Chasseurs " +
                "de l'Arche proposés, avec chacun ses propres compétences et options de personnalisation."), new DateTime(2020, 03, 13), "Environ 35 heures",
                "2K", "Gearbox Software", "https://www.youtube.com/watch?v=zW8rXQnKirE",
                "https://store.steampowered.com/app/397540/Borderlands_3/",
                "https://images5.alphacoders.com/100/thumb-1920-1004495.jpg");

            Jeu jeu3 = new Jeu("Stardew Valley", Jeu.TypeJeu.Simulation_De_Ferme, new Evaluation(Evaluation.CoteDeJeu.EXCELLENT, "Vous " +
                "avez hérité de l’ancienne parcelle de ferme de votre grand-père à Stardew Valley. Armé d’outils à la main et de " +
                "quelques pièces de monnaie, vous avez entrepris de commencer votre nouvelle vie. Pouvez-vous apprendre à vivre de " +
                "la terre et à transformer ces champs envahis par la végétation en une habitation prospère?"), new DateTime(2016, 02, 21), 
                "Environ 52 heures", "ConcernedApe", "ConcernedApe", "https://www.youtube.com/watch?v=ot7uXNQskhs", 
                "https://store.steampowered.com/app/413150/Stardew_Valley/", 
                "https://www.researchgate.net/publication/342704239/figure/fig1/AS:960471637192707@1606005691630/Stardew-Valley-promotional-image-Sourcewwwstardewvalleynet-Image-copyright-Eric-Barone.jpg");

            Jeu jeu4 = new Jeu("Valheim", Jeu.TypeJeu.Survie, new Evaluation(Evaluation.CoteDeJeu.EXCELLENT, "Un jeu multijoueur brutal " +
                "d'exploration et de survie pour 1 à 10 joueurs, prenant place dans un purgatoire en génération procédurale inspiré " +
                "par la culture viking. Combattez, bâtissez et accomplissez des exploits à la gloire d'Odin!"), new DateTime(2021, 02, 2), "Environ 75 heures", "Coffee Stain Publishing",
                "Iron Gate AB", "https://www.youtube.com/watch?v=liQLtCLq3tc", "https://store.steampowered.com/app/892970/Valheim/", 
                "https://preview.redd.it/cb6vhjj30ap61.gif?format=png8&s=7fede5f0fb30bd3aa14dfdb16eb56e8e8412dedc");

            Jeu jeu5 = new Jeu("Atomic Heart", Jeu.TypeJeu.Horreur, new Evaluation(Evaluation.CoteDeJeu.TRES_BON, "Dans un monde " +
                "dystopique aussi déjanté que sublime, armez-vous de votre gant de pouvoirs, de votre arsenal d’armes blanches " +
                "et de votre artillerie à la pointe de la technologie, et lancez-vous dans des affrontements explosifs et mortellement nerveux."), new DateTime(2023, 2 ,20),
                 "Environ 25 heures", "Focus Entertainment", "Mundfish",
                 "https://www.youtube.com/watch?v=h8F4hnR1FoE", "https://store.steampowered.com/app/668580/Atomic_Heart/",
                 "https://news.xbox.com/en-us/wp-content/uploads/sites/2/2022/12/ATOMIC-_HEART_Store_Featured_JPG-af8c6994d37e4bfb590d.jpg");

            Jeu jeu6 = new Jeu("Returnal", Jeu.TypeJeu.Roguelike, new Evaluation(Evaluation.CoteDeJeu.TRES_BON, "BRISEZ LE CYCLE Combattez pour votre survie dans ce jeu de tir à " +
                "la troisième personne récompensé qui apporte l'histoire de Selene. Affrontez les défis du genre roguelike. Faites face à vos ennemis " +
                "dans un déluge de balles. Voyagez dans Returnal™ avec un autre joueur."), new DateTime(2023, 2, 15), "Environ 19 heures", "PlayStation PC LLC",
                "Housemarque", "https://www.youtube.com/watch?v=BcnRCjHViLw", "https://store.steampowered.com/app/1649240/Returnal/",
                "https://images.alphacoders.com/113/thumb-1920-1137684.jpg");

            Jeu jeu7 = new Jeu("Sid Meier’s Civilization VI", Jeu.TypeJeu.Strategie, new Evaluation(Evaluation.CoteDeJeu.TRES_BON, 
                "Civilization VI est le dernier épisode de la franchise éponyme, récompensée de nombreuses " +
                "fois. Repoussez les frontières de votre empire, développez votre patrimoine culturel " +
                "et affrontez les plus grands seigneurs de l'histoire. Votre civilisation tiendra-t-elle face aux ravages du temps ?"), new DateTime(2016,10,21),
                "Environ 22 heures", "2K", "Firaxis Games",
                "https://www.youtube.com/watch?v=5KdE0p2joJw",
                "https://store.steampowered.com/app/289070/Sid_Meiers_Civilization_VI/",
                "https://i0.wp.com/mynintendonews.com/wp-content/uploads/2018/09/civilization_vi.jpg?fit=1500%2C1000&ssl=1");

            Jeu jeu8 = new Jeu("NBA 2K23", Jeu.TypeJeu.Sport, new Evaluation(Evaluation.CoteDeJeu.MOYEN, "Soyez à la " +
                "hauteur de ce qu’on attend de vous dans NBA 2K23. Le mode scénario permet de suivre votre joueur" +
                ", qui sera surnommé MP, tout au long de sa carrière de basketball."), new DateTime(2022,9,8),
                "Environ 12 heures", "2K", "Visual Concepts",
                "https://www.youtube.com/watch?v=vE_oLyx25IU",
                "https://store.steampowered.com/app/1919590/NBA_2K23/",
                "https://nba2kw.com/wp-content/uploads/2022/06/nba-2k23-cover-athlete-devin-booker-standard-edition.jpg");

            Jeu jeu9 = new Jeu("Grand Theft Auto V", Jeu.TypeJeu.Crime, new Evaluation(Evaluation.CoteDeJeu.TRES_BON, "Grand Theft Auto V offre aux joueurs la " +
                "possibilité d'explorer le monde de Los Santos et Blaine County et ses crimes."), new DateTime(2015,4,14),
                "Environ 31 heures", "Rockstar Games", "Rockstar North",
                "https://www.youtube.com/watch?v=0hNYgYXhWkM",
                "https://store.steampowered.com/app/271590/Grand_Theft_Auto_V/",
                "https://media.rockstargames.com/rockstargames/img/global/news/upload/actual_1364906194.jpg");

            Jeu jeu10 = new Jeu("Resident Evil Village", Jeu.TypeJeu.Horreur, new Evaluation(Evaluation.CoteDeJeu.EXCELLENT, "Survie et épouvante atteignent des sommets " +
                "dans le 8e titre de la franchise Resident " +
                "Evil : Resident Evil Village. Graphismes ultra-détaillés, " +
                "action intense en vue subjective et récit palpitant : la peur n'a jamais été aussi palpable."), new DateTime(2021,5,7),
                "Environ 9 heures", "CAPCOM Co., Ltd.", "CAPCOM Co., Ltd.",
                "https://www.youtube.com/watch?v=tjfTxFzGh3Q",
                "https://store.steampowered.com/app/1196590/Resident_Evil_Village/",
                "https://www.residentevil.com/village/assets/images/common/share.png");

            // Des utilisateurs
            Utilisateur utilisateur1 = new Utilisateur("Allo123", "pepitoMan", "abc123", "Jacques", "Jean", Utilisateur.RoleDUtilisateur.Utilisateur);
            Utilisateur utilisateur2 = new Utilisateur("Motor3", "Gregan", "password123", "Poisson", "George", Utilisateur.RoleDUtilisateur.Utilisateur);
            Utilisateur utilisateur3 = new Utilisateur("Lien113", "Millan", "Soleil01", "Alie", "Mimi", Utilisateur.RoleDUtilisateur.Utilisateur);

            // Des admins
            Utilisateur admin1 = new Utilisateur("monchar6", "BMWBOY", "doih543243", "Deschamps", "Jeff", Utilisateur.RoleDUtilisateur.Admin);
            Utilisateur admin2 = new Utilisateur("Masdie1", "MadameLo", "asfd190f", "Chabot", "Morice", Utilisateur.RoleDUtilisateur.Admin);

            // Des techniciens
            Utilisateur technicien1 = new Utilisateur("verugo", "VeryGood", "4325fv0", "Moutar", "Dominique", Utilisateur.RoleDUtilisateur.Technicien);
            Utilisateur technicien2 = new Utilisateur("pauulll24", "PaulCool", "fdgo2937", "Frappier", "Paul", Utilisateur.RoleDUtilisateur.Technicien);

            // Ajout des 10 jeux au catalogue
            catalogue.Ajouter(2, null, fichierJson2);

            Console.WriteLine("Les jeux du catalogue");
            Console.WriteLine(catalogue);
            catalogue.Sauvegarder(fichierJson2);

            utilisateur1.AjouterEvaluation(new Evaluation(Evaluation.CoteDeJeu.EXCELLENT, jeu1.Evaluation.Description));
            utilisateur2.AjouterEvaluation(new Evaluation(Evaluation.CoteDeJeu.MAUVAIS, jeu2.Evaluation.Description));

            jeu1.AjouterEvaluationCote(utilisateur1.Evaluations);
            Console.WriteLine(jeu1.MoyenneEvaluations());

        }
    }
}