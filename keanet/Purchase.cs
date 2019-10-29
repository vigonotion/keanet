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
        public int GetPhonelineMin { get { return PhonelineMin; } }
        public int GetPhonelineMax { get { return PhoneLineMax; } }

        private int PhonelineMin;
        private int PhoneLineMax;

        public static Purchase sPurchase { get {  if (purchase == null)
                {
                    purchase = new Purchase(new CartModel());
                }
                return purchase;
            } }
        private static Purchase purchase;


        private Purchase(CartModel cart)
        {
            Cart = cart;
            PhoneLineMax = 8;
            PhonelineMin = 0;
        }

        public void Reset(CartModel cart)
        {
            if(cart == null)
            {
                Cart = new CartModel();
            }
            else
            {
                Cart = cart;
            }
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
            
            foreach (ServiceModel serviceModel in Cart.Services)
            {
                totalPrice  += serviceModel.Price;
            }
            totalPrice = totalPrice +(Cart.PhoneLines * Prices.sPrices.PhoneLinePrice);
            if(Cart.InternetConnection)
            {
                totalPrice += Prices.sPrices.InternetPrice;
            }
            return totalPrice;
        }

        public int AddPhone(string id)
        {               
            ServiceModel Mobile = Prices.sPrices.PriceList.FirstOrDefault<ServiceModel>(x => x.ID == id);    
            if(Mobile != null) { Cart.Services.Add(Mobile); }
            return CalculateTotalPrice();
        }

        public int RemovePhone(string id)
        {
            ServiceModel Mobile = Prices.sPrices.PriceList.FirstOrDefault<ServiceModel>(x => x.ID == id);
            if (Mobile != null) { Cart.Services.Remove(Mobile); }
            return CalculateTotalPrice();
        }


    }
}
