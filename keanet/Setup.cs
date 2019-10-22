using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using keanet.Models;

namespace keanet
{
    public class Setup
    {
        public List<ServiceModel> PriceList;
        private static Setup modelSetup;
        public static Setup ModelSetup
        { 
            get 
            { if (modelSetup == null)
                {
                    modelSetup = new Setup();
                }
                return modelSetup;                   
            } 
        }

        public Setup()
        {
            PriceList = new List<ServiceModel>();
            PriceList.Add(new ServiceModel("Internet Connection", 200, Regularity.Monthly));
            PriceList.Add(new ServiceModel("Phone Line", 150, Regularity.Monthly));
            PriceList.Add(new ServiceModel("Motorola G99", 800, Regularity.Once));
            PriceList.Add(new ServiceModel("iPhone 99", 6000, Regularity.Once));
            PriceList.Add(new ServiceModel("Samsung Galaxy 99", 1000, Regularity.Once));
            PriceList.Add(new ServiceModel("Sony Xperia 99", 900, Regularity.Once));
            PriceList.Add(new ServiceModel("Huawei 99", 900, Regularity.Once));

        }

    }
}
