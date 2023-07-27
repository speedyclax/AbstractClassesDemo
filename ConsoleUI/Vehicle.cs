using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public int Year { get; set; } = 1;
        public string Make { get; set; } = "Generic Make";
        public string Model { get; set; } = "Generic Model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual() 
        {
            Console.WriteLine("This vehicle is virtually in drive.");
        }



    }
}
