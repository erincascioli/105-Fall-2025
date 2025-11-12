namespace Inheritance_Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent firstParentObj = new Parent();
            firstParentObj.PrintParent();

            Console.WriteLine("-------------------------------");

            Parent secondParentObj = new Parent("Lunchbox", 555);
            secondParentObj.PrintParent();

            Console.WriteLine("-------------------------------");

            Child firstChildObj = new Child();
            firstChildObj.PrintParent();

            Console.WriteLine("-------------------------------");

            Child secondChildObj = new Child("Snow", 38, "Whiteboard");
            secondChildObj.PrintChild();
        }

    }
}
