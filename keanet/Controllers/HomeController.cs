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
            return Purchase.sPurchase.SetInternetConnection(internetConnection);
            
        }

        [HttpPost]
        public int SetPhoneLines(int phoneLines)
        {
            return Purchase.sPurchase.SetPhoneLines(phoneLines);
        }

        [HttpPost]
        public int AddPhone(string id)
        {
            return Purchase.sPurchase.AddPhone(id);
        }

        [HttpPost]
        public int RemovePhone(string id)
        {
            return Purchase.sPurchase.RemovePhone(id);
        }

    }
}
