namespace PE_StaticMethods_Completed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Leave these variables here! Do not change them!
            // Setup variables necessary for testing all 6 methods
            // ----------------------------------------------------------------
            bool success = false;
            int biggest = 0;
            string word = "";


            // **************************************************************************
            // Method #1 Testing                                                        *
            // TODO: Uncomment these method calls while testing your first method       *
            // TODO: Remove these asterisked comments when finished!                    *
            // **************************************************************************

            DisplayHeadline("Print Hashtags");

            PrintHashtags(2);
            PrintHashtags(5);
            PrintHashtags(0);
            PrintHashtags(-4);



            // **************************************************************************
            // Method #2 Testing                                                        *
            // TODO: Uncomment these method calls while testing your first method       *
            // TODO: Remove these asterisked comments when finished!                    *
            // **************************************************************************

            DisplayHeadline("Display Player Health Bar", ConsoleColor.DarkGreen);

            DisplayPlayerHealthBar(2, 10);
            DisplayPlayerHealthBar(10, 10);
            DisplayPlayerHealthBar(75, 100);
            DisplayPlayerHealthBar(100, 75);



            // **************************************************************************
            // Method #3 Testing                                                        *
            // TODO: Uncomment these method calls while testing your first method       *
            // TODO: Remove these asterisked comments when finished!                    *
            // **************************************************************************

            DisplayHeadline("Makes Ten");

            success = MakesTen(9, 10);
            Console.WriteLine(
                "Do the values 9 and 10 add to 10? OR is one of the numbers 10? {0}",
                success);

            success = MakesTen(9, 9);
            Console.WriteLine(
                "Do the values 9 and 9 add to 10? OR is one of the numbers 10? {0}",
                success);

            success = MakesTen(1, 9);
            Console.WriteLine(
                "Do the values 1 and 9 add to 10? OR is one of the numbers 10? {0}",
                success);



            // **************************************************************************
            // Method #4 and #5 Testing                                                 *
            // TODO: Uncomment these method calls while testing your second method      *
            // TODO: Remove these asterisked comments when finished!                    *
            // **************************************************************************

            DisplayHeadline("Largest", ConsoleColor.DarkRed);

            biggest = Largest(1, 2, 3);
            Console.WriteLine(
                "The largest value of 1, 2, and 3 is: {0}",
                           biggest);

            biggest = Largest(1, 3, 2);
            Console.WriteLine(
                "The largest value of 1, 3, and 2 is: {0}",
                           biggest);

            biggest = Largest(3, 2, 1);
            Console.WriteLine(
                "The largest value of 3, 2, and 1 is: {0}",
                           biggest);

            biggest = Largest(2, 1, 2);
            Console.WriteLine(
                "The largest value of 2, 1, and 2 is: {0}",
                           biggest);

            biggest = Largest(3, 3, 1);
            Console.WriteLine(
                "The largest value of 3, 3, and 1 is: {0}",
                           biggest);

            biggest = Largest(5, 5, 5);
            Console.WriteLine(
                "The largest value of 5, 5, and 5 is: {0}",
                           biggest);

            biggest = Largest(1, 2);
            Console.WriteLine(
                "The larger value of 1 and 2 is: {0}",
                           biggest);

            biggest = Largest(3, 2);
            Console.WriteLine(
                "The larger value of 3 and 2 is: {0}",
                           biggest);

            biggest = Largest(2, 2);
            Console.WriteLine(
                "The larger value of 2 and 2 is: {0}",
                           biggest);



            // **************************************************************************
            // Method #5 Testing                                                        *
            // TODO: Uncomment these method calls while testing your third method       *
            // TODO: Remove these asterisked comments when finished!                    *
            // **************************************************************************

            DisplayHeadline("Not String");

            word = NotString("candy");
            Console.WriteLine("Your string 'candy' is now: {0}", word);

            word = NotString("x");
            Console.WriteLine("Your string 'x' is now: {0}", word);

            word = NotString("not bad");
            Console.WriteLine("Your string 'not bad' is now: {0}", word);

            word = NotString("nothing");
            Console.WriteLine("Your string 'nothing' is now: {0}", word);



            // **************************************************************************
            // Method #6 Testing                                                        *
            // TODO: Uncomment these method calls while testing your fourth method      *
            // TODO: Remove these asterisked comments when finished!                    *
            // **************************************************************************

            DisplayHeadline("Remove Index", ConsoleColor.Cyan);

            word = RemoveIndex("kitten", 1);
            Console.WriteLine("Your string 'kitten' removing 1 is now: {0}", word);

            word = RemoveIndex("kitten", 0);
            Console.WriteLine("Your string 'kitten' removing 0 is now: {0}", word);

            word = RemoveIndex("kitten", 5);
            Console.WriteLine("Your string 'kitten' removing 5 is now: {0}", word);

            word = RemoveIndex("kitten", 6);
            Console.WriteLine("Your string 'kitten' removing 6 is now: {0}", word);

            word = RemoveIndex("kitten", -1);
            Console.WriteLine("Your string 'kitten' removing -1 is now: {0}", word);

            word = RemoveIndex("a", 0);
            Console.WriteLine("Your string 'a' removing 0 is now: {0}", word);

            word = RemoveIndex("an", 0);
            Console.WriteLine("Your string 'an' removing 0 is now: {0}", word);



            // **************************************************************************
            // Method #7 Testing                                                        *
            // TODO: Uncomment these method calls while testing your sixth method       *
            // TODO: Remove these asterisked comments when finished!                    *
            // **************************************************************************

            DisplayHeadline("Distance");


            //double distance = Distance(0, 0, 0, 0);
            //Console.WriteLine("The distance between (0, 0) and (0, 0) is: " + distance);

            //distance = Distance(1, 0, 4, 4);
            //Console.WriteLine("The distance between (1, 0) and (4, 4) is: " + distance);

            //distance = Distance(10, 2, 3, 5);
            //Console.WriteLine("The distance between (10, 2) and (3, 5) is: " + distance);


        }   // End of Main. All static methods in this Program class must be written AFTER this!


        // --------------------------------------------------------------------------------------------------
        // ---------------------------------    SAMPLE STATIC METHOD    -------------------------------------
        // --------------------------------------------------------------------------------------------------

        // Public static methods should be written between the end of the Main method's curly brace
        //    and the end of Program class curly brace. 

        // **************************************************************************
        // Write method #0, DisplayHeadline and overload                            *
        //                                                                          *
        // Method #0: DisplayHeadline                                               *
        // Given a string, display a nicely formatted headline in the console       *
        // window.                                                                  *
        //                                                                          *
        // Method Identifier:   DisplayHeadline                                     *
        // Parameters:          Receives 1 string                                   *
        // Return:              Nothing                                             *
        //                                                                          *
        // Sample method calls and their output:                                    *
        //                                                                          *
        //   DisplayHeadline("MakesTen"); →                                         *
        //   ----------------------------------                                     *
        //   -------- Makes Ten method --------                                     *
        //   ----------------------------------                                     *
        //                                                                          *
        // **************************************************************************

        /// <summary>
        /// Prints a formatted headline in the console window.
        /// </summary>
        /// <param name="textToDisplay">The text that should be displayed. Must not exceed 55 characters.</param>
        public static void DisplayHeadline(string textToDisplay)
        {
            // Determine the length of the string
            // Then create a string with all dashes of the appropriate length.
            string allDashes = "-------------------------";
            for (int i = 0; i < textToDisplay.Length; i++)
            {
                allDashes += "-";
            }

            // Print the resulting output
            Console.WriteLine();
            Console.WriteLine(allDashes);
            Console.WriteLine($"-------- {textToDisplay} method --------");
            Console.WriteLine(allDashes);
        }

        /// <summary>
        /// Prints a formatted headline in the console window in specified color.
        /// </summary>
        /// <param name="textToDisplay">The text that should be displayed. Must not exceed 55 characters.</param>
        /// <param name="color">Console color</param>
        public static void DisplayHeadline(string textToDisplay, ConsoleColor color)
        {
            // Determine the length of the string
            // Then create a string with all dashes of the appropriate length.
            string allDashes = "-------------------------";
            for (int i = 0; i < textToDisplay.Length; i++)
            {
                allDashes += "-";
            }

            // Print the resulting output in specified color
            Console.ForegroundColor = color;
            Console.WriteLine();
            Console.WriteLine(allDashes);
            Console.WriteLine($"-------- {textToDisplay} method --------");
            Console.WriteLine(allDashes);

            // Return the console back to gray
            Console.ForegroundColor = ConsoleColor.Gray;
        }




        // --------------------------------------------------------------------------------------------------
        // -----------------------------    METHODS FOR STUDENTS TO WRITE    --------------------------------
        // --------------------------------------------------------------------------------------------------

        // Public static methods should be written between the Main method
        //    and the end of Program class's curly brace. 

        // **************************************************************************
        // TODO: Write method #1, PrintHashtags                                     *
        //                                                                          *
        // Method #1: PrintHashtags                                                 *
        // Given a single integer, print that many hashtags to the console window   *
        // on a single line.                                                        *
        // When a 0 or negative value is given, print one hashtag.                  *
        //                                                                          *
        // Method Identifier:   PrintHashtags                                       *
        // Parameters:          Receive 1 integer                                   *
        // Return:              Nothing                                             *
        //                                                                          *
        // Sample method calls and what they print:                                 *
        //   PrintHashtags(2) → ##                                                  *
        //   PrintHashtags(5) → #####                                               *
        //   PrintHashtags(0) → #                                                   *
        //   PrintHashtags(-4) → #                                                  *
        // **************************************************************************

        // **********************************************
        // I've started you with:                       *
        // the method declaration AND                   *
        // XML comments...                              *
        //                                              *
        // Your job is to write the method body!        *
        // **********************************************

        /// <summary>
        /// Prints a series of hashtags on a single line.
        /// </summary>
        /// <param name="numberTags">Number of hashtags to print.</param>
        public static void PrintHashtags(int numberTags)
        {
            // Always print at least 1 hash tag
            if(numberTags <= 0)
            {
                Console.Write("#");
            }

            // More than 1? Won't run if the parameter has the value are 0 or less.
            for (int i = 0; i < numberTags; i++)
            {
                Console.Write("#");
            }

            // Line break to get ready for the next method!
            Console.WriteLine();
        }



        // **************************************************************************
        // TODO: Write method #2, DisplayPlayerHealthBar                            *
        //                                                                          *
        // Method #2: DisplayPlayerHealthBar                                        *
        // Given a player's health and their max health, display their health as if *
        // it were in a health bar.                                                 *
        // When the first value is larger than the second, display the error        *
        // message "<Incorrect argument order.>                                     *
        //                                                                          *
        // Method Identifier:   DisplayPlayerHealthBar                              *
        // Parameters:          Receive 2 integers                                  *
        // Return:              Nothing                                             *
        //                                                                          *
        // Sample method calls and what they print:                                 *
        //   DisplayPlayerHealthBar(2, 10)   → Player Health: 2/10                  *
        //   DisplayPlayerHealthBar(10, 10)  → Player Health: 10/10                 *
        //   DisplayPlayerHealthBar(75, 100) → Player Health: 75/100                *
        //   DisplayPlayerHealthBar(100, 75) → <Incorrect argument order.>          *
        // **************************************************************************

        /// <summary>
        /// Given a player's health and their max health, display their health in a health bar.
        /// </summary>
        /// <param name="currentHealth">Current level of player's health</param>
        /// <param name="maxHealth">Maximum health value</param>
        public static void DisplayPlayerHealthBar(int currentHealth, int maxHealth)
        {
            // Current larger than max? Some error occurred.
            // Print error message then exit the method.
            if(currentHealth > maxHealth)
            {
                Console.WriteLine("<Incorrect argument order.>");
                return;
            }

            // Arguments are in correct order. Print as normal.
            Console.WriteLine($"Player Health: {currentHealth}/{maxHealth}");
        }



        // **************************************************************************
        // TODO: Write method #3, MakesTen                                          *
        //                                                                          *
        // Method #3: MakesTen                                                      *
        // Given 2 ints, return true if one if them is 10 or if their sum is 10.    *
        //                                                                          *
        // Method Identifier:   MakesTen                                            *
        // Parameters:          Receive 2 integers                                  *
        // Return:              A boolean                                           *
        //                                                                          *
        // Sample method calls and what they should return:                         *
        //   MakesTen(9, 10) → true                                                 *
        //   MakesTen(9, 9)  → false                                                *
        //   MakesTen(1, 9)  → true                                                 *
        // **************************************************************************

        /// <summary>
        /// Given 2 integers, determine whether one of them is 10 or if their sum is 10.
        /// </summary>
        /// <param name="number1">First value</param>
        /// <param name="number2">Second value</param>
        /// <returns>True when one value is 10 or if the sum of values is 10. False otherwise.</returns>
        public static bool MakesTen(int number1, int number2)
        {
            bool meetsConditions = (number1 + number2 == 10) ||     // Sum is 10
                                    number1 == 10 ||                // Either value is 10
                                    number2 == 10;

            return meetsConditions;
        }



        // **************************************************************************
        // TODO: Write method #4, Largest                                           *
        //                                                                          *
        // Method #4: Largest                                                       *
        // Given three integer values, return the largest of the 3.                 *
        // If there is a "tie" for largest between 2 or 3 values, return either one.*
        //                                                                          *
        // Method Identifier:   Largest                                             *
        // Parameters:          Receive 3 integers                                  *
        // Return:              An integer representing the largest of the 3 values *
        //                                                                          *
        // Sample method calls and what they should return:                         *
        //   Largest(1, 2, 3) → 3                                                   *
        //   Largest(1, 3, 2) → 3                                                   *
        //   Largest(3, 2, 1) → 3                                                   *
        //   Largest(2, 1, 2) → 2                                                   *
        //   Largest(3, 3, 1) → 3                                                   *
        //   Largest(5, 5, 5) → 5                                                   *
        // **************************************************************************

        /// <summary>
        /// Returns the largest of three integers.
        /// </summary>
        /// <param name="number1">First value</param>
        /// <param name="number2">Second value</param>
        /// <param name="number3">Third value</param>
        /// <returns>Largest of the three integers.</returns>
        public static int Largest(int number1, int number2, int number3)
        {
            // Find the largest of the three values, then return the largest one.
            int largestValue = Math.Max(number1, number2);
            largestValue = Math.Max(largestValue, number3);
            return largestValue;
        }


        // **************************************************************************
        // TODO: Write method #5, Largest                                           *
        //                                                                          *
        // Method #5: Largest (Overload!)                                           *
        // Given two integer values, return the largest of the 2.                   *
        // If there is a "tie" for largest between 2 values, return either one.     *
        //                                                                          *
        // Method Identifier:   Largest                                             *
        // Parameters:          Receive 2 integers                                  *
        // Return:              An integer representing the largest of the 2 values *
        //                                                                          *
        // Sample method calls and what they should return:                         *
        //   Largest(1, 2) → 2                                                      *
        //   Largest(3, 2) → 3                                                      *
        //   Largest(2, 2) → 2                                                      *
        // **************************************************************************

        /// <summary>
        /// Returns the larger of two integers.
        /// </summary>
        /// <param name="number1">First value</param>
        /// <param name="number2">Second value</param>
        /// <returns>Larger of the two integers.</returns>
        public static int Largest(int number1, int number2)
        {
            // Find the larger of the two values, then return the larger one.
            int largestValue = Math.Max(number1, number2);
            return largestValue;
        }



        // **************************************************************************
        // TODO: Write method #6, NotString                                         *
        //                                                                          *
        // Method #6: NotString                                                     *
        // Given a string, return a new string where "not " is added to the front.  *
        // However, if the string already begins with "not", return the string      *
        //   unchanged.                                                             *
        //                                                                          *
        // Method Identifier:   NotString                                           *
        // Parameters:          Receive a string                                    *
        // Return:              String with "not " appended to the front            *
        //                                                                          *
        // Sample method calls and what they should return:                         *
        //   NotString("candy")   → "not candy"                                     *
        //   NotString("x")       → "not x"                                         *
        //   NotString("not bad") → "not bad"                                       *
        //   NotString("nothing") → "nothing"                                       *
        // **************************************************************************

        /// <summary>
        /// Given a string, return a new string where "not " is added to the front.
        /// However, if the string already begins with "not", return the string unchanged.    
        /// </summary>
        /// <param name="entryString">Original string</param>
        /// <returns>String with "not " appended to the front</returns>
        public static string NotString(string entryString)
        {
            string notString = entryString;

            // Is the string short enough that it couldn't possibly contain "not"?
            // Is "not" missing from the front of the string?
            // Add it!
            if( entryString.Length < 3 ||                   // Too short string
                entryString.Substring(0, 3) != "not")       // Longer, but no "not"
            {
                notString = "not " + entryString;           // Append "not" to beginning
            }

            return notString;
        }
        



        // **************************************************************************
        // TODO: Write method #7, RemoveIndex                                       *
        //                                                                          *
        // Method #7: RemoveIndex                                                   *
        // Given a non-empty string and an int n, return a new string where the     *
        //   character at index n has been removed.                                 *
        // If the resulting string is empty or has a size of 0, return the string   *
        //   "<empty string>"                                                       *
        // The value of n must be a valid index of a char in the original string    *
        //   (i.e. n must be within the range 0 through Length-1 inclusive).        *
        // If the index is invalid, return the string "<Index is out of range>"     *
        //                                                                          *
        // Method Identifier:   RemoveIndex                                         *
        // Parameters:          Receive a string and an integer                     *
        // Return:              A string where a single character has been removed  *
        //                      or "<empty string>" or "<Index is out of range>"    *
        //                                                                          *
        // Sample method calls and what they should return:                         *
        //   RemoveIndex("kitten", 1)  → "ktten"                                    *
        //   RemoveIndex("kitten", 0)  → "itten"                                    *
        //   RemoveIndex("kitten", 5)  → "kitte"                                    *
        //   RemoveIndex("kitten", 6)  → "<Index is out of range>"                  *
        //   RemoveIndex("kitten", -1) → "<Index is out of range>"                  *
        //   RemoveIndex("a", 0)       → "<empty string>"                           *
        //   RemoveIndex("an", 0)      → "n"                                        *
        // **************************************************************************

        public static string RemoveIndex(string incomingString, int index)
        {
            // Invalid index? Return an error message string.
            if(index < 0 || index >= incomingString.Length)
            {
                return "<Index is out of range>";
            }

            // No length after removal? Return an error message string.
            if(incomingString.Length == 1)
            {
                return "<empty string>";
            }

            // Return the string with just that index removed.
            return incomingString.Remove(index, 1);
        }



        // **************************************************************************
        // TODO: Write method #8, Distance                                          *
        //                                                                          *
        // Method #8: Distance                                                      *
        // Accepts 4 values (floating-point numbers are ok)                         *
        // Calculates the distance between (x1, y1) and (x2, y2)                    *
        //                                                                          *
        // Method Identifier:   Distance                                            *
        // Parameters:          Receive 4 integers                                  *
        // Return:              Double of the calculated distance between the 2     *
        //                      points in space.                                    *
        //                                                                          *
        // Sample method calls and what they should return:                         *
        //   Distance(0, 0, 0, 0)  → 0  (really 0.0 but displays 0)                 *
        //   Distance(1, 0, 4, 4)  → 5  (really 5.0 but displays 5)                 *
        //   Distance(10, 2, 3, 5) → 7.615773105863909                              *
        // **************************************************************************

        // **********************************************
        // It's YOUR job to figure out                  *
        // the method declaration AND                   *
        // the method definition AND                    *
        // XML comments for this one!                   *
        // **********************************************


        /*  W R I T E    T H E    M E T H O D    H E R E  */
        /*  I N C L U D E   X M L   C O M M E N T S       */
    }
}
