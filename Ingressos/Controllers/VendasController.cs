using Microsoft.AspNetCore.Mvc;

namespace Ingressos.Controllers
{
    public class VendasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
