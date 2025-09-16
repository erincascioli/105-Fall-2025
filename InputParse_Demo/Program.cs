// Erin Cascioli
// 9/15/25
// Demo: Input and parsing

namespace InputParse_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Variable declarations
            // Expecting any user provided values? Declare variables for each here!
            // ----------------------------------------------------------------
            string userName;
            string favoriteFood;
            string birthYearString;
            int birthYearInt;
            bool canFly;
            string canFlyString;


            // ----------------------------------------------------------------
            // Prompt the user for all data!  
            // Give explicit prompts for each data you expect.
            // Parse data to any necessary types other than string.
            // ----------------------------------------------------------------
            
            // ** Name is used as a string, no parsing needed.
            // ** Trim removes any leading or trailing spaces.
            // ** The ! removes warnings for a non-nullable type
            Console.Write("Enter your name: ");
            userName = Console.ReadLine()!.Trim();

            // Food is used as a string, no parsing needed.
            Console.Write("Enter your favorite food: ");
            favoriteFood = Console.ReadLine()!;

            // Year must be parsed into an integer for calculations later in the program
            Console.Write("Enter your birth year: ");
            birthYearString = Console.ReadLine()!;
            birthYearInt = int.Parse(birthYearString);
            
            // Flying must be parsed to a bool
            Console.Write("Can you fly? Enter 'true' or 'false': ");
            canFlyString = Console.ReadLine()!;
            canFly = bool.Parse(canFlyString);

            
            // ----------------------------------------------------------------
            // Changing color with Console.ForegroundColor and ConsoleColor
            // ----------------------------------------------------------------
            // Dark magenta text for the username
            Console.ForegroundColor = ConsoleColor.DarkMagenta;


            // ----------------------------------------------------------------
            // Print output after information has been retrieved
            // ----------------------------------------------------------------
            // Print output for user
            Console.WriteLine($"Hi, {userName}!");

            // Green text with white background for the rest of the text in the output
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            Console.WriteLine(
                $"Your birth year is {birthYearString} and your favorite food is {favoriteFood}.");
            Console.WriteLine($"Your age is {(2025 - birthYearInt)}.");
            Console.WriteLine($"True or false? You can fly. {canFly}");
        }
    }
}
