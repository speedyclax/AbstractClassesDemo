using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * DONE - Create an abstract class called Vehicle 
             * DONE - The vehicle class shall have three string properties Year, Make, and Model
             * DONE - Set the defaults to something generic in the Vehicle class
             * DONE - Vehicle shall have an abstract method called DriveAbstract with no implementation
             * DONE - Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * DONE - Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * DONE - Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * DONE - Provide the implementations for the abstract methods
             * DONE - Only in the Motorcycle class will you override the virtual drive method
             * 
            */

            // DONE - Create a list of Vehicle called vehicles

            var vehicles = new List<Vehicle>();

            /*
             * DONE - Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * DONE - Set the properties with object initializer syntax
             */

            Car v1 = new Car() { HasTrunk = true, Make = "Ford", Model = "Focus", Year = 2008  };
            Motorcycle v2 = new Motorcycle() { HasSideCart = false, Make = "Harley Davidson", Model = "Fat Boy", Year = 2003 };
            Vehicle v3 = new Car() { HasTrunk = true, Make = "Toyota", Model = "Camry", Year = 2013 };
            Vehicle v4 = new Car() { HasTrunk = false, Make = "Dodge", Model = "Ram", Year = 2022 };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(v1);
            vehicles.Add(v2);
            vehicles.Add(v3);
            vehicles.Add(v4);

            foreach(var vehicle in vehicles)
            {
                Console.WriteLine($"Make: {vehicle.Make} Model: {vehicle.Model} Year: {vehicle.Year}");
                vehicle.DriveAbstract();
                Console.WriteLine("--------------------------------------");

                Console.WriteLine($"Make: {vehicle.Make} Model: {vehicle.Model} Year: {vehicle.Year}");
                vehicle.DriveVirtual();
                Console.WriteLine("--------------------------------------");
            }

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
