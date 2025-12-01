namespace ArrayMethods_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize a new array
            int[] numbers1 = { 5, 10, 15, 20 };
            string[] characters = { "Kirby", "Bayonetta", "Minecraft Steve", "Shovel Knight" };
            string[] soups = { "Vegetable", "Meat", "Soupy"};

            // Overloaded PrintArray methods allow for printing of any string or integer array!
            PrintArray(numbers1);
            PrintArray(characters, "characters");
            PrintArray(soups, "soups");

            IncreaseArrayValues(numbers1);
            PrintArray(numbers1);

            // Extension methods --> NO GO for this semester!



            /*
            // Literal arrays for printing and static method practice
            string[] characters = { "Virgil", "Bowser", "Sonic", "Gwimbly", "Price" };
            int[] numbers1 = { 10, 20, 30 };
            int[] numbers2 = { 100, 200, 300 };
            int[] numbers3 = { 1000, 2000, 3000 };
            string[] characters2 = CopyArray(characters);
            characters2[0] = "A";

            int index = FindFirstEven(numbers1);
            Console.WriteLine(index);

            // Call methods that I wrote
            PrintArray(characters);
            PrintArray(numbers1);
            PrintArray(numbers2);
            PrintArray(numbers3);

            Console.WriteLine("-----------------------------------------------");
            PrintArray(numbers1);
            IncreaseArrayValues(numbers1);
            PrintArray(numbers1);
            */
        }

        // ----------------------------------------------------------------------------------------
        //                                STATIC METHOD DEFINITIONS
        // ----------------------------------------------------------------------------------------

        // --------------------------------------------------------------------
        // Static methods that do NOT return data
        // --------------------------------------------------------------------

        /// <summary>
        /// Overload of the PrintArray method. Prints the contents of any string array.
        /// </summary>
        /// <param name="stringArray">Array of strings</param>
        /// <param name="description">Provided description of the data inside the array</param>
        public static void PrintArray(string[] stringArray, string description)
        {
            Console.WriteLine($"These are the contents of the {description} array");
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
        }

        /// <summary>
        /// Overload of the PrintArray method. Prints the contents of any integer array.
        /// </summary>
        /// <param name="intArray">Array of integers</param>
        public static void PrintArray(int[] intArray)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
        }

        public static void IncreaseArrayValues(int[] intArray)
        {
            // Algorithm:
            // Iterate through the existing array elements
            // Multiply each value by 2
            // Assign the increased value into the array

            for(int i = 0; i < intArray.Length; i++)
            {
                //int value = intArray[i];
                //value *= 2;
                //intArray[i] = value;

                intArray[i] *= 2;
            }
        }



        // --------------------------------------------------------------------
        // Static methods that DO return data
        // Some data are single values, other data are entire arrays
        // --------------------------------------------------------------------



        public static int[] CopyArray(int[] intArray)
        {
            int[] copy = new int[intArray.Length];

            for(int i = 0; i < intArray.Length; i++)
            {
                copy[i] = intArray[i];
            }

            return copy;
        }

        public static int FindFirstEven(int[] intArray)
        {
            int index = -1;

            for(int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] % 2 == 0)
                {
                    index = i;
                    break;s
                }
            }

            return index;

            // Find the first even number in the array, return its index
            // Algorithm:
            // ???
            // *** WRITE THE CODE FOR THIS METHOD ***
            // *** THINK: ARE THERE ANY QUESTIONS YOUR GROUP HAS AS THEY DEVELOP THIS? ***
        }



        /*
        // --------------------------------------------------------------------
        // Static methods that do NOT return data
        // --------------------------------------------------------------------

        /// <summary>
        /// Prints any array of integers.
        /// </summary>
        /// <param name="intArray">Array of integers</param>
        public static void PrintArray(int[] intArray)
        {
            // Iterates and prints each element on a new line.
            for (int i = 0; i < intArray.Length; i++) 
            {
                Console.WriteLine(intArray[i]);
            }

            // Alternately, if you're comfortable with foreach loops, you're more than welcome
            //   to use a foreach loop when printing!
            // NOTE: A foreach loop CANNOT be used when the contents inside the array are being modified!
            //foreach(int number in intArray)
            //{
                //Console.WriteLine(number);
            //}
        }

        /// <summary>
        /// Prints any array of strings
        /// </summary>
        /// <param name="stringArray">Array of strings</param>
        public static void PrintArray(string[] stringArray)
        {
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
        }

        public static void IncreaseArrayValues(int[] intArray)
        {
            // Algorithm:
            // Iterate through the existing array elements
            // Multiply each value by 2

            for(int i = 0; i < intArray.Length; i++)
            {
                intArray[i] *= 2;           // intArray[i] = intArray[i] * 2;
            }
        }


        // --------------------------------------------------------------------
        // Static methods that DO return data
        // Some data are single values, other data are entire arrays
        // --------------------------------------------------------------------

        
        public static string[] CopyArray(string[] stringArray)
        {
            // Algorithm:
            // Iterate through the existing array
            // Create a new array of the same size
            // Copy all data from the param array into the new array
            // Pass back the newly copied array when done
            // *** WRITE CODE TO COMPLETE THIS METHOD ***
            string[] newArray = new string[stringArray.Length];

            for(int i = 0; i < stringArray.Length; i++)
            {
                newArray[i] = stringArray[i];
            }

            return newArray;
        }

        
        public static int FindFirstEven(int[] intArray)
        {
            // Find the first even number in the array, return its index
            // Algorithm:
            // ???
            // ???
            // *** DEVELOP JUST THE ALGORITHM FOR THIS METHOD ***
            int index = -1;
            for(int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] % 2 == 0)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
        */
    }
}
