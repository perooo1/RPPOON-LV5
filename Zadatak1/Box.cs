using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class Box : IShippable
    {
        private List<IShippable> items;
        private string name;

        public Box(string name)
        {
            this.name = name;
            items = new List<IShippable>();
        }

        public void Add(IShippable item) { this.items.Add(item); }
        public void Remove(IShippable item) { this.items.Remove(item); }

        public double Price
        {
            get
            {
                double totalPrice = 0;
                foreach (IShippable item in items)
                {
                    totalPrice += item.Price;
                }
                return totalPrice;
            }
        }

        public string Description(int depth = 0)
        {
            StringBuilder builder = new StringBuilder(new string(' ', depth) + this.name + "\n");
            foreach (IShippable item in items)
            {
                builder.Append(item.Description(depth + 2)).Append("\n");
            }
            return builder.ToString();
        }

        public double Weight
        {
            get
            {
                double totalWeight = 0;
                foreach (IShippable item in items)
                {
                    totalWeight += item.Weight;
                }
                return totalWeight;
            }
        }
        
    }
}
