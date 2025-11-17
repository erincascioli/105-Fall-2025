using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPolymorphism_Demo
{
    internal class Pet
    {
        // Data (field): Name, Hair length, age, owner, tail/no tail, weight
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

        /// <summary>
        /// Child classes can choose to override this method if they desire.
        /// </summary>
        public virtual void Print()
        {
            Console.WriteLine("My pet's name is " + name);
            Console.WriteLine($"They are {age} years old.");
        }

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
