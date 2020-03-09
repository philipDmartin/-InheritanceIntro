using System;

namespace InheritanceIntro
{
    public class Zero : Vehicle
    {  // Electric motorcycle
        public double BatteryKWh { get; set; }
        public void ChargeBattery() { }
        public override void Drive()
        {
            Console.WriteLine("Reeeem!");
        }

        public override string ToString()
        {
            return "This is my Zero";
        }
    }
}