using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using CarModel.MachineComponents;
using CarModel.Interfaces;
using CarModel.Abstract;
namespace CarModel
{
    public partial class Track : Form
    {
        public delegate void HH(Button button);
        Car car;
        IEngine engine;
        IControl stwheel;
        IWheel wheel;
        ITransmition transmition;
        IFuel petrol;
        IGear gear;
        Thread runcar;
        HH Hep;
        public Track()
        {
            InitializeComponent();
            Hep = new HH(Mov);
            engine = new Engine(5);
            stwheel = new StWheel();
            transmition = new Transmition();
            wheel = new Wheel();
            gear = new Gear();
            petrol = new PetrolTank();
            ChangeSpeed.DataSource = Enum.GetValues(typeof(Multiplication));
            ChangeSpeed.SelectedText = Multiplication.one.ToString();
            //Спросить за гибкость в данной модели
            car = new NormalCar(engine, gear, transmition ,stwheel, wheel, petrol);
            runcar = new Thread(Moved);
            OffEngine.Enabled = false;
            //все изменения и функционал мы берем не напрямую через компоненты а через объекта класса Car
            //форма Track ничего не знает о компонентах машины, хоть и объекты создаються тут
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!car.Fuel.IsEmpty())
            {
                car.OnEngine();
                timerForPipe.Start();
                labelforpipe.Text = "дырдырдырдырдырдырдырдырдыр";
                StartButton.BackColor = Color.Green;
                OffEngine.Enabled = true;

            }
        }
        private void ClutchButton_Click(object sender, EventArgs e)
        {
            GoButton.Enabled = true;
            BrakeButton.Enabled = true;
            if (car.Clutch())
            {
                runcar.IsBackground = true;
                runcar.Start();
                ClutchButton.Enabled = false;
            }

        }
        private void BrakeButton_Click(object sender, EventArgs e)
        {
            car.Brake();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            car.Gas();
        }
        private void ChangeSpeed_SelectedIndexChanged(object sender, EventArgs e)

        {
            car.Gear.Power = (Multiplication)ChangeSpeed.SelectedValue;
        }
        private void Moved()
        {
            try
            {
                while (true)
                {

                    Thread.Sleep(50); car.Run();
                    Invoke(Hep, CarMod);

                }
            }
            catch { }
        }
        private void Mov(Button B)
        {
            if (B.Location.X > 950 || B.Location.X < 50 || B.Location.Y > 600 || B.Location.Y < 50)
            {
                --car.Fuel.Volume;
                B.Location = new Point(500, 300);
            }
            B.Location = new Point(B.Location.X + car.Wheel.X, B.Location.Y + car.Wheel.Y);

        }

        private void timerForRUNrUN_Tick(object sender, EventArgs e)
        {
            turnlabelsignal.Text = car.Stwheel.StateForTurnSignal();
            label4.Text = (Convert.ToInt32(car.Gear.Power) * car.Transmition.Power).ToString();
            petrollable.Text = car.Fuel.Volume.ToString() + " л.";
            if (labelforpipe.Left > -labelforpipe.Width)
            {
                labelforpipe.Left -= 5;
            }
            else
            {
                labelforpipe.Left = panel1.Width;
            }

        }

        private void leftturn_Click(object sender, EventArgs e)
        {
            car.Stwheel.StateStWheel = -1;
        }
        private void rightturn_Click(object sender, EventArgs e)
        {
            car.Stwheel.StateStWheel = 1;
        }
        private void straightbutton_Click(object sender, EventArgs e)
        {
            car.Stwheel.StateStWheel = 0;
        }
        private void OffEngine_Click(object sender, EventArgs e)
        {
            ClutchButton.Enabled = true;
            StartButton.BackColor = Color.Red;
            car.OffEngine();
            timerForPipe.Stop();
            labelforpipe.Text = "";
            car.Gear.Power = Multiplication.N;
            runcar.Abort();
        }

        private void PetrolAdd_Click(object sender, EventArgs e)
        {
            car.Fuel.Volume = (int)numericPetrol.Value;
        }

        private void handbrake_Click(object sender, EventArgs e)
        {
            car.Transmition.HandBrake();
        }
    }
}
