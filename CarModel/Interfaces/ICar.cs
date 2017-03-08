using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CarModel.Interfaces
{
    interface ICar : IControlEngine, IPedalControl
    {
        void Run();
    }
}
