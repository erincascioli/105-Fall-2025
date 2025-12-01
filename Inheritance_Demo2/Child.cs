using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo2
{

    /// <summary>
    /// Child class of the class Parent.
    /// Receives ALL class members of Parent.
    /// Use the base keyword to call constructors, or to invoke any parent class methods.
    /// </summary>
    internal class Child : Parent
    {
        // --------------------------------------------------------------------
        // Unique fields in the child class
        // --------------------------------------------------------------------
        private string uniqueWord;

        // --------------------------------------------------------------------
        // Child class constructor(s)
        // --------------------------------------------------------------------
        // Every child class constructor must call a parent constructor.
        // Didn't call one? C# will call the default one for you. 
        // However, this Child constructor explicitly calls the default.
        // Why? Communication! If you intend to call the default, communicate
        //   that by calling base().
        public Child() : base()
        {
            // No need to assign values to the someString, someNumber, or 
            //   someBool fields - because the parent class constructor already did that!
            Console.WriteLine("Child constructor running!");

            uniqueWord = "default word";
        }

        /// <summary>
        /// Child class constructor calls the parent class's parameterized
        /// </summary>
        /// <param name="word"></param>
        /// <param name="number"></param>
        public Child(string word, double number, string uniqueWord) : 
            base(word, number)
        {
            Console.WriteLine("Child constructor running!");

            this.uniqueWord = uniqueWord;
        }


        // --------------------------------------------------------------------
        // Child class method(s)
        // --------------------------------------------------------------------
        public void PrintChild()
        {
            base.PrintParent();
            Console.WriteLine("This is data from the Child class:");
            Console.WriteLine(uniqueWord);
        }
    }
}
