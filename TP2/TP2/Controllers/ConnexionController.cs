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
            return View();

        }

        
        public ActionResult Connexion(string nomUtilisateur, string motDePasse)
        {
            ListeUtilisateurs listeDesUtilisateurs = new ListeUtilisateurs();
            listeDesUtilisateurs.Charger(Environment.CurrentDirectory + "/wwwroot/json/utilisateurs.json");

            Utilisateur utilisateurTrouve = listeDesUtilisateurs.Connexion(nomUtilisateur, motDePasse);

            if (utilisateurTrouve != null)
            {
                this.HttpContext.Session.SetString("Utilisateur", JsonConvert.SerializeObject(utilisateurTrouve));
                return RedirectToAction("Accueil", "Home");
            }
            else
            {
                return RedirectToAction("Accueil", "Connexion");
            }
        }
    }
}
