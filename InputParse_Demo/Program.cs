namespace InputParse_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable declarations and initializations
            string userName = "Timmy the Timmy XXVII, Bacon Lover 42, John Microsoft";
            string favoriteFood = "bacon";
            int birthYear = 0;

            // Dark magenta text for the username
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            // Print output for user
            Console.WriteLine($"Hi, {userName}!");

            // Green text for the rest of the text in the output
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Red;

            // Can separate long lines like either of the statements below:
            // 1.
            Console.WriteLine(
                $"Your birth year is {birthYear} and your favorite food is {favoriteFood}.");
            // 2. 
            Console.WriteLine($"Your birth year is {birthYear} and your favorite food" +
                $" is {favoriteFood}.");



            // Print "Hi" in magenta!
            //Console.ForegroundColor = ConsoleColor.Magenta;
            // Print rest of the output in yellow!
            //Console.ForegroundColor = ConsoleColor.Yellow;

            /*
            string userName = "Isaac John Arbuckle III, HRH";
            string favoriteFood = "string cheese";
            int birthYear = 1;

            // Print "Hi" in magenta!
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"Hi, ");

            // The print the name in green!
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{userName}!");

            // Print rest of the output in yellow!
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Can separate long lines like either of the statements below:
            // 1.
            Console.WriteLine(
                $"Your birth year is {birthYear} and your favorite food is {favoriteFood}.");
            // 2. 
            Console.WriteLine($"Your birth year is {birthYear} and your favorite food" +
                $" is {favoriteFood}.");
            */

            /*
            // ----------------------------------------------------------------
            // NEW DEMO - Erin only
            // Ask user for information
            // Perform math on the birth year
            // Add a new variable for parse type bool, yes or no question
            // ----------------------------------------------------------------
            string userName;
            string favoriteFood;
            string birthYearString;
            int birthYearInt;
            string likeCatsString;
            bool likeCatsBool;

            Console.Write("Hi! Please enter your name: ");
            userName = Console.ReadLine();

            Console.Write("Please enter your favorite food: ");
            favoriteFood = Console.ReadLine();

            Console.Write("What year were you born? ");
            birthYearString = Console.ReadLine();

            // PARSE the string to an integer
            birthYearInt = int.Parse(birthYearString);

            Console.Write("Do you like cats? Type 'true' or 'false': ");
            likeCatsString = Console.ReadLine();

            // PARSE the string to an integer
           likeCatsBool= bool.Parse(likeCatsString);

            Console.WriteLine("-------------------------------------------------");
            
            // Print "Hi" in magenta!
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"Hi, ");

            // The print the name in green!
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{userName}!");

            // Print rest of the output in yellow!
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                $"Your birth year is {birthYearInt} and your favorite food is {favoriteFood}.");

            // Calculate the user's age
            Console.WriteLine($"Your age is {(2025 - birthYearInt)}");

            Console.WriteLine($"Do you like cats? {likeCatsBool}");
            */
        }
    }
}
