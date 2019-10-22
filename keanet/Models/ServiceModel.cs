using System;

namespace keanet.Models
{
    public enum Regularity { Once, Monthly }

    public class ServiceModel
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Regularity Regularity { get; set; }

        public ServiceModel(string name, int price, Regularity regularity)
        {
            Name = name;
            Price = price;
            Regularity = regularity;
        }

    }
}