
// Erin Cascioli
// 11/10/25
// Demo: Basic Inheritance with a single Parent and single Child class.

namespace Inheritance_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent myParentObj = new Parent();
            myParentObj.PrintParent();

            Console.WriteLine("-------------------------------");

            Parent mySecondParent = new Parent("Supergirl", 10.82);
            mySecondParent.PrintParent();

            Console.WriteLine("-------------------------------");

            Child myChildObj = new Child();
            myChildObj.PrintParent();

            Console.WriteLine("-------------------------------");

            Child mySecondChild = new Child("Apple", 1.00, "shirt");
            mySecondChild.PrintChild();
            
        }
    }
}
