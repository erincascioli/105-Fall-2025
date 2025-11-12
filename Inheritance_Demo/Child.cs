using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo
{
    /// <summary>
    /// Child class of the Parent class.
    /// </summary>
    internal class Child : Parent
    {
        // --------------------------------------------------------------------
        // Child classes can have their own unique fields
        // The parent class CANNOT access anything in the child class!
        // These unique fields are invisible to the parent!
        // --------------------------------------------------------------------

        // Field unique to JUST this child class
        public string uniqueWord;


        // --------------------------------------------------------------------
        // Every Child class must call a parent class constructor
        // If one is not specified, the default constructor of the parent class is called.
        // --------------------------------------------------------------------

        /// <summary>
        /// Child class constructor calls the parent class's default constructor.
        /// </summary>
        public Child() : base()
        {
            // No need to assign values for the type and price...
            // The parent class is ALREADY doing that!

            // What do I need to do then?  Only focus on data unique to this class!
            // Assign values to the
            // unique data of the class
            uniqueWord = "Lollipop";
            parentOrChild = "child";
            Console.WriteLine("I am in the CHILD constructor!");
        }

        /// <summary>
        /// Child class constructor calls the parent class's parameterized constructor,
        /// passing in a type and a price to the parent class. Additionally contains a unique field
        /// specific to this child only.
        /// </summary>
        /// <param name="type">Type of thing</param>
        /// <param name="price">Price of thing</param>
        /// <param name="word">Word for this Child thing</param>
        public Child(string type, double price, string word) 
            : base(type, price)
        {
            // No need to assign values for the type and price...
            // The parent class is ALREADY doing that!

            // What do I need to do then?  Only focus on data unique to this class!
            // Assign values to the unique data of the class
            this.uniqueWord = word;
            parentOrChild = "child";
        }

        // --------------------------------------------------------------------
        // The child class has access to ALL methods of the parent class
        // and can call any of those methods.
        // --------------------------------------------------------------------

        /// <summary>
        /// Prints information about this Child class, including values for all fields of the class.
        /// Child class OVERRIDES the parent class's PRINT method.
        /// </summary>
        public override void Print()
        {
            // Since child classes have access to all parent methods, they can call those methods
            //   anytime it would be beneficial to not replicate the work in this child.
            // i.e. The Print method ALREADY prints out the type, price, and array - 
            //   so why copy/paste that code again in this class? Just call the method!
            base.Print();
            Console.WriteLine(uniqueWord);
        }

        /// <summary>
        /// Provides a string representation of this class.
        /// </summary>
        /// <returns>String representation of the Child</returns>
        public override string ToString()
        {
            return base.ToString() + " unique info: " + uniqueWord;
        }

        /// <summary>
        /// Method specific to a child class, is unique to this class.
        /// </summary>
        public void UniqueMethod()
        {
            Console.WriteLine("UNIQUE!");
        }
    }
}
