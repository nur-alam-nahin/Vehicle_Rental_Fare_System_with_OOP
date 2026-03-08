using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_Rental_Fare_System_with_OOP.Entities;

namespace Vehicle_Rental_Fare_System_with_OOP.Services
{
    class Car : RentCalculation
    {

        public Car(Vehicle vehicle) : base(vehicle)
        {

        }

        public override double finalCalculation()
        {
            double taka = 200;
            return taka * _vehicle.getHours();
        }
    }
}
