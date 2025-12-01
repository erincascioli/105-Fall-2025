
// Erin Cascioli
// 10/28/2022
// Demo: Library with multiple objects and arrays of objects


namespace LibraryDemo_MultipleObjectsArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Test the Book class
            // ----------------------------------------------------------------
            Book myBook = new Book();
            Book myOtherBook = new Book("Bartending for dummies", "Erin", 374);
            myBook.Print();
            myOtherBook.Print();

            // ** Try to read a book! **
            VisualDivider();
            // Call a static method in this Program class
            int userWantsToReadThisNumberOfPages = AskUserForPages();

            // Use the returned result in an object of the Book class.
            myOtherBook.ReadBook(userWantsToReadThisNumberOfPages);
            myOtherBook.Print();

            // ----------------------------------------------------------------
            // Test the Library class
            // ----------------------------------------------------------------
            Library bookshelf = new Library();

            // ** Determine how many books I purchased. **
            // (This method prints a C.WL internally)
            VisualDivider();
            bookshelf.NumberOfBooksIPurchased();

            // ** What are all the Books I own? **
            VisualDivider();
            Console.WriteLine("I own these books: ");
            bookshelf.PrintLibrary();

            // ** Search for a title **
            VisualDivider();
            bool bookExists = bookshelf.SearchForBook("Bartending for Dummies");
            Console.WriteLine("Does 'Bartending for Dummies' exist in my library? {0}", bookExists);

            bookExists = bookshelf.SearchForBook("Phone book");
            Console.WriteLine("Does 'Phone Book' exist in my library? {0}", bookExists);
        }

        // ----------------------------------------------------------------
        // STATIC METHODS HERE IN THE PROGRAM CLASS
        // Organizing Main
        // Retrieving user input
        // Condensing Main
        // ----------------------------------------------------------------

        /// <summary>
        /// Asks a user for the number of pages they desire to read.
        /// Validates data to ensure it is an integer.
        /// Forces re-entry of data if user-given value is not integral.
        /// </summary>
        /// <returns>Number of desired pages, or -1 if user declined reading.</returns>
        public static int AskUserForPages()
        {
            Console.Write("Do you want to read a book? YES or NO. ");
            string userResponse = Console.ReadLine().Trim().ToLower();

            // Get variable ready to return.
            int parsedInteger = -1;

            if (userResponse == "yes")
            {
                Console.Write("How many pages do you want to read?");
                parsedInteger = 0;
                bool parseWorked = int.TryParse(Console.ReadLine(), out parsedInteger);

                while (!parseWorked)
                {
                    Console.Write("Nope. Please enter an integer.");
                    parseWorked = int.TryParse(Console.ReadLine(), out parsedInteger);
                }
            }

            return parsedInteger;
        }
              
        /// <summary>
        /// Prints a dividing line to separate the console window's output.
        /// </summary>
        public static void VisualDivider()
        {
            Console.WriteLine("--------------------------------------------");
        }
    }
}