using System;
using System.Collections.Generic;

// ------------------------------------------------------------------------
// Erin Cascioli
// 12/1/25
// Demo: Simple Exceptions and Exception Handling Demo
// Exceptions are thrown by calling intentionally broken code
//   and handled with try/catch blocks.  
// ------------------------------------------------------------------------


namespace Sec3_ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------------------- Error Handling Basics --------------------------
            //
            // *** WHAT is an exception? ***
            // An exception means "I simply cannot go on!" (pause for dramatic effect)
            //   "and I must stop noooow"
            // Exceptions are objects, and the process of throwing one means that an
            //   object of an Exception class was initialized.  
            // Exceptions are COMMUNICATION between parts of your code. 
            //   One part of your code communicates with another part that a task
            //   cannot be accomplished.
            //
            // *** WHEN should I handle exceptions? ***
            // Use try/catch blocks only when necessary!
            // Anytime you can error-check with conditionals, TryParse, etc. DO SO!!!
            // Exceptions are SLOW to create/throw/catch.  Reserve catching exceptions
            //   for situations where you cannot predict/prevent an error by using 
            //   conditionals, checking for null, etc.  
            //
            // *** WHY should I handle exceptions? ***
            // Prevent a crash!
            // Run alternate code instead of crashing and allow the program to continue.
            //
            // ------------------------------------------------------------------------


            // --------------------- Exception Handling Speed -------------------------
            // Creating an exception, then catching it, then handling it is a slow process.  
            // Demo of how slow exceptions can be versus checking valid values
            //    with an if statement (a simple conditional is the best option)
            // ------------------------------------------------------------------------

            // *** PREVENTING EXCEPTIONS FROM OCCURRING ***
            // Super quick!  Almost instantaneous!
            int totalValidDivisions = 0;
            int totalThrownExceptions = 0;

            for (int i = 0; i < 10000; i++)
            {
                int divisor = 0;

                // Only divide if the divisor is not 0.
                // This is an example of PREVENTING a crash from occurring! 
                if (divisor != 0)
                {
                    int number = 5 / divisor;
                    totalValidDivisions++;
                }
            }

            // Print total to see the elapsed time error handling with a conditional 
            Console.WriteLine("How many divisions were ok? " + totalValidDivisions);

            // *** CATCHING THROWN EXCEPTIONS ***
            // SLOW! Takes a while to create 1,000 exceptions, throw them, and handle them!
            for (int i = 0; i < 10000; i++)
            {
                try
                {
                    // Always divide by 0, no matter what.
                    int divisor = 0;
                    int number = 5 / divisor;       // <-- EXCEPTION THROWN HERE!
                    totalValidDivisions++;
                }
                // CATCH THAT THROWN EXCEPTION!
                catch(Exception e)
                {
                    totalThrownExceptions++;

                    // FYI: DON'T print an error message!  
                    // This will clutter up the Console with 10,000 statements
                }
            }

            // Print out totals to see the elapsed time when creating exceptions 
            Console.WriteLine("How many divisions were ok? " + totalValidDivisions);
            Console.WriteLine("How many exceptions were thrown? " + totalThrownExceptions);


            // ------------------------- TRY/CATCH Blocks -----------------------------
            // Try/Catch blocks handle exceptions when they occur.
            // They allow alternate code to run rather than crashing a program.
            // Only one try allowed, but multiple catch blocks can be used for
            //   multiple Exception types.
            // ------------------------------------------------------------------------

            // Run code in here.  If no exceptions are thrown, the program will skip
            //   over all catch blocks.
            try
            {
                // Optimally, check that the index is valid before reverting to 
                //   placing this in a try/catch, but it's here to demonstrate
                //   how to catch exceptions. :)
                List<int> numbers = new List<int>{ 1, 2, 3 };
                int index = -3;
                Console.WriteLine(numbers[index]);      // <-- EXCEPTION THROWN HERE!

                // Since line 113 will throw an exception, lines 120 - 122 will actually never run. 
                // As stated previously, is far better to check that the divisor is not 0
                //   rather than placing it in a try/catch...
                //   BUT we're learning exception handling syntax and how it all works
                //   rather than being optimal at the moment...
                Console.WriteLine("HI");
                int zero = 0;
                int number = 5 / zero;
            }
            // Catch specific exceptions first!
            // The locally-scoped variable 'error' contains a reference to the Exception object
            //   that C# created when line 105 threw a new Exception.  
            // We have access to all of error's properties/methods!
            catch(IndexOutOfRangeException error)
            {
                // Message is one useful property that describes what the error is
                Console.WriteLine("Out of range " + error.Message);

                // Can use a stack trace to see the line of offending code
                Console.WriteLine("Stack trace " + error.StackTrace);

                // These messages are helpful for the DEVELOPER and not the user!
                // Error messages printed in a catch block are typically for debugging
                //   for a developer, not for a user to do anything differently. 
            }
            catch (ArgumentOutOfRangeException error)
            {
                // Message is one useful property that describes what the error is
                Console.WriteLine("Out of range " + error.Message);

                // Can also use a stack trace to see the line of offending code
                Console.WriteLine("Stack trace " + error.StackTrace);

                // These messages are helpful for the DEVELOPER and not the user
                // Error messages printed in a catch block are typically for debugging
                //   for a developer, and not for a user to do anything differently. 
            }
            catch (DivideByZeroException error)
            {
                // Again, this message is helpful for the DEVELOPER and not the user
                Console.WriteLine("Divide by zero " + error.Message);
            }
            // Catch generic exceptions last!
            catch (Exception error)
            {
                Console.WriteLine("General " + error.Message);
            }

            // Code after all of the try/catches will execute.  
            Console.WriteLine("This will print if the program did not crash");
        }    
    }
}
