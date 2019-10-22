using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using keanet.Models;

namespace keanet.Controllers
{
    public class HomeController : Controller
    {
        private Purchase purchase = new Purchase(new CartModel());
        public IActionResult Index()
        {
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

        [HttpPost]
        public int SetInternetConnection(bool internetConnection)
        {
            return purchase.SetInternetConnection(internetConnection);
            
        }

        [HttpPost]
        public int SetPhoneLines(int phoneLines)
        {
            return purchase.SetPhoneLines(phoneLines);
        }

        [HttpPost]
        public int AddPhone(string id)
        {
            return purchase.AddPhone(id);
        }

        [HttpPost]
        public int RemovePhone(string id)
        {
            return purchase.RemovePhone(id);
        }

    }
}
