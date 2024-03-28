using Microsoft.AspNetCore.Mvc;

namespace blogcsharp.Controllers
{
    public class KontaktController : Controller
    {
        // /Kontakt/Formularz
        public IActionResult Formularz()
        {
            return View();
        }
    }
}
