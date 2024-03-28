
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Cryptography.X509Certificates;
using WebTest1.Models;

namespace WebTest1.Controllers
{
    public class testController : Controller
    {      
        public IActionResult Index()
        {
            Testowa t = new Testowa();

            return View(t);
        }
        
      
    }
}
