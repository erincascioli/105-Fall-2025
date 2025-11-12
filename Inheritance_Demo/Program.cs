
// Erin Cascioli
// 11/12/25
// Demo: Basic Inheritance with a single Parent and single Child class.
//       Now includes overridden methods and polymorphic behaviors.

namespace Inheritance_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------------------------------
            // POLYMORPHISM
            // ------------------------------------------------------------------------------------
            // A child object counts as itself and its parent type.
            // ------------------------------------------------------------------------------------

            Parent myParentObj = new Parent();      // Declared: Parent.  Runtime: Parent.
            Child myChildObj = new Child();         // Declared: Child.  Runtime: Child.
            Parent myHybridObj = new Child();       // Declared: Parent.  Runtime: Child.
                                                    //Child myOtherHybridObj = new Parent();    // ERROR!

            // ------------------------------------------------------------------------------------
            // Polymorphism allows a data structure to contain objects of a child class
            //   in an array of declared parent type.
            // ------------------------------------------------------------------------------------

            Parent[] myObjects = new Parent[3];
            myObjects[0] = new Parent();
            myObjects[1] = new Child();
            myObjects[2] = new Child();

            // ------------------------------------------------------------------------------------
            // Always check whether a child class is a certain type before attempt to downcast.
            // Check using the "is" keyword.
            // ------------------------------------------------------------------------------------
            if (myObjects[1] is Child)
            {
                // It's safe to downcast to the specific child type.
                Child referenceToChild = (Child)myObjects[1];

                // Once the declared type is a Child, can utilize child-specific methods,
                //   fields, or properties.
                referenceToChild.UniqueMethod();
            }

            Console.WriteLine();



            /*
            // ------------------------------------------------------------------------------------
            // OVERRIDING METHODS
            // ------------------------------------------------------------------------------------
            // Depending on the constructed type in memory, the appropriate Print() method
            //   will execute.
            // Instantiated parent --> calls parent's implementation
            // Instantiated child --> calls dhild implementation
            // ------------------------------------------------------------------------------------

            Parent myParentObj = new Parent();
            myParentObj.Print();

            Console.WriteLine("-------------------------------");

            Parent mySecondParent = new Parent("Supergirl", 10.82);
            mySecondParent.Print();

            Console.WriteLine("-------------------------------");

            Child myChildObj = new Child();
            myChildObj.Print();

            Console.WriteLine("-------------------------------");

            Child mySecondChild = new Child("Apple", 1.00, "shirt");
            mySecondChild.Print();


            // ------------------------------------------------------------------------------------
            // TOSTRING() METHOD OVERRIDING
            // ------------------------------------------------------------------------------------
            // Any defined class can choose to override the ToString() method.
            // Provides a string representation of the class.
            // Verify: Method is called as part of a larger statement.
            // ------------------------------------------------------------------------------------
            string parentObjectInfo = myParentObj.ToString();
            Console.WriteLine("The length of the parent object is " + parentObjectInfo.Length);
            
            Console.WriteLine(myParentObj.ToString());
            Console.WriteLine(mySecondChild.ToString());
            */
        }
    }
}
