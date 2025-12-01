using System.Diagnostics.CodeAnalysis;

namespace ValueReferenceTypes_Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string nameA = "Gilbert";
            int healthA = 15;
            int levelA = 3;

            string nameB = "Greg";
            int healthB = healthA;
            int levelB = 15;

            Console.WriteLine($"{nameA}: {healthA} health, level {levelA}");
            Console.WriteLine($"{nameB}: {healthB} health, level {levelB}");

            // Since integers are a value type, passing them into any method results in the
            //   method making a COPY of the argument data.  The Heal method would not
            //   modify the player's health without returning it. 
            //Heal(healthA);                                // WRONG!
            healthA = HealTheRightWay(healthA);             // YES!

            Console.WriteLine($"{nameA}: {healthA} health, level {levelA}");
            Console.WriteLine($"{nameB}: {healthB} health, level {levelB}");
            */

            /*
            int[] arrayA = new int[1];
            arrayA[0] = 25;

            IncreaseArrayValues(arrayA);

            int[] arrayB = new int[1];
            arrayB[0] = 14;

            int[] arrayC = new int[1];
            arrayC[0] = arrayA[0] + arrayB[0];

            int[] arrayD = arrayA;
            arrayD[0] = 12345;

            // Copy and Increase
            int[] arrayE = new int[arrayA.Length + 1];
            for(int i = 0; i < arrayA.Length; i++)
            {
                arrayE[i] = arrayA[i];
            }
            arrayE[arrayA.Length + 1] = 29475;

            arrayA = arrayE;
            arrayE = null;

            // Remove the last element
            arrayE = new int[arrayA.Length - 1];
            for(int i = 0; i < arrayA.Length - 1; i++)
            {
                arrayE[i] = arrayA[i];
            }

            arrayA = arrayE;

            arrayA = null!;
            arrayB = null!;
            arrayC = null!;
            arrayD = null!;
            arrayE = null!;
            */

            for(int i = 0; i < 1_000_000_000; i++)
            {
                int[] someArray = new int[3];
                someArray[0] = 1;
                someArray[1] = 1;
                someArray[2] = 1;
            }


        }

        /// <summary>
        /// Attempts to modify a player's health by 30 points... but fails because integers
        /// are a value type, and "health" is a COPY of the player's health.
        /// </summary>
        /// <param name="health">Player's current health</param>
        public static void Heal(int health)
        {
            // Only modifies the LOCALLY-SCOPED health variable.
            // Does NOT modify the argument variable.
            health += 30;
        }

        /// <summary>
        /// Heals a player character for 30 hit points
        /// </summary>
        /// <param name="health">Player's current health</param>
        /// <returns>Upgraded health by 30 hit points</returns>
        public static int HealTheRightWay(int health)
        {
            // PASS BACK a copy of the player's health plus 30 more HP.
            return health + 30;
        }


        /// <summary>
        /// Increases the values of each element in an integer array by 100.
        /// </summary>
        /// <param name="numberArray">REFERENCE to the array</param>
        public static void IncreaseArrayValues(int[] numberArray)
        {
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] += 100;
            }
        }
    }
}

