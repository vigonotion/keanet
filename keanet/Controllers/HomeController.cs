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

        [HttpGet]
        public string Buy()
        {
            string res = "";
            
            if(Purchase.sPurchase.CalculateTotalPrice() > 0)
            {
                res += "Purchase complete! You purchased phones: " + string.Join(", ", Purchase.sPurchase.Cart.Services.Select(s => s.Name)) + ".\n";
                res += "You did " + (Purchase.sPurchase.Cart.InternetConnection ? "" : "not ") + "purchase internet connection. \n";
                res += "You also bought " + Purchase.sPurchase.Cart.PhoneLines + " phone lines.\n\n";
                res += "Total price: " + Purchase.sPurchase.CalculateTotalPrice();
            } else {
                res = "No items in cart. Please select items to buy.";
            }
            
            Purchase.sPurchase.Reset(new CartModel());

            return res;
        }

    }
}
