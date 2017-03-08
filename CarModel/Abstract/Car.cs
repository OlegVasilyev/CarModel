using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarModel.Interfaces;
namespace CarModel.Abstract
{
    abstract class Car : ICar
    {
        public Car() { }
        public Car(IEngine engine, IGear gear, ITransmition transmition, IControl stwheel, IWheel wheel, IFuel pet)
        {
            this.Engine = engine;
            this.Transmition = transmition;
            this.Gear = gear;
            this.Stwheel = stwheel;
            this.Wheel = wheel;
            this.Fuel = pet;
        }

        public IEngine Engine { get; }
        public IFuel Fuel { get; }
        public ITransmition Transmition { get; }
        public IGear Gear { get; }
        public IWheel Wheel { get; }
        public IControl Stwheel { get; }
        public bool Clutch()
        {
            return Engine.ActivityEngine;
        }
        public void OnEngine()
        {
            Engine.OnEngine();
        }
        public void OffEngine()
        {
            Engine.OffEngine();
        }
        abstract public void Run();

        public void Gas()
        {
            if (Transmition.Power > Engine.Maxpower)
                return;
            ++Transmition.Power;
        }
        public void Brake()
        {
            if (Transmition.Power == 0)
                return;
            --Transmition.Power;
        }
    }
    }
