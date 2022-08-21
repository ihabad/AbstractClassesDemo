using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine();
        }

        public bool HasTruck { get; set; }

        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name}");
        }
    }
}
