using System;
using System.Collections.Generic;

namespace keanet.Models
{
    public class CartModel
    {
        public bool InternetConnection { get; set; }
        public int PhoneLines { get; set; }
        public List<ServiceModel> Services { get; set; }

        public CartModel()
        {
            Services = new List<ServiceModel>();
        }
    }
}