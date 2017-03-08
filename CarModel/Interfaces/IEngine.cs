using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CarModel.Interfaces
{
    interface IEngine : IControlEngine
    {
        bool ActivityEngine { get; }
        int Maxpower { get; }

    }
}
