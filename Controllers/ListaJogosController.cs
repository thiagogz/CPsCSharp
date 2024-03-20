using Microsoft.AspNetCore.Mvc;

namespace CP1.Controllers
{
    public class ListaJogosController : Controller
    {
        public IActionResult ListaJogos()
        {
            return View();
        }
    }
}
