using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AplicacionWebVersionada.Models;

namespace AplicacionWebVersionada.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    /// <summary>
    /// Esta es una prueba de la version 1.0.0
    /// </summary>
    /// <returns> comentario </returns>
    public IActionResult Index()
    {
        return View();
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
