using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarModel.MachineComponents;
using CarModel.Interfaces;
namespace CarModel.MachineComponents
{
    class Transmition : ITransmition, IInformationAbout
    {
        public Transmition() {/*изначально мы ставим мощность на ноль*/ Power = 0; }
        public int Power { get; set; }
        public void HandBrake()
        {
            
            Power = 0;
        }
        public void InformationAboutComponents()
        {
            Console.WriteLine("Это трансмисия");
        }
    }
}
