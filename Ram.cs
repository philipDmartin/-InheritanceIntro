using System;

namespace InheritanceIntro
{
    public class Ram : Vehicle
    {
        // Gas powered truck
        public double FuelCapacity { get; set; }
        public void RefuelTank() { }
        public override void Drive()
        {
            Console.WriteLine("Raaaawww!");
        }

        public override string ToString()
        {
            return "This is my Ram";
        }
    }
}
