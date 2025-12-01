
// Erin Cascioli
// 10/31/25
// Demo: Methods with OOP

namespace OOP_EnemyMethods_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate 2 objects of the Enemy class
            Enemy firstEnemy = new Enemy("Godzilla", 75);
            Enemy secondEnemy = new Enemy("Mothra", 100);

            // This method prints the class name of the first enemy
            // We'll look at how to override this next week!
            //Console.WriteLine(firstEnemy.ToString());

            // Print the enemy stats
            firstEnemy.PrintEnemy();
            Console.WriteLine("---------------------------------------");
            secondEnemy.PrintEnemy();
            Console.WriteLine("---------------------------------------\n\n");

            // Take some damage, then reprint stats for confirmation of damage taken
            Console.WriteLine($"----- {secondEnemy.name} ATTACKS {firstEnemy.name} -----");
            int attackDamage = secondEnemy.Attack();
            Console.WriteLine("The enemy attacks for " + attackDamage);
            firstEnemy.TakeDamage(attackDamage);
            firstEnemy.PrintEnemy();

            // The enemy runs across a health pack and heals to full health
            Console.WriteLine($"\n\n----- {firstEnemy.name} FINDS A HEALTH PACK -----");
            firstEnemy.HealToFullHealth();
            firstEnemy.PrintEnemy();
        }
    }
}
