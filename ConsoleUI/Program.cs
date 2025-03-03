﻿using System;
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
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles  

            var Vehicle =  new List <Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            Car i8 = new Car() 
            {
                HasTruck = true,
                Make ="BMW",
                Model = "i8",
                Year = 2022
            };

            Motorcycle motorcycle = new Motorcycle() 
            {
                Model = "sport",
                Make = "Yamaha",
                Year = 2020
            };

            Vehicle mpv = new Car()
            {
                Model = "CX-5",
                Year = 2021,
                Make = "SUV"   
            };

            Vehicle suv = new Car()
            {
                Year = 2023,
                Model = "RAV4",
                Make = "PRIME"
            };


            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */


            Vehicle.Add(i8);
            Vehicle.Add(motorcycle);
            Vehicle.Add(mpv);
            Vehicle.Add(suv);

            foreach (var item in Vehicle)

            {
                Console.WriteLine("Take a look at this, you might like it:");
                Console.WriteLine($"Make {item.Make} , Model {item.Model} , Year {item.Year} ");
            }


            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
