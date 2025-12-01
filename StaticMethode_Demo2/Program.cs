namespace StaticMethode_Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------------------------------
            // VS shortcut:  Go to definition
            int signOfNumber = Math.Sign(238);

            // VS shortcut:  Find all references
            // ------------------------------------------------------------------------------------

            Concatenate("abc", "ef");


            // ------------------------------------------------------------------------------------
            // Multiplication overloaded methods:
            // ------------------------------------------------------------------------------------
            int answer = ProductOfValues(2, 6, 4);     // 12
            Console.WriteLine("The answer is " + answer);

            answer = ProductOfValues(8, 8);         // 64
            Console.WriteLine("The answer is " + answer);

            answer = ProductOfValues(2, 4);      // 64
            Console.WriteLine("The answer is " + answer);

            // ------------------------------------------------------------------------------------
            // Code from today's warmup demo
            // ------------------------------------------------------------------------------------

            // "Calling" or "invoking" a method that we wrote ourselves!
            PrintHeadline("Print 1 - 10 on separate lines");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            // Can call/invoke as many times as necessary
            // Be sure to "pass in" the appropriate string when calling.
            PrintHeadline("Get player's name to greet them");

            Console.Write("What is your name? ");
            string userName = Console.ReadLine()!;
            Console.WriteLine($"Hi {userName}!");

            // Can call/invoke as many times as necessary
            // Be sure to "pass in" the appropriate string when calling.
            PrintHeadline("Print many X's");

            Console.Write("What is your number? ");
            int userNumber = int.Parse(Console.ReadLine()!);
            for(int i = 0; i < userNumber; i++)
            {
                Console.Write("X");
            }
        } // END MAIN


        // ----------------------------------------------------------------------------------------
        // Let's write and practice with some other methods!
        // 1) Print headline (DONE!)
        // 2) Multiply 2 values, return product
        // 3) Overload: Multiply 3 values, return product
        // 4) Overload: Multiply 4 values, return product
        // 5) Multiply 2 values, print product inside

        // Remember: Go to definition and Find all references
        // Remember: XML comments!
        // ----------------------------------------------------------------------------------------

        /// <summary>
        /// One sentence summary
        /// </summary>
        /// <param name="task">Description all params</param>
        public static void PrintHeadline(string task)
        {
            // Print a visual divider in green
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("...............................");

            // Print describing text in yellow
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(task);

            // Print ending visual divider in green again
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("...............................");

            // Prepare for following text to be white
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns>What is being returned</returns>
        public static int ProductOfValues( int value1, int value2 )
        {
            int product = value1 * value2;
            return product;
        }

        public static void PrintProduct(int value1, int value2)
        {
            Console.WriteLine($"The product of {value1} and {value2} is {value1 * value2}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <param name="value3"></param>
        /// <returns></returns>
        public static int ProductOfValues(int value1, int value2, int value3)
        {
            int product = value1 * value2 * value3;
            return product;
        }

        public static int ProductOfValues(int[] intArray)
        {
            int product = 0;
            for(int i = 0; i < intArray.Length; i++)
            {
                product *= intArray[i];
            }
            return product;
        }

        /// <summary>
        /// Concatenates first and second strings, as long as neither are null.
        /// </summary>
        /// <param name="firstString">First string</param>
        /// <param name="secondString">Second string</param>
        /// <returns>Concatenated string where string1 + string2</returns>
        public static string Concatenate(string firstString, string secondString)
        {
            if(firstString == null)
            {
                return secondString;
            }
            else if (secondString == null)
            {
                return firstString;
            }

            return firstString + secondString;
        }

    } // END PROGRAM
}
