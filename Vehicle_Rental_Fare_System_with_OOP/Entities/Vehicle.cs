using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_Fare_System_with_OOP.Entities
{
    class Vehicle
    {
        private string _vehicleNum;
        private int _hours;

        public Vehicle(string vehicalNum, int hours)
        {
            _vehicleNum = vehicalNum;
            _hours = hours;
        }

        public string getVehical()
        {
            return _vehicleNum;
        }

        public int getHours()
        {
            return _hours;
        }



    }
}
