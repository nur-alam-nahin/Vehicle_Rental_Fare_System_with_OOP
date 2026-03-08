using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_Rental_Fare_System_with_OOP.Entities;

namespace Vehicle_Rental_Fare_System_with_OOP.Services
{
    abstract class RentCalculation
    {
        protected Vehicle _vehicle;

        public RentCalculation(Vehicle vehicle)
        {
            _vehicle = vehicle;
        }
        public abstract double finalCalculation();
    }
}
