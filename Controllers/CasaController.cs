using Microsoft.AspNetCore.Mvc;

namespace ExemploAspNetMvc.Controllers;

public class CasaController : Controller
{
    public IActionResult Index() => View();
}