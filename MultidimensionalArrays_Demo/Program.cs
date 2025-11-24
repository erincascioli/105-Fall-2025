
// Erin Cascioli
// 11/24/25
// Demo: Multidimensional Arrays

namespace MultidimensionalArrays_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Can hold the number of rows and columns in variables for ease of use later
            int rows = 3;
            int columns = 2;

            // ----------------------------------------------------------------
            // Multidimensional Array: Declaration
            // ----------------------------------------------------------------
            // Initialize the array, row major (rows first)
            string[,] favoriteCharacter = new string[rows, columns];

            // ----------------------------------------------------------------
            // Multidimensional Array: Enter data
            // ----------------------------------------------------------------
            // Add data to each element with both row & column index
            favoriteCharacter[0, 0] = "Davey";          // Name
            favoriteCharacter[0, 1] = "Solaire";        // Char
            favoriteCharacter[1, 0] = "Jason";          // Name
            favoriteCharacter[1, 1] = "Vincent";        // Char
            favoriteCharacter[2, 0] = "Adrian";         // Name
            favoriteCharacter[2, 1] = "Cloud Strife";   // Char

            // Need the number of rows and columns? Call GetLength.
            Console.WriteLine(favoriteCharacter.GetLength(0));
            Console.WriteLine(favoriteCharacter.GetLength(1));

            // ----------------------------------------------------------------
            // Multidimensional Array Iteration
            // ----------------------------------------------------------------

            // **********
            // 1) Need every element on a separate line:
            // **********

            // Can use a nested for loop to iterate through all data, one by one
            for (int row = 0; row < rows; row++)
            //OR for (int row = 0; row < favoriteCharacter.GetLength(0); row++)
            {
                for(int col = 0; col < columns; col++)
                //OR for(int col = 0; col < favoriteCharacter.GetLength(1); col++)
                {
                    Console.WriteLine(favoriteCharacter[row, col]);
                }
            }

            Console.WriteLine("------------------------------");

            // **********
            // 2. Know what the columns stand for?  Know they're always the same?
            // Can use a single for loop and hard-code column values for output formatting:
            // **********

            // Expected output is "Name: Character"
            for (int row = 0; row < rows; row++)
            {
                Console.Write(favoriteCharacter[row, 0] + ": ");
                Console.WriteLine(favoriteCharacter[row, 1]);
            }
        }
    }
}
