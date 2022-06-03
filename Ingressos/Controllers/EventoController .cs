using Microsoft.AspNetCore.Mvc;

namespace Ingressos.Controllers
{
    public class EventoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
