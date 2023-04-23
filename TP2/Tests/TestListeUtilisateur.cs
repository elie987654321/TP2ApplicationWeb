using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using TP2.Models;

namespace TestProject1
{
    internal class TestListeUtilisateur
    {
        string chemin;
        string racineProjet;
        string fichierJson;
        
        [SetUp]
        public void setup()
        {
            chemin = Environment.CurrentDirectory;
            racineProjet = Directory.GetParent(chemin).Parent.Parent.FullName;
            fichierJson = racineProjet + "/json/" + "fichierDeJeux.json";
        }

        private ListeUtilisateurs CreerListeUtilisateurTest()
        {
            ListeUtilisateurs liste = new ListeUtilisateurs();
            
            Utilisateur utilisateur = new Utilisateur();
            utilisateur.IdentifiantUnique = "id123";
            utilisateur.Pseudo = "haha";
            utilisateur.Prenom = "bob";
            utilisateur.Nom = "bib";
            utilisateur.MotDePasse = "abc123";

            Utilisateur utilisateur2 = new Utilisateur();
            utilisateur2.IdentifiantUnique = "id1232";
            utilisateur2.Pseudo = "haha2";
            utilisateur2.Prenom = "bob2";
            utilisateur2.Nom = "bib2";
            utilisateur2.MotDePasse = "abc1232";


            liste.AjouterUtilisateur(utilisateur);
            liste.AjouterUtilisateur(utilisateur2);
            return liste;
        }
        


        [Test]
        public void TestSauvegarderCharger()
        {
            File.WriteAllText(fichierJson, "");

            ListeUtilisateurs liste = CreerListeUtilisateurTest();
            liste.Sauvegarder(fichierJson);

            ListeUtilisateurs listeCharger = new ListeUtilisateurs();
            listeCharger.Charger(fichierJson);
            Assert.AreEqual("id123", listeCharger.Liste[0].IdentifiantUnique);
            Assert.AreEqual("haha", listeCharger.Liste[0].Pseudo);
            Assert.AreEqual("bob", listeCharger.Liste[0].Prenom);
            Assert.AreEqual("bib", listeCharger.Liste[0].Nom);
            Assert.AreEqual("abc123", listeCharger.Liste[0].MotDePasse);

            Assert.AreEqual("id1232", listeCharger.Liste[1].IdentifiantUnique);
        }

        [Test]
        public void TestAjouterUtilisateur()
        {
            ListeUtilisateurs liste = new ListeUtilisateurs();
            liste.AjouterUtilisateur(new Utilisateur("id", "pseu", "passwrd", "nom", "prenom", Utilisateur.RoleDUtilisateur.Utilisateur));
            Assert.AreEqual("id", liste.Liste[0].IdentifiantUnique);
        }


        //Methode a tester commenter car pas utilise presentement
        /*
        [Test]
        public void TestSupprimerUtilisateur()
        {
            ListeUtilisateurs liste = CreerListeUtilisateurTest();

            liste.SupprimerUtilisateur("id123");
            Assert.AreEqual(1, liste.Liste.Count);
        }*/

        [Test]
        public void TestConnexionIdentifiantExistePas()
        {
            ListeUtilisateurs liste = CreerListeUtilisateurTest();

            Utilisateur user = liste.Connexion("id1299", "abc123");
            Assert.AreEqual(user, null);
        }

        [Test]
        public void TestConnexionMotDePasseExistePas()
        {
            ListeUtilisateurs liste = CreerListeUtilisateurTest();

            Utilisateur user = liste.Connexion("id123", "abc555555555");
            Assert.AreEqual(user, null);

        }

        [Test]
        public void TestConnexionRetourneUtilisateur()
        {
            ListeUtilisateurs liste = CreerListeUtilisateurTest();

            Utilisateur user = liste.Connexion("id123", "abc123");
            Assert.AreEqual("bib", user.Nom);
        }

        [Test]
        public void TestCreerIdNull()
        {
            ListeUtilisateurs liste = new ListeUtilisateurs();

            Assert.IsFalse(liste.CreerUtilisateur(null, "pseudo", "pswd", "nom", "prenom"));
        }

        [Test]
        public void TestCreerIdVide()
        {
            ListeUtilisateurs liste = new ListeUtilisateurs();

            Assert.IsFalse(liste.CreerUtilisateur("", "pseudo", "pswd", "nom", "prenom"));
        }


        [Test]
        public void TestCreerPrenomNull()
        {
            ListeUtilisateurs liste = new ListeUtilisateurs();

            Assert.IsFalse(liste.CreerUtilisateur("id", null, "pswd", "nom", "prenom"));
        }

        [Test]
        public void TestCreerPrenomVide()
        {
            ListeUtilisateurs liste = new ListeUtilisateurs();

            Assert.IsFalse(liste.CreerUtilisateur("id", "", "pswd", "nom", "prenom"));
        }

        [Test]
        public void TestCreerNomNull()
        {
            ListeUtilisateurs liste = new ListeUtilisateurs();

            Assert.IsFalse(liste.CreerUtilisateur("id", "pseudo", "pswd", null, "prenom"));
        }

        [Test]
        public void TestCreerNomVide()
        {
            ListeUtilisateurs liste = new ListeUtilisateurs();

            Assert.IsFalse(liste.CreerUtilisateur("id", "pseudo", "pswd", "", "prenom"));
        }

        [Test]
        public void TestCreerMotDePasseNull()
        {
            ListeUtilisateurs liste = new ListeUtilisateurs();

            Assert.IsFalse(liste.CreerUtilisateur("id", "pseudo", null, "nom", "prenom"));
        }

        [Test]
        public void TestCreerMotDePasseVide()
        {
            ListeUtilisateurs liste = new ListeUtilisateurs();

            Assert.IsFalse(liste.CreerUtilisateur("id", "pseudo", "", "nom", "prenom"));
        }

        [Test]
        public void TestCreerPseudoNull()
        {
            ListeUtilisateurs liste = new ListeUtilisateurs();

            Assert.IsFalse(liste.CreerUtilisateur("id", null, "pswd", "nom", "prenom"));
        }

        [Test]
        public void TestCreerPseudoVide()
        {
            ListeUtilisateurs liste = new ListeUtilisateurs();

            Assert.IsFalse(liste.CreerUtilisateur("id", "", "pswd", "nom", "prenom"));
        }

        [Test]
        public void TestCreerIdentifiantExisteDeja()
        {
            ListeUtilisateurs liste = CreerListeUtilisateurTest();

            Assert.IsFalse(liste.CreerUtilisateur("id123", "pseudo", "pswd", "nom", "prenom"));
        }

        [Test]
        public void TestCreer()
        {
            ListeUtilisateurs liste = new ListeUtilisateurs();

            Console.WriteLine(fichierJson);
            liste.CreerUtilisateur("id123", "pseudo", "pswd", "nom", "prenom", fichierJson);
            Assert.AreEqual("id123", liste.Liste[0].IdentifiantUnique);
            Assert.AreEqual("pseudo", liste.Liste[0].Pseudo);
            Assert.AreEqual("pswd", liste.Liste[0].MotDePasse);
            Assert.AreEqual("nom", liste.Liste[0].Nom);
            Assert.AreEqual("prenom", liste.Liste[0].Prenom);
        }

        [Test]
        public void TestObtenirUtilisateurByPseudoExistePas()
        {
            ListeUtilisateurs liste = CreerListeUtilisateurTest();
            Utilisateur userTest = liste.GetUtilisateurByPseudo("id123");

            Assert.IsNull(userTest);
        }

        [Test]
        public void TestObtenirUtilisateurByPseudo()
        {
            ListeUtilisateurs liste = CreerListeUtilisateurTest();
            Utilisateur userTest = liste.GetUtilisateurByPseudo("haha");
            
            Assert.AreEqual("id123", userTest.IdentifiantUnique);
        }
    }
}
