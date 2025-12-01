
// Erin Cascioli
// 11/19/25
// Demo: List class

namespace DynamicArray_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Using a List of strings
       
            // Instantiate a new List of strings
            List<string> foodList = new List<string>();

            //Add the first few foods to the list
            foodList.Add("spaghetti");
            foodList.Add("meatballs");
            foodList.Add("sushi");
            foodList.Add("Doritos");

            Console.WriteLine($"My list has {foodList.Count} foods.");
            Console.WriteLine($"My list can hold {foodList.Capacity} foods.");
            Console.WriteLine();
            
            foodList.Add("fries");
            foodList.Add("coffee cake");
            foodList.Add("soda");

            Console.WriteLine($"My list has {foodList.Count} foods.");
            Console.WriteLine($"My list can hold {foodList.Capacity} foods.");
            Console.WriteLine();

            foodList.Add("flour");

            Console.WriteLine($"My list has {foodList.Count} foods.");
            Console.WriteLine($"My list can hold {foodList.Capacity} foods.");
            Console.WriteLine();

            foodList.Add("cookies");
            Console.WriteLine($"My list has {foodList.Count} foods.");
            Console.WriteLine($"My list can hold {foodList.Capacity} foods.");
            Console.WriteLine();

            // Change the data at a specific index
            foodList[3] = "peanut butter cups";

            // Print all data in the foods list
            Console.WriteLine("\nMy list contains: ");
            foreach(string food in foodList)
            {
                Console.WriteLine(food);
            }

            #endregion

            #region Using the DynamicArray class

            DynamicArray myResizableArray = new DynamicArray(3);
            myResizableArray.StartingData();
            myResizableArray.PrintData();
            myResizableArray.AddData(3.6);

            Console.WriteLine();
            myResizableArray.PrintData();

            myResizableArray.AddData(4.8);
            myResizableArray.AddData(6.0);

            Console.WriteLine();
            myResizableArray.PrintData();

            #endregion
        }
    }
}
