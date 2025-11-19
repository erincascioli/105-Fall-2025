using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPolymorphism_Demo
{
    internal class Fish : Pet
    {
        public Fish(string name, int age) : 
            base(name ,age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Blub");
        }
    }
}
