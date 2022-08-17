using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExemploAspNetMvc.Models;

namespace ExemploAspNetMvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index() => View();

    public IActionResult Privacy() => View();

    public string TesteQueryString([FromQuery]string q, [FromQuery]string nome) => $"Chegou aqui {q} e {nome}";

    [HttpPost]
    public IActionResult TesteForm([FromForm] UserRequest userRequest) => View(userRequest);

    public string PrimeiraAction() => "Minha primeira action";

    public IActionResult Form() => View();

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
