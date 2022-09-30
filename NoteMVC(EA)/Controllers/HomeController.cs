using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using noteBll;
using NoteMVC_EA_.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NoteMVC_EA_.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly userBll _userBll;

        public HomeController(userBll userBll)
        {
            _userBll = userBll;
        }


        public IActionResult Index()
        {
            var user = _userBll.GetUser(1);
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
