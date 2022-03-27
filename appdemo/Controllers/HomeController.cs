using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using appdemo.Models;

namespace appdemo.Controllers;

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

    public IActionResult Consultar(Persona p)
    {
         p.Nombre="Juan";
         p.Apellido="Perez";
         p.Genero="Maculino";
         p.fechaVencimiento=new DateTime();
        ViewData["Message"]="Hola estos son mis datos";
        return View("Index",p);
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
