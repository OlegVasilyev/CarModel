using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarModel.MachineComponents;
using CarModel.Interfaces;
namespace CarModel
{
    class Car : ICar
    {
        Engine engine;
        StWheel stwheel;
        Gear gear;
        Wheel wheel;
        Transmition transmition;
        PetrolTank petrol;
        public Car(Engine engine, StWheel stwheel, Gear gear, Wheel wheel, Transmition transmition, PetrolTank pet)
        {
            this.engine = engine;
            this.stwheel = stwheel;
            this.gear = gear;
            this.wheel = wheel;
            this.transmition = transmition;
            this.petrol = pet;
            this.transmition.Power = 0;
        }
        //спросить за поля
        #region
        public Wheel Wheel
        {
            get
            {
                return wheel;
            }
        }

        public StWheel Stwheel
        {
            get
            {
                return stwheel;
            }
        }

        public Transmition Transmition
        {
            get
            {
                return transmition;
            }
        }

        public Gear Gear
        {
            get
            {
                return gear;
            }
        }

        internal PetrolTank Petrol
        {
            get
            {
                return petrol;
            }

            set
            {
                petrol = value;
            }
        }
        #endregion
        public bool IsEngineON()
        {
            return engine.ActivityEngine;
        }
        public void StartEngine()
        {
            engine.Start();
        }
        public void OffEngine()
        {
            engine.OffEngine();
        }
        public void Run()
        {
            if (Stwheel.StateStWheel == 0)
            {
                wheel.x = transmition.Power * Convert.ToInt32(gear.power);
                wheel.y = 0;
            }
            if (Stwheel.StateStWheel == -1)
            {
                wheel.y = transmition.Power * Convert.ToInt32(gear.power) * Stwheel.StateStWheel;
                wheel.x = 0;
            }
            if (Stwheel.StateStWheel == 1)
            {
                wheel.y = transmition.Power * Convert.ToInt32(gear.power) * Stwheel.StateStWheel;
                wheel.x = 0;

            }
        }
        public void Gas()
        {
            if (transmition.Power > engine.Maxpower)
                return;
            ++transmition.Power;
        }
        public void Brake()
        {
            if (transmition.Power == 0)
                return;
            --transmition.Power;
        }
    }
}
