using blogcsharp.Models;
using Microsoft.AspNetCore.Mvc;

namespace blogcsharp.Controllers
{
    public class KontaktController : Controller
    {
        // /Kontakt/Formularz
        public IActionResult Formularz()
        {
            DaneFormularz dane = new DaneFormularz();

            return View(dane);
        }


        // /kontakt/formularzsend
        public IActionResult FormularzSend(DaneFormularz mojedanezformularza)
        {
      

            return View(mojedanezformularza);
        }
        //kontakt/webepartners
        public IActionResult Webepartners()
        {
            return View();
        }
    }
}
