
// StreamReader and StreamWriter code comes from this library/namespace
using System.IO;

namespace TextFileIO_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // File paths for reading and writing (relative!)
            string readFilepath = "../../../someFile.txt";
            string writeFilepath = "../../../someFile2.txt";

            // Declare streams for use throughout program
            StreamReader reader = null!;
            StreamWriter writer = null!;

            // Other variables for use in the try block and outside the try too.
            string[] dataFromFile = null!;
            int index = 0;


            // ----------------------------------------------------------------
            // FILE READING
            // ----------------------------------------------------------------
            try
            {
                // Initialize the StreamReader object at that filepath!
                reader = new StreamReader(readFilepath);
                string lineFromFile = "";

                // Read the first line of the file (if the file contains a number)
                int numberOfLines = int.Parse(reader.ReadLine()!);
                dataFromFile = new string[numberOfLines];

                // Read data from the file, line by line (as strings!)
                // Reads data, checks for null all in one step
                while( (lineFromFile = reader.ReadLine()!) != null )
                {
                    // This is a VALID text line from my text file!
                    // Add it to the array of file data at the appropriate index
                    dataFromFile[index] = lineFromFile;
                    index++;
                }

                // Always close the stream (connection to) the text file!
                reader.Close();
            }
            catch(FileNotFoundException error)
            {
                Console.WriteLine("Error occurred during file opening: " + error.Message);
            }
            catch(Exception error)
            {
                Console.WriteLine("Error occurred during file reading: " + error.Message);
            }


            // ----------------------------------------------------------------
            // INTERMEDIATE (BETWEEN READING AND WRITING)
            // ----------------------------------------------------------------
            // After reading the file, do whatever I want with the data!
            // In this case, print all data from the array onto the console window
            foreach (string line in dataFromFile)
            {
                Console.WriteLine(line);
            }


            // ----------------------------------------------------------------
            // FILE WRITING
            // ----------------------------------------------------------------
            try
            {
                // Open the stream for writing
                // If the filepath does not exist yet, the program will create it!
                writer = new StreamWriter(writeFilepath);

                // Write data to the file with WriteLine and Write methods
                writer.WriteLine(0);
                writer.WriteLine("Whatever the hell I want");
                writer.Write("This is");
                writer.Write("smooshed together");

                // Always close the stream
                writer.Close();
            }
            catch(Exception error)
            {
                 Console.WriteLine("Error occurred while writing! " + error.Message);
            }
        }
    }
}
