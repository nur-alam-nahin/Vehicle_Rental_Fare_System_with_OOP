using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_Rental_Fare_System_with_OOP.Entities;

namespace Vehicle_Rental_Fare_System_with_OOP.Services
{
    class Bike : RentCalculation
    {
        public Bike(Vehicle vehicle) : base(vehicle)
        {

        }

        public override double finalCalculation()
        {
            double taka = 50;
            return taka * _vehicle.getHours();
        }
    }
}
