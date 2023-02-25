using NUnit.Framework;
using TP1;

namespace TestCatalogue
{
    public class TestCatalogue
    {
        //Jeux d'essais
        Catalogue catalogue;
        Jeu jeu1, jeu2;

        [SetUp]
        public void Setup()
        {
            //jeux valides pour chacun des constructeurs
            catalogue = new Catalogue();

            jeu1 = new Jeu("Hogwarts Legacy : L'Héritage de Poudlard", Jeu.TypeDeJeu.Monde_Ouvert,
                new Evaluation(Evaluation.Cote.EXCELLENT, "Hogwarts Legacy : L'Héritage de Poudlard est un RPG d'action-aventure " +
                "immersif en monde ouvert. Vous pouvez prendre le contrôle et vous retrouver au centre de votre propre " +
                "aventure dans le Monde des sorciers."), new DateTime(2023, 02, 10), "Environ 35 heures",
                "Warner Bros. Games", "Avalanche Software", "https://www.youtube.com/watch?v=M8ApyJqnME0",
                "https://store.steampowered.com/app/990080/Hogwarts_Legacy_LHritage_de_Poudlard/?l=french",
                "https://w0.peakpx.com/wallpaper/461/931/HD-wallpaper-hogwarts-legacy-poster.jpg");

            jeu2 = new Jeu("Borderlands 3", Jeu.TypeDeJeu.FPS,
                new Evaluation(Evaluation.Cote.TRES_BON, "Le shooter-looter est de retour avec ses trilliards de flingues pour une aventure " +
                "complètement folle ! Affrontez de nouveaux mondes et ennemis dans la peau de l'un des quatre Chasseurs " +
                "de l'Arche proposés, avec chacun ses propres compétences et options de personnalisation."), new DateTime(2020, 03, 13), "Environ 35 heures",
                "2K", "Gearbox Software", "https://www.youtube.com/watch?v=zW8rXQnKirE",
                "https://store.steampowered.com/app/397540/Borderlands_3/",
                "https://images5.alphacoders.com/100/thumb-1920-1004495.jpg");
        }

        [Test]
        public void TestCatalogueSucces()
        {
            // Le catalogue commence vide
            Assert.IsTrue(catalogue.ToString().Equals(""));

        }

        [Test]
        public void TestCatalogueAjouter()
        {
            // Ajoute un jeu dans le catalogue si 1
            catalogue.Ajouter(1, jeu1, null);


        }

        [Test]
        public void TestCatalogueSauvegarder()
        {


        }

        [Test]
        public void TestCatalogueSupprimer()
        {

   
        }

        [Test]
        public void TestCatalogueModifier()
        {


        }

        [Test]
        public void TestCatalogueToString()
        {
            catalogue.Ajouter(1, jeu1, null);
            Assert.IsTrue(catalogue.ToString().Equals("Hogwarts Legacy : L'Héritage de Poudlard :\r\n   " +
                "Type de jeu - Monde_Ouvert\r\n   Evaluation - EXCELLENT, Hogwarts Legacy : L'Héritage de Poudlard est " +
                "un RPG d'action-aventure immersif en monde ouvert. Vous pouvez prendre le contrôle et vous " +
                "retrouver au centre de votre propre aventure dans le Monde des sorciers.\r\n   " +
                "Date de production - 2/10/2023 12:00:00 AM\r\n   Duree - Environ 35 heures\r\n   " +
                "Auteur - Warner Bros. Games\r\n   Producteur - Avalanche Software\r\n   " +
                "Lien de l'extrait - https://www.youtube.com/watch?v=M8ApyJqnME0\r\n   Lien vers le jeu complet " +
                "- https://store.steampowered.com/app/990080/Hogwarts_Legacy_LHritage_de_Poudlard/?l=french\r\n   " +
                "Lien vers l'image - https://w0.peakpx.com/wallpaper/461/931/HD-wallpaper-hogwarts-legacy-poster.jpg"));
        }
    }
}