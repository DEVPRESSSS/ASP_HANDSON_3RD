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
        public IActionResult Letter(Ship model)
        {
            if(ModelState.IsValid)
            {
                model.letter = model.letter.ToLower();
               
                if(model.letter == "b")
                {
                    ViewBag.Message = "battleship";
                    ViewBag.Ship = model;


                }
                else if(model.letter == "c")
                {
                    ViewBag.Message = "cruiship";
                    ViewBag.Ship = model;
                }
                else if (model.letter == "d")
                {
                    ViewBag.Message = "destroyer";
                    ViewBag.Ship = model;
                }
                else
                {
                    ViewBag.Message = "No info";
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
