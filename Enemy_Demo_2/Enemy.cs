using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enemy_Demo_2
{
    public enum Weapon
    {
        Sword,
        Axe,
        Dagger
    }

    internal class Enemy
    {
        // --------------------------------------------------------------------
        // FIELDS of the class
        // --------------------------------------------------------------------
        public string name;
        public int currentHealth;
        public const int MaxHealth = 100;
        public Weapon enemyWeapon;
        public string[] heldItems;


        // --------------------------------------------------------------------
        // CONSTRUCTOR of the class
        // --------------------------------------------------------------------

        // TODO: Add an XML comment for this constructor
        public Enemy(string name, int currentHealth)
        {
            // Did an empty name get passed in as the param? 
            if (name.Length == 0)
            {
                this.name = "Bob";
            }
            else
            {
                this.name = name;
            }

            if (currentHealth > MaxHealth)
            {
                this.currentHealth = MaxHealth;
            }
            else
            {
                this.currentHealth = currentHealth;
            }

            // Weapon type is dependent on the name length
            int nameLength = name.Length;

            if (nameLength >= 1 && nameLength <= 3)         // 1-3 chars
            {
                enemyWeapon = Weapon.Sword;
            }
            else if (nameLength <= 7)            // 4-7 chars
            {
                enemyWeapon = Weapon.Axe;
            }
            else                                // 8+ chars
            {
                enemyWeapon = Weapon.Dagger;
            }

            // All enemies start with the same 3 items
            heldItems = new string[3] { "rations", "trinket", "trap" };
        }


        // --------------------------------------------------------------------
        // METHODS of the class
        // --------------------------------------------------------------------

        /// <summary>
        /// Print information about the Enemy.
        /// </summary>
        public void PrintEnemy()
        {
            // Printing to the console: name, current health/max health, 
            //     weapon, a list of the items they hold
            Console.WriteLine($"{name} has {currentHealth}/{maxHealth} hit points.");
            Console.WriteLine($"{name} wields a {enemyWeapon}.");
            Console.WriteLine($"Items in {name}'s bag are:");
            for(int i = 0; i < heldItems.Length; i++)
            {
                Console.WriteLine($" - {heldItems[i]}");
            }
        }

        /// <summary>
        /// Displays health information about an Enemy.
        /// </summary>
        public void PrintHealthInformation()
        {
            Console.WriteLine($"{name} has {currentHealth}/{MaxHealth} hit points.");
        }

        /// <summary>
        /// Harms an Enemy for a specific number of hit points
        /// </summary>
        /// <param name="damage">Hit points of damage</param>
        public void TakeDamage(int damage)
        {
            currentHealth -= Math.Abs(damage);
        }

        /// <summary>
        /// Heals the enemy for a specific number of hit points
        /// </summary>
        /// <param name="healPoints">Points to heal the enemy</param>
        public void Heal(int healPoints)
        {
            currentHealth += Math.Abs(healPoints);
        }

        // Write an attack method dependent on the type of weapon and also if I'm at 
        //   100% health, possible bonus crit attack of 1 - 5.

    }
}
