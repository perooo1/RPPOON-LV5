using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class Product : IShippable
    {
        private double price;
        private double weight;
        private string description;

        public double Price { get => price; set => price = value; }
        public double Weight { get => weight; set => weight = value; }
        public string Description { get => description; set => description = value; }

        public Product(double price, double weight, string description)
        {
            Price = price;
            Weight = weight;
            Description = description;
        }

        string IShippable.Description(int depth)
        {
            return new string(' ', depth) + this.description;
        }

        

    }
}
