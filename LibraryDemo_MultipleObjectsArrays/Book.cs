using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDemo_MultipleObjectsArrays
{
    /// <summary>
    /// Represents a book that can be found within a library.
    /// </summary>
    internal class Book
    {
        // Fields
        private string title;
        private string author;
        private int numberPages;
        private double pagesRead;
        private int readThrough;

        /// <summary>
        /// Constructs a brand-new book that has never been read.
        /// </summary>
        /// <param name="title">Title of the book</param>
        /// <param name="author">Author of the book</param>
        /// <param name="pages">Number of pages in the book</param>
        public Book(string title, string author, int pages)
        {
            // These come from the params
            this.title = title;
            this.author = author;
            this.numberPages = pages;

            // Default values for these 2 fields only
            pagesRead = 0;
            readThrough = 0;
        }


        /// <summary>
        /// Constructs a used book, or a book that has been previously read.
        /// </summary>
        /// <param name="title">Title of the book</param>
        /// <param name="author">Author of the book</param>
        /// <param name="pages">Number of pages in the book</param>
        /// <param name="pagesRead">
        ///   Number of pages the book's owner has read</param>
        /// <param name="readThrough">
        ///   How many times an owner has fully read the book</param>
        public Book(
            string title,
            string author,
            int pages,
            int pagesRead,
            int readThrough)
        {
            this.title = title;
            this.author = author;
            this.numberPages = pages;
            this.pagesRead = pagesRead;
            this.readThrough = readThrough;
        }


        /// <summary>
        /// Constructs a used book, or a book that has been previously read.
        /// Typically used for data that will be changed later.
        /// </summary>
        public Book()
        {
            title = "Book title";
            author = "Book author";
            numberPages = 0;
            pagesRead = 0;
            readThrough = 0;
        }


        // Methods

        /// <summary>
        /// Prints the data for this book.
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Book:");
            Console.WriteLine("  Book title: {0}", title);
            Console.WriteLine("  Book author: {0}", author);
            Console.WriteLine("  Pages: {0}", numberPages);
            Console.WriteLine("  I've read {0} pages", pagesRead);
            Console.WriteLine("  I've read this book {0} times.", readThrough);
        }

        /// <summary>
        /// Simulates the reading of a book by x number of pages.
        /// If a user exceeds the number of pages read, the readThrough field increases.
        /// </summary>
        /// <param name="pagesToRead">Number of pages someone is planning 
        /// on reading. Must be positive.</param>
        public void ReadBook(int pagesToRead)
        {
            if (pagesToRead > 0)
            {
                pagesRead += pagesToRead;
            }

            // Pages read exceeds the total number of pages, meaning
            //  the user has fully read through the book.
            if (pagesRead >= numberPages)
            {
                pagesRead = 0;
                readThrough++;
            }
        }
    }
}
