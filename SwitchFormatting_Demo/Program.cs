// Erin Cascioli
// 9/24/25
// Demo: Switch statements and string formatting

namespace SwitchFormatting_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------------------------------
            // String formatting
            // ------------------------------------------------------------------------------------
            // Different variable types
            // C: Currency
            // N: Number
            // P: Percent
            double smallNumber = 20/100.0;
            double largerNumber = 103847.99;
            double bigNumber = 5673287353747293.4836;

            // Formatting can happen inside of a ToString method.
            Console.WriteLine(smallNumber.ToString("P3"));
            Console.WriteLine(largerNumber.ToString("C2"));
            Console.WriteLine(bigNumber.ToString("N5"));

            // Or it can happen with string interpolation
            Console.WriteLine($"{smallNumber:P3}");
            Console.WriteLine($"{largerNumber:C2}");
            Console.WriteLine($"{bigNumber:N5}");


            // ------------------------------------------------------------------------------------
            // Switch statements
            // ------------------------------------------------------------------------------------
           
            // Variables for program
            string userFlavor = "";

            // Present menu to the customer
            Console.WriteLine("\n\nWelcome to the ice cream shop.");
            Console.WriteLine("The choices are: ");
            Console.WriteLine("\t-Vanilla \t-Pistachio \t-Strawberry");

            // Prompt for and gather input
            Console.Write("Which flavor do you want? >> ");
            userFlavor = Console.ReadLine()!.Trim().ToLower();

            // Possibilities:
            // - vanilla
            // - pistachio
            // - strawberry

            // ------------------------------------------------------------------------------------
            // Switch statement with discrete possibilities and a default 
            // ------------------------------------------------------------------------------------
            switch (userFlavor)
            {
                case "vanilla":
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Vanilla is the best!");
                    break;

                case "pistachio":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Pistachio is the best!");
                    break;

                case "strawberry":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Strawberry is the best!");
                    break;

                default:
                    Console.WriteLine("Ice cream flavor is not an option here. " +
                        "No color selected.");
                    break;
            }


            // ------------------------------------------------------------------------------------
            // Switch statement ranges 
            // ------------------------------------------------------------------------------------

            // Switch statements can have ranges, but they must be ordered properly
            int number = 100;
            switch(number)
            {
                case < 4:
                    Console.WriteLine("Less than 4");
                    break;
                case < 8:
                    Console.WriteLine("4 - 7!");
                    break;
            }


            // ------------------------------------------------------------------------------------
            // The switch is a replacement for the code below:
            // ------------------------------------------------------------------------------------
            /*
            if(userFlavor == "vanilla")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Vanilla is the best!");
            }
            else if(userFlavor == "pistachio")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pistachio is the best!");
            }
            else if (userFlavor == "strawberry")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Strawberry is the best!");
            }
            else
            {
                Console.WriteLine("Ice cream flavor is not an option here. No color selected.");
            }
            
            // This is here just so we can see the switch statement exit
            Console.WriteLine("This statement is after the switch.");
            */
        }
    }
}
