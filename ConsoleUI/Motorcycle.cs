using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {

        }

        public bool HasSideCart { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcycle is cruising through the road"); 
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("Okay the motorcycle is drivable in cyberspace");
        }
    }
}
