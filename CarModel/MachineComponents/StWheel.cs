using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarModel.Interfaces;
namespace CarModel.MachineComponents
{
    class StWheel : IControl
    {
        private int stateStWheel;
        public StWheel()
        {
            StateStWheel = 0;
        }
        public string StateForTurnSignal()
        {
            if (stateStWheel == 1)
                return "Right";
            if (stateStWheel == -1)
                return "Left";
            return "";
        }
        public int StateStWheel
        {
            get
            {
                return stateStWheel;
            }

            set
            {
                if (value == 0 || value == 1 || value == -1) /*можно ли так делать ?*/
                    stateStWheel = value;
            }
        }
        public void InformationAboutComponents()
        {
            Console.WriteLine("Это руль");
        }
    }
}
