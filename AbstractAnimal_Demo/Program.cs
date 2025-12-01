
// Erin Cascioli
// 11/17/25
// Demo: Abstract classes and abstract methods

namespace AnimalPolymorphism_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Parent and Child class instantiations
            // ----------------------------------------------------------------

            // Abstract classes cannot be instantiated!
            //Pet genericPet = new Pet("Tim", 203);
            Dog pepper = new Dog("Pepper", 9);
            Cat smokie = new Cat("Smokie", 4, 105);


            // ----------------------------------------------------------------
            // Method overloading
            // ----------------------------------------------------------------
            pepper.Print();
            Console.WriteLine("--------------");
            smokie.Print();


            // ----------------------------------------------------------------
            // ToString() overriding
            // ----------------------------------------------------------------
            // Call the ToString method in a write statement
            Console.WriteLine(smokie.ToString());

            // Can save in a variable first if desired
            string dogInfo = pepper.ToString();


            // ----------------------------------------------------------------
            // Polymorphism
            // ----------------------------------------------------------------
            Cat myCatObj = new Cat("Pete", 2, 1);
            Dog myDogObj = new Dog("Marley", 5);

            Pet[] myPets = new Pet[4];
            myPets[0] = myCatObj;
            myPets[1] = myDogObj;
            myPets[2] = new Cat("Cat 1", 1, 1);
            myPets[3] = new Dog("Dog 1", 1);

            // Methods that are defined in the parent class can be freely called in child
            //   classes without the need to downcast!
            myPets[3].MakeSound();

            // Must downcast for child-specific methods and properties!
            if (myPets[1] is Cat)
            {
                Cat objectAsCat = (Cat)myPets[1];

                // Access unique property to child
                int catsRudenessLevel = objectAsCat.Rudeness;
                Console.WriteLine($"This cat is {catsRudenessLevel} rude!");

                // Call unique method to child
                objectAsCat.WreakHavoc();
            }                     
        }
    }
}
