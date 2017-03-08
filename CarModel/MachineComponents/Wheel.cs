using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarModel.Interfaces;
namespace CarModel.MachineComponents
{
    class Wheel : IInformationAbout, IWheel
    {
        public Wheel()
        {
            X = 0;
            Y = 0;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public void InformationAboutComponents()
        {
            Console.WriteLine("Это точки колёса");
        }
    }
}
