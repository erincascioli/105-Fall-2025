using System;

namespace Conditionals_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PSEUDOCODE:
            // Prompt user if they like walnut shrimp  (C.WL or C.W)
            // Save their response                     (Variable with C.RL)
            // Yes:                                    (if - boolean expression, equality)
            //     print "So does Emmanuel!"           (output)
            //     Prompt user for their restaurant    (C.WL)
            //     Save their response                 (Variable with C.RL)
            //     OG Dumpling:
            //         print "My favorite too!"
            //     Anything else:
            //         print "Do not know"
            // No:                                     (else if)
            //     print "Have you tried it?"          (output)
            // Anything else:
            //     print "Do not recognize"             

            string userRestaurant = "";

            Console.WriteLine("Do you like walnut shrimp?");
            string userResponse = Console.ReadLine()!.Trim().ToLower();

            if (userResponse == "yes")
            {
                Console.WriteLine("So does Emmanuel!");

                // Another conditional inside
                Console.WriteLine("Where do you like to go? ");
                userRestaurant = Console.ReadLine()!.Trim().ToLower();

                if (userRestaurant == "og dumpling")
                {
                    Console.WriteLine("My favorite too!");
                }
                else
                {
                    Console.WriteLine("I don't know that place.");
                }
            }
            else if(userResponse == "no")
            {
                Console.WriteLine("Have you tried it?");
            }
            else
            {
                Console.WriteLine("I do not recognize that input.");
            }

            if (userRestaurant != "")
            {
                Console.WriteLine("The user really likes " + userRestaurant);
            }





            /*
            #region Enemy Health If-Else Statement
            // ----------------------------------------------------------------
            // If-Else statement 
            // Either the if or the else blocks will run. Not both!
            // ----------------------------------------------------------------
            // Things to look at:
            // Adding a variable for enemy health, where the output does
            //   something with its value.
            // ----------------------------------------------------------------

            Console.WriteLine("Do you want to ATTACK or RUN ?"); 
            string userInput = Console.ReadLine();

            if (userInput == "attack")
            {
                Console.WriteLine("You swing your axe at the enemy for 20 HP.");
            }
            else
            {
                Console.WriteLine("Terrified, you run away to save your life!");
            }

            Console.WriteLine("Thanks for playing!");
            #endregion
            */

            /*
            #region 3 or more statements with enemy health
            // ----------------------------------------------------------------
            // If-Elseif-Else statement
            // ----------------------------------------------------------------
            // Things to look at:
            // Adding more choices for the enemy health
            // ----------------------------------------------------------------

            #endregion
            */

            /*
            #region Debugging if statements
            int myGrade = 85;

            if (myGrade < 60)
            {
                Console.WriteLine("F");
            }
            if (myGrade > 60)
            {
                Console.WriteLine("D");
            }
            if (myGrade > 70)
            {
                Console.WriteLine("C");
            }
            if (myGrade > 80)
            {
                Console.WriteLine("B");
            }
            if (myGrade > 90)
            {
                Console.WriteLine("A");
            }

            Console.WriteLine("End of program!");

            #endregion
            */

            /*
            #region Nested if statements
            // ----------------------------------------------------------------
            // Make up with class as we go!
            // When the ___ and the ___, then do this.
            // But if the ___ and NOT the ___, then do this other thing.
            // ----------------------------------------------------------------

            #endregion
            */

            // Code completed in Section 3
            /*
            #region Do you like spaghetti - If statement
            // ----------------------------------------------------------------
            // If statement 
            // Only executes if Boolean expression evaluates to true.
            // ----------------------------------------------------------------
            // Things to look at:
            // ! for warning elimination
            // Upper and lowercase comparison
            // ToLower and Trim for sanitization
            // ----------------------------------------------------------------

            // Check if user likes pasta
            // Yes --> Ask another question
            //       Check if the like pasta sauce
            //       Yes -->  skgdjnhkjgnhkcfjvgb
            //       No -->  oiahgsi;d;htkjhdnkfjchnkcfj
            // No --> askjgnlkdjgnxkdjgngxkfjnb
            // Otherwise --> sdfifnslkzugbljfzdgbzlfdjgblkzjd


            string userPastaSauce = "";

            Console.Write("Do you like spaghetti? Enter 'yes' or 'no': ");
            string userAnswer = Console.ReadLine()!;
            userAnswer = userAnswer.Trim().ToLower();
            Console.Write("You said ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\"{userAnswer}\"");

            // If the user says they DO like spaghetti, agree!
            // Otherwise, ask if they like it
            if(userAnswer == "yes")
            {
                // Prompt user for their preference in pasta sauce
                Console.WriteLine("Do you like tomato sauce?");
                userPastaSauce = Console.ReadLine()!.Trim().ToLower();

                if(userPastaSauce == "yes")
                {
                    Console.WriteLine("I like tomato sauce too!");
                }
                else
                {
                    Console.WriteLine("Try it sometime.");
                }
            }
            else if(userAnswer == "no")
            {
                Console.WriteLine("You don't like it???");
            }
            else
            {
                Console.WriteLine("I do not recognize that input.");
            }

            Console.WriteLine("Do you like sauce? You said: " + userPastaSauce);

            Console.WriteLine("Thanks for playing!");
            #endregion
            */

            /*
            #region Enemy Health If-Else Statement
            // ----------------------------------------------------------------
            // If-Else statement 
            // Either the if or the else blocks will run. Not both!
            // ----------------------------------------------------------------
            // Things to look at:
            // Adding a variable for enemy health, where the output does
            //   something with its value.
            // ----------------------------------------------------------------

            Console.WriteLine("Do you want to ATTACK or RUN ?"); 
            string userInput = Console.ReadLine();

            if (userInput == "attack")
            {
                Console.WriteLine("You swing your axe at the enemy for 20 HP.");
            }
            else
            {
                Console.WriteLine("Terrified, you run away to save your life!");
            }

            Console.WriteLine("Thanks for playing!");
            #endregion
            */

            /*
            #region 3 or more statements with enemy health
            // ----------------------------------------------------------------
            // If-Elseif-Else statement
            // ----------------------------------------------------------------
            // Things to look at:
            // Adding more choices for the enemy health
            // ----------------------------------------------------------------

            #endregion
            */

            /*
            #region Debugging if statements
            int myGrade = 85;

            if (myGrade < 60)
            {
                Console.WriteLine("F");
            }
            if (myGrade > 60)
            {
                Console.WriteLine("D");
            }
            if (myGrade > 70)
            {
                Console.WriteLine("C");
            }
            if (myGrade > 80)
            {
                Console.WriteLine("B");
            }
            if (myGrade > 90)
            {
                Console.WriteLine("A");
            }

            Console.WriteLine("End of program!");

            #endregion
            */

            /*
            #region Nested if statements
            // ----------------------------------------------------------------
            // Make up with class as we go!
            // When the ___ and the ___, then do this.
            // But if the ___ and NOT the ___, then do this other thing.
            // ----------------------------------------------------------------

            #endregion
            */
        }
    }
}
