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
        public IActionResult Grade(Grade model)
        {
            if (ModelState.IsValid)
            {
                if (model.grade <= 74)
                {
                    ViewBag.Message = "Failed";
                }
                else if (model.grade > 74 && model.grade <= 76)
                {
                    ViewBag.Message = "3.00";
                }
                else if (model.grade > 76 && model.grade <= 77)
                {
                    ViewBag.Message = "2.75";
                }
                else if (model.grade > 77 && model.grade <= 81)
                {
                    ViewBag.Message = "2.50";
                }
                else if (model.grade > 81 && model.grade <= 84)
                {
                    ViewBag.Message = "2.25";
                }
                else if (model.grade > 84 && model.grade <= 88)
                {
                    ViewBag.Message = "2.00";
                }
                else if (model.grade > 88 && model.grade <= 91)
                {
                    ViewBag.Message = "1.75";
                }
                else if (model.grade > 91 && model.grade <= 94)             {
                    ViewBag.Message = "1.50";
                }
                else if (model.grade > 94 && model.grade <= 97)
                {
   
                    ViewBag.Message = "1.25";
                }
                else if (model.grade > 97 && model.grade <= 100)
                {
                    ViewBag.Message = "1.00";
                }
                else
                {
                    ViewBag.Message = "Invalid grade";
                }

                ViewBag.Grade = model;
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
