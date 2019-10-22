using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using keanet.Models;

namespace keanet
{
    public class Purchase
    {
        public CartModel Cart { get; set;}      


        public Purchase(CartModel cart)
        {
            Cart = cart;
        }

        public int SetInternetConnection(bool internetConnection)
        {
            Cart.InternetConnection = internetConnection;

            return CalculateTotalPrice();
        }

        public int SetPhoneLines(int phoneLines)
        {
            if(phoneLines > 0 && phoneLines < 9)
            {
                Cart.PhoneLines = phoneLines;
            }

            return CalculateTotalPrice();
        }

        public int CalculateTotalPrice()
        {
            int totalPrice = 0;
            if (Cart.Services != null)
            {
                foreach (ServiceModel serviceModel in Cart.Services)
                {
                    totalPrice = totalPrice + serviceModel.Price;
                }
            }
            return totalPrice;
        }

        public int AddPhone(string id)
        {
            Prices prices = new Prices();                
                        
            ServiceModel Mobile = prices.PriceList.FirstOrDefault<ServiceModel>(x => x.ID == id);    
            if(Mobile != null) { Cart.Services.Add(Mobile); }

            return CalculateTotalPrice();
        }

        public int RemovePhone(string id)
        {
            Prices prices = new Prices();

            ServiceModel Mobile = prices.PriceList.FirstOrDefault<ServiceModel>(x => x.ID == id);
            if (Mobile != null) { Cart.Services.Remove(Mobile); }
            return CalculateTotalPrice();
        }


    }
}
