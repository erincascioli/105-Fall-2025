
// Erin Cascioli
// 10/8/25
// Demo: Static methods in the Program class

namespace StaticMethods_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------------------------------
            // Calling other static methods we wrote today
            // ------------------------------------------------------------------------------------

            // First overload: Multiplies 2 values
            int product = ProductOfValues(10, 5);
            Console.WriteLine("The product of 10 and 5 is " + product);

            product = ProductOfValues(2, 4);
            Console.WriteLine("The product of 4 and 2 is " + product);

            // Second overload: Multiplies 3 values
            product = ProductOfValues(2, 3, 4);
            Console.WriteLine("The product of 2, 3 and 4 is " + product);

            // Or the method could handle printing inside its definition
            // Does not return a value
            PrintProduct(7, 4);

            // ------------------------------------------------------------------------------------
            // Code from today's in-class demo
            // ------------------------------------------------------------------------------------

            // Static method we wrote called PrintHeadline that requires the string
            //   of what to print to the Console window.
            PrintHeadline("Print 1 - 10 on separate lines");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            // Can use that same method as many times as I need it.
            // Be sure to "pass in" the correct string each time. 
            PrintHeadline("Get player's name to greet them");

            Console.Write("What is your name? ");
            string username = Console.ReadLine()!;
            Console.WriteLine($"Hi {username}!");

            // Can use that same method as many times as I need it.
            // Be sure to "pass in" the correct string each time. 
            PrintHeadline("Print many X's");

            Console.Write("Please enter a number: ");
            int userNumber = int.Parse(Console.ReadLine()!);
            for(int i = 0; i < userNumber; i++)
            {
                Console.Write("X");
            }

        } // END OF MAIN


        // ----------------------------------------------------------------------------------------
        // Let's write and practice with some other methods!
        // 1) Print headline (DONE!)
        // 2) Multiply 2 values, give back product (DONE!)
        // 3) Multiply 2 values, print product inside (DONE!)
        // 4) Overload: Multiply 3 values, return product (DONE!)

        // Remember: Go to definition and Find all references
        // Remember: XML comments!
        // ----------------------------------------------------------------------------------------

        /// <summary>
        /// Prints a headline for the next section of the program.
        /// </summary>
        /// <param name="task">Task description printed in the headline</param>
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
       /// Multiplies 2 integers and provides the result.
        /// </summary>
        /// <param name="value1">First number</param>
        /// <param name="value2">Second number</param>
        /// <returns>Product of those 2 numbers</returns>
        public static int ProductOfValues(int value1, int value2)
        {
            int product = value1 * value2;
            return product;

            //return value1 * value2;
        }
        /// <summary>
        /// Multiplies 3 integers and provides the result.
        /// </summary>
        /// <param name="value1">First number</param>
        /// <param name="value2">Second number</param>
        /// <param name="value3">Second number</param>
        /// <returns>Product of those 3 values</returns>
        public static int ProductOfValues(int value1, int value2, int value3)
        {
            int product = value1 * value2 * value3;
            return product;
        }

        /// <summary>
        /// Prints the product of 2 integers.
        /// </summary>
        /// <param name="value1">First number</param>
        /// <param name="value2">Second number</param>
        public static void PrintProduct(int value1, int value2)
        {
            Console.WriteLine($"The product of {value1} and {value2} is {value1 * value2}");
        }


    } // END OF PROGRAM CLASS
}
