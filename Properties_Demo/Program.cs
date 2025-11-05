using System;

namespace Properties_Demo
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
            Console.WriteLine($"----- {secondEnemy.Name} ATTACKS {firstEnemy.Name} -----");
            int attackDamage = secondEnemy.Attack();
            Console.WriteLine("The enemy attacks for " + attackDamage);
            firstEnemy.TakeDamage(attackDamage);
            firstEnemy.PrintEnemy();

            // The enemy runs across a health pack and heals to full health
            Console.WriteLine($"\n\n----- {firstEnemy.Name} FINDS A HEALTH PACK -----");
            firstEnemy.HealToFullHealth();
            firstEnemy.PrintEnemy();

            // ------------------------------------------------------------------------------------
            // Calling Properties
            // ------------------------------------------------------------------------------------

            // The Name property does not have a set block, so reassignment of its value cannot occur.
            //firstEnemy.Name = "szjkvbxdfjkxd";        // NOOOO! INACCESSIBLE!

            // The set block of the CurrentHealth peoperty is being called here.
            // Since CurrentHealth has a set block, this code is syntactically correct.
            firstEnemy.CurrentHealth = 1;
            firstEnemy.PrintEnemy();

            // The IsDeadYet property returns whether they character is dead as a boolean.
            // This syntax calls the get block.
            bool enemyIsDead = firstEnemy.IsDeadYet;
            Console.WriteLine($"Is {firstEnemy.IsDeadYet} dead? {enemyIsDead}.");

            // The set block of the CurrentHealth peoperty is being called here.
            // Since CurrentHealth has a set block, this code is syntactically correct.
            // HOWEVER, 194726 is not being set as the value in the property, because it's
            //   outside the range of 0 - maxHealth.
            firstEnemy.CurrentHealth = 194726;

            // So when we print it, the enemy's health is still 1.
            firstEnemy.PrintEnemy();
        }
    }
}
