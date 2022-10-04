using la_mia_pizzeria_model.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Diagnostics;

namespace la_mia_pizzeria_model.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Menu()
        {
            ArrayList Pizze = new ArrayList();
            Pizze.Add(new Pizza(0, "/img/MARGHERITA-1.jpg","Margerita", "Pomodori pelati, spolverata di formaggio grattugiato e fior di latte d’Agerola", 6.00f));
            Pizze.Add(new Pizza(1, "/img/MARGHERITA-1.jpg", "Diavola", "Pomodori pelati, salame piccante spolverata di formaggio grattugiato e fior di latte d’Agerola",  7.00f));
            Pizze.Add(new Pizza(2, "/img/MARGHERITA-1.jpg", "Prosciutto e Funghi", "Pomodori pelati, funghi, prosciutto spolverata di formaggio grattugiato e fior di latte d’Agerola", 8.00f));
            Pizze.Add(new Pizza(3, "/img/MARGHERITA-1.jpg", "Napoli", "Pomodori pelati, spolverata di formaggio grattugiato e fior di latte d’Agerola",  9.00f));
            Pizze.Add(new Pizza(4, "/img/MARGHERITA-1.jpg", "Emilia", "Ragu bolognese, spolverata di formaggio grattugiato e fior di latte d’Agerola",  10.00f));

            return View(Pizze);
        }

        public IActionResult Privacy()
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