using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo
{
    /// <summary>
    /// Parent to the Child class.
    /// </summary>
    internal class Parent
    {
        // --------------------------------------------------------------------
        // Fields are shared with ALL children
        // --------------------------------------------------------------------

        public string type;
        public double price;
        public bool[] lieDetector;

        // --------------------------------------------------------------------
        // The Parent class constructor will always run first
        // --------------------------------------------------------------------

        /// <summary>
        /// Default constructor of this Parent class.
        /// </summary>
        public Parent()
        {
            // Assign default data to all 3 fields of the class.
            type = "Wonder Woman";
            price = 2.74;
            lieDetector = new bool[2];
            lieDetector[0] = true;
            lieDetector[1] = false;

            // Printing JUST to see which constructor runs first in the demo. :)
            Console.WriteLine("I am in the PARENT constructor!");
        }

        /// <summary>
        /// Parameterized constructor assigns custom data to the type and price fields.
        /// </summary>
        /// <param name="type">Type of thing</param>
        /// <param name="price">Price of thing</param>
        public Parent(string type, double price)
        {
            // Accept parametized values for the type and price
            this.type = type;
            this.price = price;

            // Default the array to this data
            lieDetector = new bool[2];
            lieDetector[0] = true;
            lieDetector[1] = false;
        }

        // --------------------------------------------------------------------
        // All of the parent class methods are shared with ALL children
        // --------------------------------------------------------------------
        
        /// <summary>
        /// Prints information about all 3 fields of the class: type, price, and lie detector.
        /// </summary>
        public void PrintParent()
        {
            Console.WriteLine(type);
            Console.WriteLine($"{price:C2}");
            Console.WriteLine($"These are the {lieDetector.Length} values in my array: ");
            foreach(bool element in lieDetector)
            {
                Console.WriteLine(element);
            }
        }
    }
}
