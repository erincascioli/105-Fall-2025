using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo2
{
    /// <summary>
    /// Parent class for any number of children.
    /// Has no idea who, if any, children are.
    /// Cannot access any child class data or behaviors.
    /// </summary>
    internal class Parent
    {
        // --------------------------------------------------------------------
        // Fields of the Parent class
        // All fields are shared with the child!  (even private ones!)
        // --------------------------------------------------------------------
        protected string someString;
        protected double someNumber;
        protected bool someBool;


        // --------------------------------------------------------------------
        // Constructor(s) of the Parent class
        // One of these must run before a Child is fully instantiated.
        // --------------------------------------------------------------------
        public Parent()
        {
            Console.WriteLine("Parent default constructor running!");
            someString = "Whatever";
            someNumber = 123;
            someBool = true;
        }

        public Parent(string someString, double someNumber)
        {
            Console.WriteLine("Parent parameterized constructor running!");

            // Set custom data for these 2 fields
            this.someString = someString;
            this.someNumber = someNumber;

            // Set default data for this field
            someBool = true;
        }


        // --------------------------------------------------------------------
        // Methods of the Parent class
        // All methods are shared with the child!  (even private ones!)
        // These can be called by any child class using the "base" keyword.
        // --------------------------------------------------------------------
        public void PrintParent()
        {
            Console.WriteLine("This is data from the Parent class:");
            Console.WriteLine(someString);
            Console.WriteLine(someNumber);
            Console.WriteLine(someBool);
        }
    }
}
