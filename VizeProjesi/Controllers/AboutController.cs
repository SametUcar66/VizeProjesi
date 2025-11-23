using Microsoft.AspNetCore.Mvc;

namespace VizeProjesi.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
