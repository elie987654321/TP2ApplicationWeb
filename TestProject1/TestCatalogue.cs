using NUnit.Framework;
using TP1;
using File = System.IO.File;

namespace TestCatalogue
{
    public class TestCatalogue
    {
        //Jeux d'essais
        Catalogue catalogue;
        Jeu jeu1, jeu2;
        String chemin;
        String racineProjet;
        String fichierJson1;
        string fileContents;

        [SetUp]
        public void Setup()
        {


            //jeux valides pour chacun des constructeurs
            catalogue = new Catalogue();
            chemin = Environment.CurrentDirectory;
            racineProjet = Directory.GetParent(chemin).Parent.Parent.FullName;
            fichierJson1 = racineProjet + "/" + "Test.json";
            fileContents = File.ReadAllText(fichierJson1);

            jeu1 = new Jeu("Hogwarts Legacy : L'Héritage de Poudlard", Jeu.TypeJeu.Monde_Ouvert,
                new Evaluation(Evaluation.CoteDeJeu.EXCELLENT, "Hogwarts Legacy : L'Héritage de Poudlard est un RPG d'action-aventure " +
                "immersif en monde ouvert. Vous pouvez prendre le contrôle et vous retrouver au centre de votre propre " +
                "aventure dans le Monde des sorciers."), new DateTime(2023, 02, 10), "Environ 35 heures",
                "Warner Bros. Games", "Avalanche Software", "https://www.youtube.com/watch?v=M8ApyJqnME0",
                "https://store.steampowered.com/app/990080/Hogwarts_Legacy_LHritage_de_Poudlard/?l=french",
                "https://w0.peakpx.com/wallpaper/461/931/HD-wallpaper-hogwarts-legacy-poster.jpg");

            jeu2 = new Jeu("Borderlands 3", Jeu.TypeJeu.FPS,
                new Evaluation(Evaluation.CoteDeJeu.TRES_BON, "Le shooter-looter est de retour avec ses trilliards de flingues pour une aventure " +
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
            Assert.IsTrue(catalogue.ToString().Contains(jeu1.ToString()));

            // Ajoute une liste de jeux dans le catalogue si 2
            catalogue.Ajouter(2, null, fichierJson1);
            Assert.IsTrue(catalogue.ToString().Contains(jeu1.ToString()));
            Assert.IsTrue(catalogue.ToString().Contains(jeu2.ToString()));
            Console.WriteLine(catalogue.ToString());

        }

        [Test]
        public void TestCatalogueSauvegarder()
        {
            // Ajoute un jeu dans le catalogue si 1
            catalogue.Ajouter(1, jeu2, null);
            catalogue.Sauvegarder(fichierJson1);

        }

        [Test]
        public void TestCatalogueSupprimer()
        {
            // supprimer un jeu
            catalogue.Ajouter(1, jeu1, null);
            Assert.IsTrue(catalogue.ToString().Contains(jeu1.ToString()));
            catalogue.Supprimer(1, "Hogwarts Legacy : L'Héritage de Poudlard");

            // supprimer tous les jeux
            catalogue.Ajouter(1, jeu1, null);
            catalogue.Ajouter(1, jeu2, null);
            Assert.IsTrue(catalogue.ToString().Contains(jeu1.ToString()));
            Assert.IsTrue(catalogue.ToString().Contains(jeu2.ToString()));
            catalogue.Supprimer(2, null);
            Assert.IsTrue(catalogue.ToString().Contains(""));

        }

        [Test]
        public void TestCatalogueModifier()
        {
            catalogue.Ajouter(1, jeu1, null);
            Assert.IsTrue(catalogue.ToString().Contains(jeu1.ToString()));
            Assert.IsFalse(catalogue.ToString().Contains(jeu2.ToString()));
            catalogue.Modifier("Hogwarts Legacy : L'Héritage de Poudlard", jeu2);
            Assert.IsTrue(catalogue.ToString().Contains(jeu2.ToString()));
            Assert.IsFalse(catalogue.ToString().Contains(jeu1.ToString()));

        }

        [Test]
        public void TestCatalogueToString()
        {
            catalogue.Ajouter(1, jeu1, null);
            Assert.IsTrue(catalogue.ToString().Equals(
                $"{jeu1.NomDuJeu} :\n" +
                $"   Type de jeu - {jeu1.TypeDeJeu}\n" +
                $"   Evaluation - {jeu1.Evaluation}\n" +
                $"   Date de production - {jeu1.DateProduction}\n" +
                $"   Duree - {jeu1.Duree}\n" +
                $"   Auteur - {jeu1.Auteur}\n" +
                $"   Producteur - {jeu1.Producteur}\n" +
                $"   Lien de l'extrait - {jeu1.Extrait}\n" +
                $"   Lien vers le jeu complet - {jeu1.Complet}\n" +
                $"   Lien vers l'image - {jeu1.Image}\n"));

        }
    }
}