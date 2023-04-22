using TP1;

namespace TestProject1
{
    public class TestJeu
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestOperateurEgaliteRetourneVraisSiMemeNomDeJeu()
        {
            Jeu jeuTest1 = new Jeu();
            jeuTest1.NomDuJeu = "Jeu de test";

            Jeu jeuTest2 = new Jeu();
            jeuTest2.NomDuJeu = "Jeu de test";

            Assert.That(jeuTest1 == jeuTest2);
        }

        [Test]
        public void TestOperateurEgaliteRetourneFauxSiPasMemeNomDeJeu()
        {
            Jeu jeuTest1 = new Jeu();
            jeuTest1.NomDuJeu = "Jeu de test";

            Jeu jeuTest2 = new Jeu();
            jeuTest2.NomDuJeu = "Jeux de testes";

            Assert.That(jeuTest1 != jeuTest2);
        }

    }


}