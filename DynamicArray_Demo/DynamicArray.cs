using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray_Demo
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
        /// Caveats: ONLY works when the array is instantiated with a size of 3, else will crash.
        /// </summary>
        public void StartingData()
        {
            // Place the first 3 elements into the array.
            data[0] = 0.0;
            data[1] = 1.2;
            data[2] = 2.4;
        }


        /// <summary>
        /// Prints all data in the array using a foreach loop.
        /// </summary>
        public void PrintData()
        {
            // Foreach loops cannot change the data inside!
            // They are awesome for accessing all data, in order, in a data structure.
            foreach(double arrayElement in data)
            {
                Console.WriteLine(arrayElement);
            }
        }


        /// <summary>
        /// Adds one data to the dynamic array.
        /// Resizes and increases by 1 each time data is added.
        /// </summary>
        /// <param name="dataToAdd"></param>
        public void AddData(double dataToAdd)
        {
            // Create a new array one size larger than the data array
            double[] largerArray = new double[data.Length + 1];

            // Copy everything from the data array to the larger array
            for (int i = 0; i < data.Length; i++)
            {
                largerArray[i] = data[i];
            }

            // Add the newest data to the last element of the array
            largerArray[largerArray.Length - 1] = dataToAdd;

            // Set the reference, so that the data field refers to the 
            //   larger array.
            data = largerArray;
        }
    }
}
