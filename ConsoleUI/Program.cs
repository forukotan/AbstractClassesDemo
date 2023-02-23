
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
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             *DONE Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             *DONE Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicles called vehicles
            var vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */
            Car Nissan = new Car() { hasTrunk = true,Make="Nissan",Model="Altima",Year="2016"};
            Motorcycle Yamaha = new Motorcycle() { HasSideCart=true,Make="yam",Model="aha",Year="2020"};
            Vehicle van = new Car() { Year = "2020", Model = "toyata", Make = "rav4", hasTrunk = true };
            Vehicle TwoWheels = new Motorcycle() { Year = "2001", Make = "harley", Model = "davidson", HasSideCart = true };



            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(van);
            vehicles.Add(Nissan);
            vehicles.Add(Yamaha);
            vehicles.Add(TwoWheels);

            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine($"Model {v.Model} Make {v.Make},Year{v.Year}");
                
            }

            // Call each of the drive methods for one car and one motorcycle
            Nissan.DriveAbstract();
            Yamaha.DriveVirtual();

            #endregion            
            Console.ReadLine();
        }
    }
}
