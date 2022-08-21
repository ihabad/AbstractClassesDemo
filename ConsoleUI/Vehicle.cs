using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public int Year { get; set; } = 2022;
        public string Make { get; set; } = "BMW";
        public string Model { get; set; } = "i8";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine();
        }
    }

}
