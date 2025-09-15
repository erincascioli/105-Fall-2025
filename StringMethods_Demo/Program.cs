// Erin Cascioli
// 9/12/25
// Demo: String methods

namespace StringMethods_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Variable block
            // ----------------------------------------------------------------
            string fruit = "plum";
            string petName = "Bandit";

            // Individual indices of strings
            Console.WriteLine(fruit[0]);                                    // p
            Console.WriteLine(fruit[fruit.Length - 1]);                     // m

            // Substring (with locally declared variables)
            string firstOfPet = petName.Substring(0, 3);                    // Ban
            string middlePartOfPet = petName.Substring(2, 2);               // nd
            string lastOfPet = petName.Substring(petName.Length - 2, 2);    // it

            Console.WriteLine("My name is \"Erin\"");


            // Special characters (Escape sequences)
            Console.WriteLine("My pet name is \"Bandit\".");
            Console.WriteLine("She said, \"He said, \'OMG\'. Can you believe it?\"");
            Console.WriteLine("\tThis text is tabbed over by 8 spaces.");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1\t2\t3\t4\t5");
            Console.WriteLine("abc\tdef\tghi\tjkl\tmno");

            Console.WriteLine("Users\\\\Documents\\Erin");
        }
    }
}
