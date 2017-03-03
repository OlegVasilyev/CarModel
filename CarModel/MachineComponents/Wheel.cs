using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarModel.Interfaces;
namespace CarModel.MachineComponents
{
    class Wheel : IInformationAbout
    {
        public Wheel()
        {
        }
        public int x { get; set; }
        public int y { get; set; }
        public void InformationAboutComponents()
        {
            Console.WriteLine("Это точки колёса");
        }
    }
}
