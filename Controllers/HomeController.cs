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
        public IActionResult Add(Calculator model)
        {
            if(ModelState.IsValid)
            {
                model.Result = model.fisrtNumber + model.SecondNumber;
            }



            return View("Index", model);

        }
        [HttpPost]
        public IActionResult Minus(Calculator model)
        {
            if (ModelState.IsValid)
            {
                model.Result = model.fisrtNumber - model.SecondNumber;
            }



            return View("Index", model);

        }
        [HttpPost]
        public IActionResult Multi(Calculator model)
        {
            if (ModelState.IsValid)
            {
                model.Result = model.fisrtNumber * model.SecondNumber;
            }



            return View("Index", model);

        }
        [HttpPost]
        public IActionResult Division(Calculator model)
        {
            if (ModelState.IsValid)
            {
                model.Result = model.fisrtNumber / model.SecondNumber;
            }



            return View("Index", model);

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
