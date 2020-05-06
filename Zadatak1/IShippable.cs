using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    interface IShippable
    {
        double Price { get; }       //measure unit is HRK
        double Weight { get; }      //measure unit is Kg
        string Description(int depth = 0);

    }
}
