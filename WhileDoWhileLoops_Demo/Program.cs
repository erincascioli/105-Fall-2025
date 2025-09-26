
// Erin Cascioli
// 9/26/25
// Demo: While Loops and Do While Loops

namespace WhileDoWhileLoops_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Warmup
            // ------------------------------------------------------------------------------------
            // Even numbers 2 - 20 on same line using separate Write statements
            // ------------------------------------------------------------------------------------

            // TURN THIS INTO A WHILE LOOP 
            // Variables for controlling the loop and output
            int printedValue = 2;
            int difference = 2;
            int endingValue = 20;

            // As long as the value hasn't gone beyond 20...
            while (printedValue <= endingValue)
            {
                // Only print a dash for any values other than 20
                if (printedValue == 20)
                {
                    Console.Write(printedValue);
                }
                else
                {
                    Console.Write(printedValue + "-");
                }

                // Increase the printed value each iteration for a sequential
                //   "skip-count" or "multiples."
                printedValue += difference;
            }
            Console.WriteLine();

            // The loop replaced all of this!!!
            //Console.Write("2 ");
            //Console.Write("4 ");
            //Console.Write("6 ");
            //Console.Write("8 ");
            //Console.Write("10 ");
            //Console.Write("12 ");
            //Console.Write("14 ");
            //Console.Write("16 ");
            //Console.Write("18 ");
            //Console.Write("20");
            //Console.WriteLine();


            // ------------------------------------------------------------------------------------
            // Prompt player for value from 1 (inclusive) to 10 (inclusive)
            // ------------------------------------------------------------------------------------
            // Prompt player for value and gather input
            Console.Write("\nEnter a number between 1 and 10: ");
            int userNumber = int.Parse(Console.ReadLine()!);

            // Invalid number entered: Confirm invalidity, re-prompt and re-gather data
            while (userNumber < 1 || userNumber > 10)
            {
                Console.Write("\nInvalid range. Enter a number between 1 and 10: ");
                userNumber = int.Parse(Console.ReadLine()!);
            }

            Console.WriteLine("Success! Your number was " + userNumber);


            #endregion

            #region Clear & Explicit Exit Conditions
            // ------------------------------------------------------------------------------------
            // Prompt player for a season: non-preferred Boolean expression
            // ------------------------------------------------------------------------------------
            // Using a single Boolean value is NOT preferred and goes against coding standards
            //   for this course. 
            // ------------------------------------------------------------------------------------

            //User input is invalid: force re-entry of data
            string userInput = "";
            bool keepGoing = true;

            Console.WriteLine("Enter your favorite season.");
            Console.Write("Type 'spring' 'summer' 'fall' or 'winter': ");
            userInput = Console.ReadLine()!.Trim().ToLower();

            // Was their answer incorrect?
            keepGoing = userInput != "spring" &&
                            userInput != "summer" &&
                            userInput != "fall" &&
                            userInput != "winter";

            // As long as they inputted incorrect data...
            while (keepGoing)
            {
                // Confirm invalidity. Re-prompt and re-gather their response.
                Console.Write("Invalid response. Please enter a season: ");
                userInput = Console.ReadLine()!.Trim().ToLower();

                // Was their answer incorrect?
                keepGoing = userInput != "spring" &&
                            userInput != "summer" &&
                            userInput != "fall" &&
                            userInput != "winter";
            }

            Console.WriteLine("Thanks! Your favorite season is " + userInput);


            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
            // *** Preferred Structured Loop: ***
            // Programmer can tell from looking at the exit condition 
            //   exactly when the loop will stop.
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

            Console.WriteLine("Enter your favorite season.");
            Console.Write("Type 'spring' 'summer' 'fall' or 'winter': ");
            userInput = Console.ReadLine()!.Trim().ToLower();

            while (userInput != "spring" &&
                   userInput != "summer" &&
                   userInput != "fall" &&
                   userInput != "winter")
            {
                Console.Write("Invalid response. Please enter a season: ");
                userInput = Console.ReadLine()!.Trim().ToLower();
            }

            Console.WriteLine("Thanks! Your favorite season is " + userInput);





            #endregion

            #region Loop Examples for whiteboards

            // ------------------------------------------------------------------------------------
            // We studied these loops with whiteboards for determining their output.
            // The LCV (loop control variable) below is used throughout the examples.
            // ------------------------------------------------------------------------------------
            int counter = 0;    // Loop Control Variable

            // ------------------------------------------------------------------------------------
            // Loop #1 - What is its output?
            // ------------------------------------------------------------------------------------

            //counter = 1;

            //while (counter < 5)
            //{
            //Console.WriteLine(counter);
            //}

            // ------------------------------------------------------------------------------------
            // Loop #2 - What is its output?
            // ------------------------------------------------------------------------------------

            //counter = 20;

            //while (counter < 20)
            //{
            //    Console.WriteLine(counter);
            //}

            // ------------------------------------------------------------------------------------
            // Loop #3 - What is its output?
            // ------------------------------------------------------------------------------------

            //counter = 10;

            //while (counter >= 1)
            //{
            //    Console.WriteLine(counter);
            //    counter--;
            //}

            // ------------------------------------------------------------------------------------
            // Loop #4 - What is its output?
            // ------------------------------------------------------------------------------------

            //counter = 1;
            //while (counter <= 4)
            //{
            //    Console.WriteLine(counter * 3);
            //    counter++;
            //}

            // ------------------------------------------------------------------------------------
            // Loop #5 - What is its output?
            // ------------------------------------------------------------------------------------

            //counter = 2;
            //while (counter <= 20)
            //{
            //    Console.WriteLine(counter);
            //    counter += 2;
            //}

            // ------------------------------------------------------------------------------------
            // Loop #6 - What is its output?
            // ------------------------------------------------------------------------------------

            //counter = 1;
            //do
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //} while (counter <= 5);


            // ------------------------------------------------------------------------------------
            // Loop #7 - What is its output?
            // ------------------------------------------------------------------------------------

            //string greeting = "Hello";
            //int index = 0;
            //while (index < greeting.Length)
            //{
            //    Console.WriteLine(greeting[index]);
            //    index++;
            //}

            #endregion

            #region Player input loop example

            // ------------------------------------------------------------------------------------
            // Validate player data
            // ------------------------------------------------------------------------------------
                        
            // Start with a string value
            string difficulty = "";
            do
            {
                // Prompt player for chosen difficulty 
                Console.Write("Select a difficulty level: 'EASY' 'MEDIUM' or 'HARD') >> ");
                difficulty = Console.ReadLine()!.Trim().ToLower();

                // Player entered an invalid choice. Re-prompt for difficulty.
                if (difficulty != "easy" && difficulty != "medium" && difficulty != "hard")
                {
                    Console.WriteLine("Invalid choice. Try again.");
                }
            } 
            while (difficulty != "easy" && difficulty != "medium" && difficulty != "hard");

            // If we get here, the player entered an appropriate difficulty.
            Console.WriteLine($"You selected {difficulty} difficulty.");
            
            #endregion

            #region Loop Errors

            // ------------------------------------------------------------------------------------
            // Loop #1 - What is its output?
            // ------------------------------------------------------------------------------------
            //int count = 0;
            //while (count < 10)
            //{
            //    Console.WriteLine(count);
            //}


            // ------------------------------------------------------------------------------------
            // Loop #2 - What is its output?
            // ------------------------------------------------------------------------------------
            //int up = 0;
            //while (up >= 0)
            //{
            //    up++;
            //    Console.WriteLine(up);
            //}

            #endregion
        }
    }
}
