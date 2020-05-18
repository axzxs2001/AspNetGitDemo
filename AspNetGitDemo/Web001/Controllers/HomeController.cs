using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web001.Models;
using Web001.Services;

namespace Web001.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICalculator _calculator;

        public HomeController(ILogger<HomeController> logger, ICalculator calculator)
        {
            _calculator = calculator;
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Calculator.Plus测试");

            var a = 10;
            var b = 20;
            var result = _calculator.Plus(a, b);
            Console.WriteLine("\r\n=============================");
            Console.WriteLine($"{a}+{b}={result}");
            Console.WriteLine("=============================");
            return View();
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
