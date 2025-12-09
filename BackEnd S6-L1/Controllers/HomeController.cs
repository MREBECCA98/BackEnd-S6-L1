using System.Diagnostics;
using BackEnd_S6_L1.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd_S6_L1.Controllers
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


    }
}
