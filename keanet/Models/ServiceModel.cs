using System;

namespace keanet.Models
{
    public enum Regularity { Once, Monthly }

    public class ServiceModel
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Regularity Regularity { get; set; }

        public ServiceModel(string id, string name, int price, Regularity regularity)
        {
            ID = id;
            Name = name;
            Price = price;
            Regularity = regularity;
        }

    }
}