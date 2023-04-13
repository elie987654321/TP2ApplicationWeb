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
            Console.WriteLine(catalogue);

            if (id == 1)
            {
                ViewBag.NomDuJeu = "";
                ViewBag.TypeDeJeu = "";
                ViewBag.Evaluation = "";
                ViewBag.DateProduction = "";
                ViewBag.Duree = "";
                ViewBag.Auteur = "";
                ViewBag.Producteur = "";
                ViewBag.Extrait = "";
                ViewBag.Complet = "";
                ViewBag.Image = "1.jpg";
            }
            

            string userString = HttpContext.Session.GetString("Utilisateur");
            Utilisateur user = JsonConvert.DeserializeObject<Utilisateur>(userString);

            ViewBag.Pseudo = user.Pseudo;

            //Désérialiser

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}