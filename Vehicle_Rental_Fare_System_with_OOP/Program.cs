using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_Fare_System_with_OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<Entities.Vehicle> vehicle = new List<Entities.Vehicle>();

            //int num;
            //do
            //{
            //    Console.WriteLine("------ Vehicle Rental Fare System ------");
            //    Console.WriteLine("");
            //    Console.WriteLine("------ Vehicle Rental Fare System ------");
            //    Console.WriteLine("------ Vehicle Rental Fare System ------");

            //} while (true);


            Entities.Vehicle car1 = new Entities.Vehicle("car-101",5);

            Services.RentCalculation carCalculation = new Services.Car(car1);

            Entities.Vehicle bike1 = new Entities.Vehicle("bike-105", 4);

            Services.RentCalculation bikeCalculation = new Services.Bike(bike1);

            Console.WriteLine("---Car---");
            Console.WriteLine("Vehicle = "+car1.getVehical());
            Console.WriteLine("Hours = "+car1.getHours());
            Console.WriteLine("Total rental cost = "+carCalculation.finalCalculation());

            Console.WriteLine();

            Console.WriteLine("---Bike---");
            Console.WriteLine("Vehicle = " + bike1.getVehical());
            Console.WriteLine("Hours = " + bike1.getHours());
            Console.WriteLine("Total rental cost = " + bikeCalculation.finalCalculation());



            Console.ReadKey();



        }
    }
}
