
// Erin Cascioli
// 10/22/25
// Demo:  Using TryParse and Random

namespace RandomTryParse_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // TryParse
            // ----------------------------------------------------------------

            int parsedResult = -1;          // OUT parameter
            bool success = false;           // TryParse returns
            
            Console.Write("Enter any positive integer 0 through 10: ");
            success = int.TryParse(Console.ReadLine()!, out parsedResult);
    
            // WRITE THE BODY OF A WHILE LOOP TO CONTINUALLY PROMPT USER
            //   TO PROVIDE A VALID VALUE IF THEIR GIVEN VALUE IS INVALID
            while( !success || (parsedResult < 0 || parsedResult > 10) )
            {
                Console.Write("Bad input. Try again: ");
                success = int.TryParse(Console.ReadLine()!, out parsedResult);
            }

            Console.WriteLine(parsedResult);


            // ----------------------------------------------------------------
            // Random
            // ----------------------------------------------------------------

            // Your program only needs ONE Random object - you can call .Next or
            //   .NextDouble as many times as needed!  
            Random myRNG = new Random();

            // Generating random values as both doubles and integers
            double val1;
            int val2;

            // A single random value:
            val1 = myRNG.NextDouble();
            val2 = myRNG.Next();

            for(int i = 0; i < 10; i++)
            {
                // Generate both a double and an integer (in the range of 0 through int.MaxValue)
                val1 = myRNG.NextDouble();
                val2 = myRNG.Next();

                // Print to see what was generated
                Console.WriteLine($"Double: {val1}  Integer: {val2}");
            }

            // 10 more values with different ranges (1 - 10)
            for (int i = 0; i < 10; i++)
            {
                // Generate a ranged integer (0 through 10, inclusive)
                val2 = myRNG.Next(1, 11);

                // Print to see what was generated
                Console.WriteLine($"Integer from 1 - 10: {val2}");
            }
        }
    }
}
