using Microsoft.AspNetCore.Mvc;

namespace CP1.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Contato()
        {
            return View();
        }
    }
}
