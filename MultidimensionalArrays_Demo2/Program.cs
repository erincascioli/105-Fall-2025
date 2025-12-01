namespace MultidimensionalArrays_Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 3;
            int columns = 2;

            string[,] eyeColors = new string[rows, columns];

            eyeColors[0, 0] = "Adam";
            eyeColors[0, 1] = "teal";

            eyeColors[1, 0] = "Austin";
            eyeColors[1, 1] = "blue";

            eyeColors[2, 0] = "Henry";
            eyeColors[2, 1] = "hazel";

            for(int row = 0; row < eyeColors.GetLength(0); row++)
            {
                for(int col = 0; col < eyeColors.GetLength(1); col++)
                {
                    Console.WriteLine(eyeColors[row,col]);
                }
            }

            Console.WriteLine("-----------------------------------");

            foreach(string data in eyeColors)
            {
                Console.WriteLine(data);
            }

            Console.WriteLine("-----------------------------------");

            // EXPECTED OUTPUT:  
            // adam: teal
            // austin: blue
            // henry: hazel
            int numRows = eyeColors.GetLength(0);
            int numCols = eyeColors.GetLength(1);


            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    if (col == 0)
                    {
                        Console.Write(eyeColors[row, col] + ":");
                    }
                    else 
                    {
                        Console.Write(eyeColors[row, col]);
                    }
                }

                Console.WriteLine();
            }

            for(int row = 0; row < eyeColors.GetLength(0); row++)
            {
                Console.WriteLine(eyeColors[row, 0] + ":" + eyeColors[row, 1]);
            }
        }
    }
}
