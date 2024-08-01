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
        public IActionResult AirCraft(Aircraft model)
        {
            if(ModelState.IsValid)
            {
                if(model.Number < 500)
                {
                    ViewBag.Message = "Bird";
                    ViewBag.Aircraft = model;
                }
                else if((model.Number >= 500) && (model.Number <= 1100))
                {
                    ViewBag.Message = "Military";
                    ViewBag.Aircraft = model;

                }
                else
                {
                    ViewBag.Message = "Civilian";
                    ViewBag.Aircraft = model;
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
