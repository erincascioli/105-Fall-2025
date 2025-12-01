using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPolymorphism_Demo
{
    internal abstract class Pet
    {
        // ----------------------------------------------------------------
        // Fields shared to all children
        // ----------------------------------------------------------------
        protected string name;
        protected int age;


        // ----------------------------------------------------------------
        // Constructor - must be called by a child class
        // ----------------------------------------------------------------
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
        // Virtual methods
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
        // Overriding methods from parent (Object) class
        // ----------------------------------------------------------------

        /// <summary>
        /// Overridden from the Object class
        /// </summary>
        /// <returns>A string representation of this class.</returns>
        public override string ToString()
        {
            return "This pet's name is " + name + " and is " + age + " years old.";
        }    
        
        public static void PrintPet()
        {
            Console.WriteLine("Hi! I am a pet!");
        }

        public abstract void MakeSound();
    }
}
