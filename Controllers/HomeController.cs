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
            ICollection<int> numbers = new List<int>() {1,2,3,4,5};
            return View(numbers);
        }
        [HttpPost]
        public IActionResult Loop(ICollection<int> model)
        {

            if (model == null || !model.Any())
            {
                model = new List<int>() { 1, 2, 3, 4, 5 };
            }

            var reversedNumbers = model.Reverse().ToList();
            return View("Index", reversedNumbers);
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
