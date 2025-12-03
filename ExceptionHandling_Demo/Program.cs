namespace ExceptionHandling_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CodeThatIsFine();
            try
            {
                int returnedValue = CodeThatThrowsAnException(15);
            }
            catch(ArgumentOutOfRangeException errorObj)
            {
                Console.WriteLine("Exception message: " + errorObj.Message);
                Console.WriteLine();
                Console.WriteLine("Stack trace: " + errorObj.StackTrace);
            }
            catch(NullReferenceException errorObj)
            {
                // ESLKRAGSHGZKFdkfGZSHEkdwa:fgzbDX
            }
            catch (Exception errorObj)
            {
                // SEKfgznxk.h.nlkxrc
            }
        }

        public static void CodeThatIsFine()
        {
            Console.WriteLine("This code is perfectly fine!");
        }

        public static int CodeThatThrowsAnException(int index)
        {
            List<int> myThings = new List<int>();
            myThings.Add(1);
            myThings.Add(2);
            myThings.Add(3);

            if (index < myThings.Count && index >= 0)
            {
                return myThings[index];
            }
            else
            {
                ArgumentOutOfRangeException error = 
                    new ArgumentOutOfRangeException("List does not contain data up through your specified index.");
                throw error;
            }
        }

        public static void CodeThatThrowsSpecializedException()
        {
        }
    }
}
