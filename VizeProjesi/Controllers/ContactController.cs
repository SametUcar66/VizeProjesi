using Microsoft.AspNetCore.Mvc;

namespace VizeProjesi.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
