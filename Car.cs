using System;

namespace CarsDatabase
{
    public class Car
    {
        // Internal database identifier
        public int ID { get; set; }

        // Car specific properties
        public string VehicleRegNo { get; set; }
        public string Make { get; set; }
        public string EngineSize { get; set; }
        public DateTime DateRegistered { get; set; }
        public double RentalPerDay { get; set; }
        public bool Available { get; set; }
        public int Mileage { get; set; }
        public string InsuranceType { get; set; }
    }
}