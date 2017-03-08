using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarModel.Interfaces
{
    interface IControl
    {
        string StateForTurnSignal();
        int StateStWheel { get; set; }
    }
}
