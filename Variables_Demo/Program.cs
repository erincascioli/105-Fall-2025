// Erin Cascioli
// 9/8/25
// Demo: Variables and Data Types


namespace Variables_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Declaring a variable (including constants!)
            // ----------------------------------------------------------------
            string zachFavoriteFood;
            string emmettFavoriteFood;
            string austinFavoriteFood;
            

            int someNumber;


            // ----------------------------------------------------------------
            // Initializing a variable
            // ----------------------------------------------------------------
            zachFavoriteFood = "rigatoni";
            emmettFavoriteFood = "Cheese fondue";
            austinFavoriteFood = "Mac and cheese";

            someNumber = 284;


            // ----------------------------------------------------------------
            // Declare and init (same line!)
            // ----------------------------------------------------------------
            int cheeseLovers = 9;
            const string sebastianFavoriteFood = "Lobster without butter";


            // ----------------------------------------------------------------
            // Use the variables in statements
            // ----------------------------------------------------------------
            Console.WriteLine("Zach's favorite food is " + zachFavoriteFood);
            Console.WriteLine("Zach's favorite food is " + zachFavoriteFood);
            Console.WriteLine("Zach's favorite food is " + zachFavoriteFood);
            Console.WriteLine("Zach's favorite food is " + zachFavoriteFood);

            // ----------------------------------------------------------------
            // Change and modify variable values
            // ----------------------------------------------------------------
            cheeseLovers = cheeseLovers - 1;
            cheeseLovers -= 1;


            someNumber = someNumber / 3;
            someNumber /= 3;


            // ----------------------------------------------------------------
            // Increment and Decrement operators
            // ----------------------------------------------------------------
            cheeseLovers++;

            cheeseLovers--;

        }
    }
}
