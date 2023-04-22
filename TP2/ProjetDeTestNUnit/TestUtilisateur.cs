
using TP1;

namespace TestUtilisateur
{
    public class TestUtilisateur
    {
        Utilisateur utilisateur;

        [SetUp]
        public void Init()
        {
            this.utilisateur = new Utilisateur("1445133", "wwwcom", "2357", "poirier", "elie", Utilisateur.RoleDUtilisateur.Utilisateur);
        }

        [Test]
        public void TestAjouterFavori()
        {
            this.utilisateur.AjouterFavori(new Jeu());
            Assert.AreEqual(1, this.utilisateur.Favoris.Count());
        }

        [Test]
        public void TestAjouterEvaluation()
        {
            this.utilisateur.AjouterEvaluation(new Evaluation());
            Assert.AreEqual(1, this.utilisateur.Evaluations.Count());
        }
    }
}
