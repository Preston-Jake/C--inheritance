using System;

namespace Garage
{
    public class Vehicle
    {
        public double FuelCapacity { get; set; }
        public double MPG { get; set; }
        public int MaximumOccupancy { get; set; }
        public string ExteriorColor { get; set; }
        public string InteriorColor { get; set; }
        private double odometer { get; set; } = 0.0;
        public void Drive(double miles)
        {
            odometer += miles;
            var LbsCo2Emitted = (miles / MPG) * 19.8;
            Console.WriteLine($"You emitted {LbsCo2Emitted}lbs. of CO2");
        }

    }
}