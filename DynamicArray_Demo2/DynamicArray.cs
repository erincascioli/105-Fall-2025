
namespace DynamicArray_Demo2
{
    /// <summary>
    /// A resizeable data structure that holds double (primitive values).
    /// </summary>
    internal class DynamicArray
    {
        /// <summary>
        /// Array that holds all of this class's data
        /// </summary>
        private double[] data;

        public int Count
        {
            get { return data.Length; }
        }


        /// <summary>
        /// Constructs a resizeable data structure with an underlying array.
        /// </summary>
        /// <param name="arraySize"></param>
        public DynamicArray(int arraySize)
        {
            data = new double[arraySize];
        }


        /// <summary>
        /// Places initial data in the array
        /// Caveat: ONLY works when the array is instantiated with a size of 3, 
        ///         else will crash upon smaller arrays.
        /// </summary>
        public void InitializeWithData()
        {
            // Place the first 3 data into the array.
            data[0] = 0.0;
            data[1] = 1.2;
            data[2] = 2.4;
        }


        /// <summary>
        /// Prints all data in the array using a foreach loop.
        /// </summary>
        public void PrintData()
        {
            // Iterate through all data, printing to console.
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine($"Element {i}: {data[i]}");
            }

            foreach(double arrayValue in data)
            {
                Console.WriteLine(arrayValue);
            }
        }


        /// <summary>
        /// Adds one data to the dynamic array.
        /// Resizes and increases by 1 each time data is added.
        /// </summary>
        /// <param name="dataToAdd">Data to add to the END of the array</param>
        public void AddData(double dataToAdd)
        {
            // CODE THIS IN GROUPS
            // THE ARRAY'S IDENTIFIER IS 'DATA'
            double[] largerArray = new double[data.Length + 1];

            for(int i = 0; i < data.Length; i++)
            {
                largerArray[i] = data[i];
            }

            largerArray[data.Length] = dataToAdd;

            data = largerArray;
        }
    }
}
