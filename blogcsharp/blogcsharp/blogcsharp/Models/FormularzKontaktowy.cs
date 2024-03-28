using Microsoft.AspNetCore.Mvc;

namespace blogcsharp.Models
{
    public class FormularzKontaktowy : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
