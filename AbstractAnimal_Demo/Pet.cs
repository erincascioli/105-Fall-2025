using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPolymorphism_Demo
{
    /// <summary>
    /// Abstract class cannot be instantiated.
    /// Exists only for its inheritance ability to share code with child classes.
    /// Children: Dog, Cat
    /// </summary>
    internal abstract class Pet
    {
        // ----------------------------------------------------------------
        // Fields shared with all child classes
        // ----------------------------------------------------------------
        protected string name;
        protected int age;

        /// <summary>
        /// Parameterized constructor of the Pet class
        /// </summary>
        /// <param name="name">Pet's name</param>
        /// <param name="age">Pet's age</param>
        public Pet(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // ----------------------------------------------------------------
        // Abstract methods 
        // ----------------------------------------------------------------

        /// <summary>
        // Abstract method that ALL children must implement
        public abstract void MakeSound();


        // ----------------------------------------------------------------
        // Virtual implementations  (children can override)
        // ----------------------------------------------------------------

        /// <summary>
        /// Child classes can choose to override this method if they desire.
        /// </summary>
        public virtual void Print()
        {
            Console.WriteLine("My pet's name is " + name);
            Console.WriteLine($"They are {age} years old.");
        }


        // ----------------------------------------------------------------
        // Overridden implementations 
        // ----------------------------------------------------------------

        /// <summary>
        /// Overridden from the Object class
        /// </summary>
        /// <returns>A string representation of this class.</returns>
        public override string ToString()
        {
            return "This pet's name is " + name + " and is " + age + " years old.";
        }        
    }
}
