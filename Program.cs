using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            var Titan = new Nissan()
            {
                Model = "Titan",
                MPG = 30.3,
                FuelCapacity = 25,
                MaximumOccupancy = 5,
                ExteriorColor = "Blue",
                InteriorColor = "Dark Gray"
            };
            Titan.Drive(25);
        }
    }
}

