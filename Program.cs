using System;

namespace InheritanceIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBike = new Zero();
            //I can still reference the inherited property
            myBike.MainColor = "Black";
            myBike.MaxOccupancy = 2;

            var myTesla = new Tesla();
            myTesla.MainColor = "Midnight Silver";
            myTesla.MaxOccupancy = 7;

            var myRam = new Ram();
            myRam.MainColor = "Red";
            myRam.MaxOccupancy = 3;

            var myCessna = new Cessna();
            myCessna.MainColor = "Blue";
            myCessna.MaxOccupancy = 8;

            myBike.Drive();
            myTesla.Drive();
            myCessna.Drive();
            myRam.Drive();
        }
    }
}
