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
            return View();
        }

        public IActionResult ListeDeJeux()
        {
            return View();
        }

        public IActionResult Favoris()
        {
            return View();
        }

        public IActionResult FicheDeJeu()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}