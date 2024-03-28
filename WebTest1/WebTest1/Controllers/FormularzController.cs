using Microsoft.AspNetCore.Mvc;

namespace WebTest1.Controllers
{
    public class FormularzController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
