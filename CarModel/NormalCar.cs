using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarModel.MachineComponents;
using CarModel.Abstract;
using CarModel.Interfaces;
namespace CarModel
{
    class NormalCar : Car
    {
        public NormalCar(IEngine engine, IGear gear, ITransmition transmition, IControl stwheel, IWheel wheel, IFuel pet): base(engine, gear,transmition,stwheel, wheel, pet)
        {
        }
        public override void Run()
        {
            if (Fuel.IsEmpty())
                return;
            if (Stwheel.StateStWheel == 0)
                {
                    Wheel.X = Transmition.Power * Convert.ToInt32(Gear.Power);
                    Wheel.Y = 0;
                }
            if (Stwheel.StateStWheel == -1)
            {
                Wheel.Y = Transmition.Power * Convert.ToInt32(Gear.Power) * Stwheel.StateStWheel;
                Wheel.X = 0;
            }
            if (Stwheel.StateStWheel == 1)
            {
                Wheel.Y = Transmition.Power * Convert.ToInt32(Gear.Power) * Stwheel.StateStWheel;
                Wheel.X = 0;

            }
        }
    }
}
