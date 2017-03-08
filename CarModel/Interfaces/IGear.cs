using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarModel.Interfaces
{
    interface IGear
    {
        Multiplication Power { get; set; }
    }
    enum Multiplication
    { R = -1, N = 0, one = 1, two = 2, three = 3, four = 4 }
}
