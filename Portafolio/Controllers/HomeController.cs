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

        public HomeController(ILogger<HomeController> logger, ServicioUnico unico, ServicioTransitorio transitorio, ServicioDelimitado delimitado, ServicioUnico unico2, ServicioTransitorio transitorio2, ServicioDelimitado delimitado2, IRepositorioServicios servicios)
        {
            _logger = logger;
            _servicios = servicios;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Iniciamos la aplicación en el log..");
            _logger.LogError($"Ocurrio un error en el archivo {ControllerContext.ModelState}");
            _logger.LogWarning("Ocurrio un warning en el metodo Index Home");
            _logger.LogCritical("Error Critico");

            var proyectos = _servicios.GetProyectos().Take(3).ToList();
            var modelo = new HomeIndexVM() { Proyectos = proyectos };
            ViewBag.Edad = 20;
            return View(modelo);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Proyectos()
        {
            var proyectos = _servicios.GetProyectos();
            return View(proyectos);
        }

        public IActionResult Contacto()
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
