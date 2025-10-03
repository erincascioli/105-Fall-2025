// Erin Cascioli
// 10/3/25
// Demo: 1-dimensional arrays


namespace Arrays_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Declare an array
            // Identifier should notate plurality or the type of data structure
            // ----------------------------------------------------------------

            double[] prices;        // or priceArray
            int sizeOfArrays = 3;

            // ----------------------------------------------------------------
            // Initialize an array
            // This allocates space in memory depending on the defined array size
            // ----------------------------------------------------------------

            prices = new double[sizeOfArrays];

            // ----------------------------------------------------------------
            // Assign data to the array
            // ----------------------------------------------------------------

            // Add data for each index of the array
            prices[0] = 172.5;
            prices[1] = 50;
            prices[2] = 29.7;

            // Can go out of bounds here!
            // Index 5 does not exist. Runtime error occurs!
            //prices[5] = 3948;

            // ----------------------------------------------------------------
            // Literal array (declare and initialize!)
            // Can be used when you know all the data at the time of declaration.
            // ----------------------------------------------------------------

            string[] items = { "shield", "potion", "biscuit"};

            // ----------------------------------------------------------------
            // Retrieve a value from an element in the array
            // Array exceptions (runtime errors)
            // ----------------------------------------------------------------

            Console.WriteLine(items[0]);                    // First index
            Console.WriteLine(items[items.Length - 1]);     // last index

            // Negative indices are always out of range!
            // Indices larger than the array size are also out of range!
            //Console.WriteLine(items[-1]);                    // OOB
            //Console.WriteLine(items[15]);                    // OOB

            // ----------------------------------------------------------------
            // Iterate through the array
            // ----------------------------------------------------------------

            // For loops are a great way to iterate through an array
            // Can use the loop control variable (LCV) as the index iterator.
            for (int i = 0; i < items.Length; i++)
            {
                // Display the array index and its associated data
                Console.WriteLine(i + " " + items[i]);
            }
        }
    }
}
