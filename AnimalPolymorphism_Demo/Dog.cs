using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPolymorphism_Demo
{
    internal class Dog : Pet
    {
        /// <summary>
        /// Paramaterized constructor of this class
        /// </summary>
        /// <param name="name">Name of this Dog</param>
        /// <param name="age">Age of this Dog</param>
        public Dog(string name, int age) : 
            base(name, age)
        {
            // Nothing unique to assign a value to...
            // Nothing else needs to occur!
        }

        // ----------------------------------------------------------------
        // Unique methods to this Dog class
        // ----------------------------------------------------------------

        /// <summary>
        /// Representing a dog barking
        /// </summary>
        public void Bark()
        {
            Console.WriteLine("This dog barks.");
        }

        /// <summary>
        /// Overridden from parent, prints information about this class.
        /// </summary>
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"The dogs name is {name} and is {age} years old.");
        }

        /// <summary>
        /// Overridden from Pet, returns a string representation of this class.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + " additional child information";
        }
    }
}
