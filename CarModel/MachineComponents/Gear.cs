using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarModel.Interfaces;
namespace CarModel.MachineComponents
{
    class Gear : IInformationAbout
    {
        public Multiplication power { get; set; }
        public void InformationAboutComponents()
        {
            Console.WriteLine("Это коробка передач");
        }
    }
    enum Multiplication
    { R = -1, N = 0, one = 1, two = 2, three = 3, four = 4 }
}
