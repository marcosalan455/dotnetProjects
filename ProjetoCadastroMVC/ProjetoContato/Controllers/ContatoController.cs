using Microsoft.AspNetCore.Mvc;


namespace ProjetoContato.Controllers;

public class ContatoController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    
}
