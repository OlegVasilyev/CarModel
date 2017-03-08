using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarModel.Interfaces;
namespace CarModel.MachineComponents
{
    class PetrolTank : IFuel, IInformationAbout
    {
        private int volume;
        public PetrolTank()
        {
            volume = 0;
        }
        public int Volume
        {
            get
            {
                return volume;
            }

            set
            {
                if(value>=0)
                volume = value;
            }
        }
        public bool IsEmpty()
        {
            if (volume > 0)
                return false;
            else return true;
        }
        public void InformationAboutComponents()
        {
            Console.WriteLine("Это топливный бак");
        }
    }
}
