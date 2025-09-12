// Erin Cascioli
// 9/10/25
// Demo: Typecasting, Math class

namespace Demo_CastingMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable declaration block.
            double doubleValue1 = 392.4;
            double doubleValue2;
            int intValue1 = 10;
            char x = 'r';


            // Casting lower precise data to more precise data
            // Implicit cast
            doubleValue1 = 2;
            doubleValue2 = 2f;


            // ^^ Use values somehow to remove the warnings
            Console.WriteLine(doubleValue1);
            Console.WriteLine(doubleValue2);

            // Casting more precise to less precise
            // Explicit cast
            intValue1 = (int)3.2474;
            x = (char)(68 * 2);
            Console.WriteLine(x);


            // Math methods and properties
            // Abs, Round, Sqrt
            // Watch: Argument types and return types!
            // Casting may be needed

            int roundedValue1 = (int)(Math.Round(6.284652));
            Math.Round(82.5814562, 1);

            int roundedValue2 = (int)Math.Round(doubleValue1, intValue1);

            //short absoluteValue = Math.Abs(-36);

            float floatValue2 = 385.6f;

            // 1)
            int absValue = Math.Abs(-19);
            Console.WriteLine(absValue);

            // 2)
            Console.WriteLine(Math.Abs(-19));


            /*
            // Casting lower precise data to more precise data
            // Implicit cast
            double valueAsDouble1 = 56;
            double valueAsDouble2 = 56f;

            // ^^ Use values somehow to remove the warnings
            Console.WriteLine(valueAsDouble1);
            Console.WriteLine(valueAsDouble2);


            // Casting more precise to less precise
            // Explicit cast
            
            int valueAsInt = (int)56.3762;
            float valueAsFloat1 = (float)56.3762;
            float valueAsFloat2 = 56.3762f;

            Console.WriteLine("----------------------");
            Console.WriteLine( (int)'a');
            Console.WriteLine((char)124);
            Console.WriteLine("----------------------");


            // Math methods and properties
            // Abs, Round, Sqrt
            // Watch: Argument types and return types!
            // Casting may be needed

            // 1)
            int absValue = Math.Abs(-19);
            Console.WriteLine(absValue);

            // 2)
            Console.WriteLine(Math.Abs(-19));

            int roundedNumber = (int)(Math.Round(2.56));
            */
        }
    }
}
