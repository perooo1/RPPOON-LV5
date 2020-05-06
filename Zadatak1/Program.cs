using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product barbieDoll = new Product(25, 0.25, "Barbie for girls to play with.");
            Product gormiti = new Product(22, 0.20, "Gormiti only for real tough boys!");
            Product monopolyExtendedPack = new Product(250, 1.2, "Monopoly extended pack for entire family to play!");
            Product jigsaw = new Product(80, 0.8, "The hardest jigsaw ever,only for those with a lot of patience.");

            Box package = new Box("Family play-time in quarantene");
            package.Add(barbieDoll);
            package.Add(gormiti);
            package.Add(monopolyExtendedPack);
            package.Add(jigsaw);

            Console.WriteLine(package.Description().ToString());
            ShippingService service = new ShippingService();

            Console.WriteLine("Total shipping price:");
            Console.WriteLine(service.GetDeliveryPrice(package));

        }
    }
}
