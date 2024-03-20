using Microsoft.AspNetCore.Mvc;

namespace CP1.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Info()
        {
            return View();
        }
    }
}
