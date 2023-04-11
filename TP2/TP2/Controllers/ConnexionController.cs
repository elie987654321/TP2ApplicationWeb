using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using TP2.Models;

using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace TP2.Controllers
{
    public class ConnexionController : Controller
    {

        public ActionResult Accueil()
        {

            /*
            ListeUtilisateurs listeDesUtilisateurs = new ListeUtilisateurs();
            listeDesUtilisateurs.Charger(Environment.CurrentDirectory + "/wwwroot/json/utilisateurs.json");

            Utilisateur utilisateurTrouve = listeDesUtilisateurs.Connexion(nomUtilisateur, motDePasse);
            */

            ListeUtilisateurs listeDesUtilisateurs = new ListeUtilisateurs();
            listeDesUtilisateurs.Charger(Environment.CurrentDirectory + "/wwwroot/json/utilisateurs.json");


            Utilisateur user = listeDesUtilisateurs.Connexion("Test", "secret");

            
            this.HttpContext.Session.SetString("Utilisateur", JsonConvert.SerializeObject(user));
            return RedirectToAction("Accueil", "Home");

        }

        /*
        public ActionResult Connexion(string nomUtilisateur, string motDePasse)
        {
        }*/
    }
}
