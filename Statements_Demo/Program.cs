// Erin Cascioli
// 9/5/25
// Demo of statements and expressions

namespace Statements_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write code to output:
            // 1) Your name
            // 2) Course abbreviation

            // Add a single-line comment above the first C.WL describing
            //   the work you completed.

            /*
            Console.WritLine("Hi there");              // comment
            Console.WriteLin("Hey");                   // comment
            Console.teLine("Hi hi hi");              // comment
            */

            // TODO:  Write any 20-word sentence(s) in a C.WL statement
            Console.WriteLine("This sentence has twenty words, " +
                "or it will when I am finished with it. " +
                "I need six more words. Elephant.");

            Console.WriteLine("This sentence has twenty words, or it will when I am finished with it. I need six more words. Elephant.");

            Console.WriteLine(
                "This sentence has twenty words, or it will when I am finished with it. \n" +
                "I need six more words. Elephant.");

            Console.WriteLine(5 * 5);           // 25
            Console.WriteLine( (5 * 5) / 2);    // 12
        }
    }
}
