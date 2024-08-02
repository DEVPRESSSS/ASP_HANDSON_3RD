using ASP_HANDS_ON_3RDYEAR.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Convert = ASP_HANDS_ON_THIRDYEAR.Models.Convert;

namespace ASP_HANDS_ON_3RDYEAR.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Earthquake(Earthquake model)
        {
            if (ModelState.IsValid)
            {
                if (model.Magnitude < 4.9)
                {
                    ViewBag.Message = "No damage";
                    ViewBag.Ship = model;
                }
                else if (model.Magnitude >= 4.9 && model.Magnitude <= 5.5)
                {
                    ViewBag.Message = "Some damage";
                    ViewBag.Ship = model;
                }
                else if (model.Magnitude > 5.5 && model.Magnitude <= 6.5)
                {
                    ViewBag.Message = "Serious Damage";
                    ViewBag.Ship = model;
                }
                else if (model.Magnitude >= 6.5 && model.Magnitude <7.5)
                {
                    ViewBag.Message = "Disaster";
                    ViewBag.Ship = model;
                }
                else
                {
                    ViewBag.Message = "Catastrophe";
                    ViewBag.Ship = model;
                }
            }




            return PartialView("Index", model);

        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
