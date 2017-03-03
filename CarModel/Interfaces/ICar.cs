using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarModel.Interfaces
{
    interface ICar
    {
        void StartEngine();
        void OffEngine();
        void Run();
        bool IsEngineON();
        void Gas();
        void Brake();
    }
}
