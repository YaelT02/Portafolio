using Microsoft.AspNetCore.Mvc;
using Portafolio.Infrestructura;
using Portafolio.Models;
using Portafolio.Servicios;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioServicios _servicios;

        public HomeController(ILogger<HomeController> logger, IRepositorioServicios servicios)
        {
            _logger = logger;
            _servicios = servicios;
        }

        public IActionResult Index()
        {
            var proyectos = _servicios.GetProyectos().Take(3).ToList();

            var modelo = new HomeIndexVM() { Proyectos = proyectos };
            ViewBag.Edad = 21;
            return View(modelo);
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
