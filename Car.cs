using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    public class Car : Transport
    {
        public int NumberOfSeats { get; set; }
        public string FuelType { get; set; }
        public string Model { get; set; }

        public Car(BaseInform baseInfo, int numberOfSeats, string fuelType, string model) : base(baseInfo)
        {
            NumberOfSeats = numberOfSeats;
            FuelType = fuelType;
            Model = model;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, NumberOfSeats: {NumberOfSeats}, FuelType: {FuelType}, Model: {Model}";
        }
    }
}
