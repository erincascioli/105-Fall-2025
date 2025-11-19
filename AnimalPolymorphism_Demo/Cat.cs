using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnimalPolymorphism_Demo
{
    internal class Cat : Pet
    {
        // ----------------------------------------------------------------
        // Unique fields of this class
        // ----------------------------------------------------------------
        private int rudeness;


        // ----------------------------------------------------------------
        // Unique properties of this class
        // ----------------------------------------------------------------
        public int Rudeness
        {
            get { return rudeness; }
        }

        // ----------------------------------------------------------------
        // Constructor calls base class
        // ----------------------------------------------------------------
        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="name">Name of this Cat</param>
        /// <param name="age">Age of this Cat</param>
        /// <param name="rude">Rudeness level of this Cat</param>
        public Cat(string name, int age, int rude) :
            base(name, age)
        {
            rudeness = rude;
        }


        // ----------------------------------------------------------------
        // Unique methods to this Dog class
        // ----------------------------------------------------------------

        /// <summary>
        /// Unique method to the Cat class, representing a cat meowing.
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("This cat meows.");
        }


        // ----------------------------------------------------------------
        // Overriding parent methods
        // ----------------------------------------------------------------

        /// <summary>
        /// Overridden from the Pet class, prints information about this Cat object.
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"The cat name is {name} and is {age} years old.");
            Console.WriteLine($"The cat has a rudeness level of {rudeness}.");
        }
    }
}
