using blogcsharp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace blogcsharp.Controllers
{
    public class ZdjeciaController : Controller
    {
        // /Zdjecia/Galeria
        public IActionResult Galeria()
        {
            var obrazek = new List<Obrazek>();

            Obrazek o1 = new Obrazek()
            {
                Name = "obrazek1",
                ImageUrl = "https://picsum.photos/300/300"
            };

            Obrazek o2 = new Obrazek()
            {
                Name = "obrazek1",
                ImageUrl = "https://picsum.photos/300/300"
            };

            Obrazek o3 = new Obrazek()
            {
                Name = "obrazek1",
                ImageUrl = "https://picsum.photos/300/300"
            };

            Obrazek o4= new Obrazek()
            {
                Name = "obrazek1",
                ImageUrl = "https://picsum.photos/300/300"
            };


            Obrazek o5 = new Obrazek()
            {
                Name = "obrazek1",
                ImageUrl = "https://picsum.photos/300/300"
            };

            Obrazek o6 = new Obrazek()
            {
                Name = "obrazek1",
                ImageUrl = "https://picsum.photos/300/300"
            };

            Obrazek o7 = new Obrazek()
            {
                Name = "obrazek1",
                ImageUrl = "https://picsum.photos/300/300"
            };


            obrazek.Add(o1);
            obrazek.Add(o2);
            obrazek.Add(o3);
            obrazek.Add(o4);
            obrazek.Add(o5);
            obrazek.Add(o6);
            obrazek.Add(o7);



            return View(obrazek);
        }
    }
}
