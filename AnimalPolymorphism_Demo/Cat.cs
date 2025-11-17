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

        /// <summary>
        /// Unique method to the Cat class, representing a cat meowing.
        /// </summary>
        public void Meow()
        {
            Console.WriteLine("This cat meows.");
        }

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
