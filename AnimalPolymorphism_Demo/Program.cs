namespace AnimalPolymorphism_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Parent and Child class instantiations
            // ----------------------------------------------------------------

            Pet genericPet = new Pet("Tim", 203);
            Dog pepper = new Dog("Pepper", 9);
            Cat smokie = new Cat("Smokie", 4, 105);

            // ----------------------------------------------------------------
            // Method overloading
            // ----------------------------------------------------------------

            genericPet.Print();
            Console.WriteLine("--------------");
            pepper.Print();
            Console.WriteLine("--------------");
            smokie.Print();

            // ----------------------------------------------------------------
            // ToString() overriding
            // ----------------------------------------------------------------

            // Call the ToString methods
            Console.WriteLine(genericPet.ToString());

            // Can save in a variable first if desired
            string dogInfo = pepper.ToString();

            // ----------------------------------------------------------------
            // Polymorphism
            // ----------------------------------------------------------------

            Pet myPetObj = new Pet("Bob", 18);
            Cat myCatObj = new Cat("Pete", 2, 1);
            Dog myDogObj = new Dog("Marley", 5);

            //Pet myObj1 = new Cat("Cat 1", 1, 1);
            //Pet myObj2 = new Dog("Dog 1", 1);

            Pet[] myPets = new Pet[5];
            myPets[0] = myPetObj;
            myPets[1] = myCatObj;
            myPets[2] = myDogObj;
            myPets[3] = new Cat("Cat 1", 1, 1);
            myPets[4] = new Dog("Dog 1", 1);

            // Downcast
            if (myPets[1] is Cat)
            {
                Cat objectAsCat = (Cat)myPets[1];
                int catsRudenessLevel = objectAsCat.Rudeness;
            }            

            if (myPets[1] is Dog)
            {
                Dog objectAsDog = (Dog)myPets[1];
                objectAsDog.Bark();

                ((Dog)myPets[2]).Bark();
            }            
        }
    }
}
