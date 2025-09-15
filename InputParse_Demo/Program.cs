namespace InputParse_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = "Isaac John Arbuckle III, HRH";
            string favoriteFood = "string cheese";
            int birthYear = 1;

            // Print in magenta!
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"Hi, ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{userName}!");
            Console.Write($"{userName}! \n");

            // Print in yellow!
            Console.ForegroundColor = ConsoleColor.Yellow;
            // 1.
            Console.WriteLine(
                $"Your birth year is {birthYear} and your favorite food is {favoriteFood}.");
            // 2. 
            Console.WriteLine($"Your birth year is {birthYear} and your favorite food" +
                $" is {favoriteFood}.");
        }
    }
}
