using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using keanet.Models;

namespace keanet
{
    public class Prices
    {
        public List<ServiceModel> PriceList;
        public int InternetPrice { get { return internetPrice; } }
        private int internetPrice;
        public int PhoneLinePrice { get { return phoneLinePrice; } }
        private int phoneLinePrice;
        private static Prices prices;
        public static Prices sPrices
        { 
            get 
            { if (prices == null)
                {
                    prices = new Prices();
                }
                return prices;                   
            } 
        }

        public Prices()
        {
            internetPrice = 200;
            phoneLinePrice = 150;
            PriceList = new List<ServiceModel>();
            PriceList.Add(new ServiceModel("moto", "Motorola G99", 800, Regularity.Once));
            PriceList.Add(new ServiceModel("iphone", "iPhone 99", 6000, Regularity.Once));
            PriceList.Add(new ServiceModel("samsung", "Samsung Galaxy 99", 1000, Regularity.Once));
            PriceList.Add(new ServiceModel("sony", "Sony Xperia 99", 900, Regularity.Once));
            PriceList.Add(new ServiceModel("huawei", "Huawei 99", 900, Regularity.Once));

        }

    }
}
