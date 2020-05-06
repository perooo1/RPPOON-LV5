using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class ShippingService
    {
        double pricePerKg;

        public double PricePerKg { get => pricePerKg; private set => pricePerKg = value; }

        public ShippingService() { PricePerKg = 8; }

        public ShippingService(double pricePerKg)
        {
            PricePerKg = pricePerKg;
        }


        public double GetDeliveryPrice(Box package) { return package.Weight * pricePerKg; }
        

    }
}
