namespace DynamicArray_Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Using the List class

            // ----------------------------------------------------
            // Instantiate a new list of strings
            List<string> foodList = new List<string>();

            // Check the count and capacity of the list
            Console.WriteLine($"Count: {foodList.Count}");
            Console.WriteLine($"Capacity: {foodList.Capacity}");

            // ----------------------------------------------------
            // Add data to the list
            foodList.Add("donut");

            // Check the count and capacity of the list again
            Console.WriteLine($"\nCount: {foodList.Count}");
            Console.WriteLine($"Capacity: {foodList.Capacity}");

            // Add data to the list
            foodList.Add("hamburger");

            // Check the count and capacity of the list again
            Console.WriteLine($"\nCount: {foodList.Count}");
            Console.WriteLine($"Capacity: {foodList.Capacity}");

            // Add data to the list
            foodList.Add("hot dog");

            // Check the count and capacity of the list again
            Console.WriteLine($"\nCount: {foodList.Count}");
            Console.WriteLine($"Capacity: {foodList.Capacity}");

            // Add data to the list
            foodList.Add("walnut");

            // Check the count and capacity of the list again
            Console.WriteLine($"\nCount: {foodList.Count}");
            Console.WriteLine($"Capacity: {foodList.Capacity}");

            // Add data to the list
            foodList.Add("mac and cheese");

            // Check the count and capacity of the list again
            Console.WriteLine($"\nCount: {foodList.Count}");
            Console.WriteLine($"Capacity: {foodList.Capacity}");

            foodList.Add("ribs");
            foodList.Add("shrimp");
            foodList.Add("soup");

            // Check the count and capacity of the list again
            Console.WriteLine($"\nCount: {foodList.Count}");
            Console.WriteLine($"Capacity: {foodList.Capacity}");

            foodList.Add("ice cream");

            // Check the count and capacity of the list again
            Console.WriteLine($"\nCount: {foodList.Count}");
            Console.WriteLine($"Capacity: {foodList.Capacity}");


            // ----------------------------------------------------
            // Access data in the list with []
            string firstItem = foodList[0];

            // Change data with []
            foodList[0] = "soda";

            #endregion

            #region Using the DynamicArray class
            /*
            DynamicArray myResizableArray = new DynamicArray(3);
            myResizableArray.InitializeWithData();
            myResizableArray.PrintData();
            Console.WriteLine();

            // Add data to the array
            myResizableArray.AddData(3.6);
            myResizableArray.PrintData();
            Console.WriteLine();

            // Add data to the array
            myResizableArray.AddData(4.8);
            myResizableArray.PrintData();
            Console.WriteLine();

            // Add data to the array
            myResizableArray.AddData(6.0);
            myResizableArray.PrintData();
            Console.WriteLine();

            Console.WriteLine(myResizableArray.Count);
            */
            #endregion
        }
    }
}
