namespace Array_Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 5;

            // ----------------------------------------------------------------
            // Unsure what the array size will be until later in the program?
            // Declare and initialize on separate lines.
            // ----------------------------------------------------------------
            int[] numberArray1;
           
            numberArray1 = new int[arraySize];
            numberArray1[0] = 2;
            numberArray1[1] = 4;
            numberArray1[2] = 6;

            // ----------------------------------------------------------------
            // Watch for index out of range exceptions!
            // Runtime error crashes the program.
            // ----------------------------------------------------------------
            //numberArray1[-1] = 284;

            // ----------------------------------------------------------------
            // Array access of individual elements
            // ----------------------------------------------------------------
            Console.WriteLine(numberArray1[0]);                           // First element, value 2
            Console.WriteLine(numberArray1[numberArray1.Length - 1]);     // Last element, value 6
            //Console.WriteLine(numberArray1[numberArray1.Length]);       // Crash!

            // ----------------------------------------------------------------
            // Know the size upon declaration? Feel free to use one line.
            // ----------------------------------------------------------------
            int[] numberArray2 = new int[4];
            numberArray2[0] = 5;
            numberArray2[1] = 10;
            numberArray2[2] = 15;
            numberArray2[3] = 20;

            // ----------------------------------------------------------------
            // Literal arrays - really only useful when you know the size AND
            //   all the data in the array. 
            // ----------------------------------------------------------------
            int[] numberArray3 = { 10, 20, 30, 40, 50 };
            string[] favoriteFoods = 
                { "tiramisu", "salad", "spice cake", "teriyaki chicken", "fondue", "osh" };

            // ----------------------------------------------------------------
            // Formatting strings in an array
            // ----------------------------------------------------------------
            Console.WriteLine(favoriteFoods[1]);
            Console.WriteLine(favoriteFoods[1].ToUpper());

            Console.WriteLine(favoriteFoods[1][0]);

            favoriteFoods[0] = "f";

            for (int i = 0; i < favoriteFoods.Length; i++)
            {
                Console.WriteLine(i + " " + favoriteFoods[i]);
            }

            //Console.WriteLine(favoriteFoods);


            // ----------------------------------------------------------------
            // Searching through an array for a target value
            // ----------------------------------------------------------------
            // Pseudocode:
            // Target value of 23
            // Iterate through each value in the array
            // WHILE (there are values in the array to still search)
            //      Compare against my target value
            //      Find it? end the search. report "true"
            //      Not there? keep searching
            // EXIT loop - value is either found or not found!

            Console.WriteLine();
        }
    }
}
