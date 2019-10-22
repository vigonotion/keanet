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
        private int PhonelineMin;
        private int PhoneLineMax;

        public Purchase(CartModel cart)
        {
            Cart = cart;
            PhoneLineMax = 8;
            PhonelineMin = 0;
        }

        public int SetInternetConnection(bool internetConnection)
        {
            Cart.InternetConnection = internetConnection;

            return CalculateTotalPrice();
        }

        public int SetPhoneLines(int phoneLines)
        {
            if(phoneLines >= PhonelineMin && phoneLines <= PhoneLineMax)
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
                    totalPrice =+ serviceModel.Price;
                }
            }
            totalPrice =+ (Cart.PhoneLines * Prices.sPrices.PhoneLinePrice);
            return totalPrice;
        }
    }
}
