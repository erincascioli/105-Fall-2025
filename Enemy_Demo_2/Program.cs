namespace Enemy_Demo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Enemy goblin = new Enemy("Goober", 84);
            Enemy orc = new Enemy("", 5);

            Console.WriteLine("------- INFO ABOUT GOBLIN -------");
            goblin.PrintEnemy();
            goblin.PrintHealthInformation();

            Console.WriteLine($"\n{goblin.name} takes damage!!");
            goblin.TakeDamage(-15);
            goblin.PrintHealthInformation();

            Console.WriteLine("\n-------- INFO ABOUT ORC ----------");
            orc.PrintEnemy();
            orc.PrintHealthInformation();

            Console.WriteLine($"\n{orc.name} takes damage!!");
            orc.TakeDamage(15);
            orc.PrintHealthInformation();
        }
    }
}
