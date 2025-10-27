namespace RandomTryParse_Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // Out variable declared ahead of time:
            int parsedResult = -1;

            // Bool variable to determine whether the parse was successful or not
            bool parseSuccess = false;

            Console.Write("Enter a value between 0 and 10: ");
            parseSuccess = int.TryParse(Console.ReadLine()!, out parsedResult);

            // WRITE A WHILE LOOP THAT PROMPTS THE USER FOR A VALID INTEGER
            //   BETWEEN 0 AND 10 WHEN THEY PROVIDE BAD DATA
            // BAD DATA -->  "HORSE", 109384.6, "TRUE", 10384757492927474, -1, 11

            while( !parseSuccess || (parsedResult < 0 || parsedResult > 10) )
            {
                Console.Write("Bad data, try again. Enter a value between 0 and 10: ");
                parseSuccess = int.TryParse(Console.ReadLine()!, out parsedResult);
            }
            */

            // ----------------------------------------------------------------
            // Random
            // ----------------------------------------------------------------

            // Declare a single Random object
            Random myRNG = new Random();

            // Ask it for a random number
            for(int i = 0; i < 1000; i++)
            {
                Console.WriteLine(myRNG.N);
            }



        }
    }
}
