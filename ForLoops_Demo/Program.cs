

using System.Collections.Concurrent;

namespace ForLoops_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 100; i += 2)
            //{
            //    Console.WriteLine(i);
            //}

            for (int i = 99; i >= 1; i--)
            {
                if(i == 50)
                {
                    continue;
                }

                Console.WriteLine(i);
            }

            for(int r = 1; r < 2; r++)          // r 1, 2, 3, 4
            {
                for(int c = 1; c < 30; c++)      // c 1, 2
                {
                    Console.Write("R");
                }

                Console.WriteLine();
            }
        }
    }
}
