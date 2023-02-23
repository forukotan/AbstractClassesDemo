using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public Vehicle()
        { }

        public string Year { get; set; } = "Default Year";
        public string Make { get; set; } = "Default Make";
        public string Model { get; set; } = "Default Model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("We're driving in a simulation");
        }

    }
}
