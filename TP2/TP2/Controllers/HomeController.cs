using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TP2.Models;
using Newtonsoft.Json;

namespace TP2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Accueil()
        {
            string userString = HttpContext.Session.GetString("Utilisateur");
            Utilisateur user = JsonConvert.DeserializeObject<Utilisateur>(userString);

            ViewBag.Pseudo = user.Pseudo;
            return View();
        }

        public IActionResult ListeDeJeux()
        {
            string userString = HttpContext.Session.GetString("Utilisateur");
            Utilisateur user = JsonConvert.DeserializeObject<Utilisateur>(userString);

            ViewBag.Pseudo = user.Pseudo;
            return View();
        }

        public IActionResult Favoris()
        {
            string userString = HttpContext.Session.GetString("Utilisateur");
            Utilisateur user = JsonConvert.DeserializeObject<Utilisateur>(userString);

            ViewBag.Pseudo = user.Pseudo;

            return View();
        }

        public IActionResult FicheDeJeu(int id)
        {
            Catalogue catalogue = new Catalogue();
            catalogue.Ajouter(2, null, Environment.CurrentDirectory + "/wwwroot/json/fichierDeJeuxAuDepart.json");

            if (id >= 0 || id <= catalogue.ListeDeJeux.Count - 1)
            {

                ViewBag.NomDuJeu = catalogue.ListeDeJeux[id].NomDuJeu;
                ViewBag.TypeDeJeu = catalogue.ListeDeJeux[id].TypeDeJeu;
                ViewBag.EvaluationCote = catalogue.ListeDeJeux[id].Evaluation.Cote;
                ViewBag.EvaluationDescription = catalogue.ListeDeJeux[id].Evaluation.Description;
                ViewBag.DateProduction = catalogue.ListeDeJeux[id].DateProduction;
                ViewBag.Duree = catalogue.ListeDeJeux[id].Duree;
                ViewBag.Auteur = catalogue.ListeDeJeux[id].Auteur;
                ViewBag.Producteur = catalogue.ListeDeJeux[id].Producteur;
                ViewBag.Extrait = catalogue.ListeDeJeux[id].Extrait;
                ViewBag.Complet = catalogue.ListeDeJeux[id].Complet;
                ViewBag.Image = id+1 + ".jpg";
            }
            
            string userString = HttpContext.Session.GetString("Utilisateur");
            Utilisateur user = JsonConvert.DeserializeObject<Utilisateur>(userString);
            ViewBag.Pseudo = user.Pseudo;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}