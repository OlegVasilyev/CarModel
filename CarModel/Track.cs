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
namespace CarModel
{
    public partial class Track : Form
    {
        public delegate void HH(Button button);
        Car car;
        Engine engine;
        StWheel stwheel;
        Wheel wheel;
        Transmition transmition;
        Thread runcar;
        Gear gear;
        HH Hep;
        PetrolTank petrol;
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
            car = new Car(engine, stwheel, gear, wheel, transmition, petrol);
            runcar = new Thread(Moved);
            OffEngine.Enabled = false;

        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!car.Petrol.IsEmpty())
            {
                car.StartEngine();
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
            if (car.IsEngineON())
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
           car.Gear.power = (Multiplication)ChangeSpeed.SelectedValue;
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
                car.Petrol.Volume--;
                B.Location = new Point(500, 300);
            }
            B.Location = new Point(B.Location.X + car.Wheel.x, B.Location.Y + car.Wheel.y);

        }

        private void timerForRUNrUN_Tick(object sender, EventArgs e)
        {
            turnlabelsignal.Text = car.Stwheel.StateForTurnSignal();
            label4.Text = (Convert.ToInt32(car.Gear.power) * car.Transmition.Power).ToString();
            petrollable.Text = car.Petrol.Volume.ToString() + " л.";
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
            car.Gear.power = Multiplication.N;
            runcar.Abort();
        }

        private void PetrolAdd_Click(object sender, EventArgs e)
        {
            car.Petrol.Volume = (int)numericPetrol.Value;
        }

        private void handbrake_Click(object sender, EventArgs e)
        {
            car.Transmition.HandBrake();
        }
    }
}
