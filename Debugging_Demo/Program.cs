namespace Debugging_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstInt = 5;
            int secondInt = 2000;
            int changingValue = 0;
            string firstString = "banana";
            string secondString = "apple";

            // ----------------------------------------------------------------
            // Syntax Errors
            // ----------------------------------------------------------------
           
            
            // What is the problem(s) here?
            if (firstInt > 4) 
                Console.WriteLine("firstInt is greater than 4");

            // What is the problem here?
            if (secondInt > firstInt)
            {
                Console.WriteLine(
                    $"The second value {secondInt} is larger than the first value {firstInt}");
            }

            // What is the problem(s) here?
            if (firstInt == 5)
            {
                Console.WriteLine("firstValue is 5");
            }
            else if (firstInt == 10)
            {
                Console.WriteLine("firstValue is 10");
                Console.WriteLine("I like 10!");
            }
            



            // ----------------------------------------------------------------
            // Logic Errors (usually no crash)
            // ----------------------------------------------------------------

            // What is the problem(s) here?
            changingValue = 15;
            if (changingValue < 10)
                Console.WriteLine("The number is less than 10");
            else
                Console.WriteLine("The number is greater than 10");


            // What is the problem(s) here?
            changingValue = 5;
            if (changingValue != 5)  
                Console.WriteLine("The number is 5");
            else
                Console.WriteLine("The number is not 5");


            // What is the problem(s) here?
            changingValue = 10;
            if (changingValue == 10)
            {
                Console.WriteLine("changingValue is 10");
            }
            else if (changingValue >= 5 && changingValue <= 10)
            { 
                Console.WriteLine("changingValue is between 5 and 10");
            }
            else
            {
                Console.WriteLine("changingValue is less than 5");
            }


            // ----------------------------------------------------------------
            // Runtime Errors
            // ----------------------------------------------------------------

            // What is the problem(s) here?
            string s = null!;
            if (s.Length > 0)
            {
                Console.WriteLine("String has characters");
            }
            else
            {
                Console.WriteLine("String is empty or null");
            }


            // What is the problem(s) here?
            int x = 0;
            if (x == 0)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            else
            {
                Console.WriteLine(10 / x);
            }


            // What is the problem(s) here?
            int[] arr = { 1, 2, 3 };
            int index = 5;
            if (index >= 0 && index < arr.Length)
            {
                Console.WriteLine(arr[index]);
            }
            else
            {
                Console.WriteLine("Index out of range");
            }
        }
    }
}
