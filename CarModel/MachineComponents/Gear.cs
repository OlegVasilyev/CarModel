using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarModel.Interfaces;
namespace CarModel.MachineComponents
{
    class Gear : IInformationAbout, IGear
    {
        public Multiplication Power { get; set; }
        public void InformationAboutComponents()
        {
            Console.WriteLine("Это коробка передач");
        }
    }
}
