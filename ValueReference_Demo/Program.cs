// Erin Cascioli
// 10/27/25
// Demo: Value and Reference types, Stack and Heap memory

namespace ValueReference_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // ----------------------------------------------------------------
            // VALUE TYPES
            // ----------------------------------------------------------------
            string nameA = "Gilbert";
            int healthA = 15;
            int levelA = 3;

            string nameB = "Greg";
            int healthB = healthA;      // COPY of Gilbert's health
            int levelB = 15;

            // Try to heal Gilbert for 30 points... which fails.
            // Integers are value types, so passing in healthA to the Heal
            //   method results in Heal receiving a COPY of healthA.
            // Modifying any value type in a method does NOT modify
            //   the value type varible that was passed in. 
            Heal(healthA);
            Heal(healthA);
            Heal(healthA);

            // Still 15... not 45. :(
            Console.WriteLine(healthA);

            // Need to change a value type using a method?
            // RETURN a new value and overwrite the value type variable!
            healthA = HealTheRightWay(healthA);
            healthA = HealTheRightWay(healthA);
            healthA = HealTheRightWay(healthA);

            // Gilbert has been healed! 
            Console.WriteLine(healthA);

            // ----------------------------------------------------------------
            // REFERENCE TYPES
            // ----------------------------------------------------------------
            // Arrays are always reference types!
            // Regardless of the data being held.
            // Array of integers? Reference type.
            // Array of doubles? Still a reference type.
            // Array of booleans?  Yep. Still a ref type.
            int[] numbers = new int[2];
            numbers[0] = 2846;
            numbers[1] = 5739;

            // When passed into any method (or any other scope), the array
            //   CAN be modified by that method.
            IncreaseArrayValues(numbers);

            // Since a REFERENCE to the numbers array - NOT A COPY - 
            //   is being sent to the IncreaseArrayValues method, its 
            //   "original" data is modified.
            // The numbers array now holds: 2946, 5839
            
            /*
            int a = 6;
            int b = 14;
            int c = a + b;
            int d = a;
            d = 200;

            int[] arrayA = { 6 };       // "new"

            int[] arrayB = new int[1];
            arrayB[0] = 14;

            int[] arrayC = new int[1];
            arrayC[0] = arrayA[0] + arrayB[0];

            int[] arrayD = arrayA;
            arrayD[0] = 200;
            */
        }

        /// <summary>
        /// Increases the values of each element in an integer array by 100.
        /// </summary>
        /// <param name="numberArray">REFERENCE to the array</param>
        public static void IncreaseArrayValues(int[] numberArray)
        {
            for(int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] += 100;
            }
        }

        /// <summary>
        /// Attempts to modify a player's health by 10 points... but fails.
        /// </summary>
        /// <param name="health">Player's current health</param>
        public static void Heal(int health)
        {
            health += 10;
        }

        /// <summary>
        /// Modified a player's health by 10 points
        /// </summary>
        /// <param name="health">Player's current health value</param>
        /// <returns>Increased hit point value</returns>
        public static int HealTheRightWay(int health)
        {
            return health + 10;
        }
    }
}
