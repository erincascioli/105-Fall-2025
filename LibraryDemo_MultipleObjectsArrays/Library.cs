using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDemo_MultipleObjectsArrays
{
    /// <summary>
    /// Library class contains an array of Book objects.
    /// </summary>
    internal class Library
    {
        // Fields
        // 1. Declare the array here
        private Book[] myBooks;


        // Constructor
        /// <summary>
        /// Instantiates a Library that contains 3 Books.
        /// </summary>
        public Library()
        {
            // 2. Initialize the array here
            // DON'T do this (it re-declares the array):
            //Book[] myBooks = new Book[3];

            // Do THIS:  (initializes the array field)
            myBooks = new Book[3];

            // Direct instantiation into the array
            myBooks[0] = new Book();
            myBooks[1] = new Book("How to be a pest", "Dash the cat", 1);

            // Instantiation via a variable
            Book bookVariable = new Book("Spells", "Winifred Sanderson", 1000, 15, 0);
            myBooks[2] = bookVariable;
        }

        /// <summary>
        /// Prints the number of books in the library.
        /// </summary>
        public void NumberOfBooksIPurchased()
        {
            Console.WriteLine("I own {0} books.", myBooks.Length);
        }

        /// <summary>
        /// Prints information about every Book in the library.
        /// </summary>
        public void PrintLibrary()
        {
            Console.WriteLine("These are the books in my library: ");

            // Iterate through every book on my shelf
            //   and print information about it
            for (int i = 0; i < myBooks.Length; i++)
            {
                myBooks[i].Print();
            }
        }

        /// <summary>
        /// Searches for a titled book in the library.
        /// </summary>
        /// <param name="titleFromParam">Title of the desired book.</param>
        /// <returns>True if the book is in the library, false otherwise.</returns>
        public bool SearchForBook(string titleFromParam)
        {
            // Need to iterate through all books in the array
            // Check if it's there
            // Do the titles match?
            // Return true or false

            // Start by assuming the book is NOT there.
            bool inLibrary = false;

            // Search through all books in the library
            for (int i = 0; i < myBooks.Length; i++)
            {
                // Wait...  I can't do this because title is private...
                // Check is the title matches this method's parameter
                /*
                if (titleFromParam == myBooks[i].title)
                {
                    inLibrary = true;
                }
                */
            }

            // Return the result.
            return inLibrary;
        }

    }
}
