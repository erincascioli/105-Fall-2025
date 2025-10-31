using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_EnemyMethods_Demo
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
        public int maxHealth;
        public Weapon enemyWeapon;
        public string[] heldItems;
        public Random generator;


        // --------------------------------------------------------------------
        // CONSTRUCTOR of the class
        // --------------------------------------------------------------------

        /// <summary>
        /// Constructs an Enemy object
        /// </summary>
        /// <param name="name">Name of the enemy, where the name indicates the weapon held</param>
        /// <param name="currentHealth">Current health in hit points (out of 100).</param>
        public Enemy(string name, int currentHealth)
        {
            generator = new Random();

            // Prevent against empty names
            if (name.Length > 0)
            {
                this.name = name;
            }
            else
            {
                this.name = "Billy";
            }
            
            // Pass in a value larger than 100? Only apply 100 hit points.
            if(currentHealth > 100)
            {
                currentHealth = 100;
            }
            // Account for possible negative health values
            else
            {
                this.currentHealth = Math.Abs(currentHealth);
            }

            // All Enemies are maxed to 100 HP
            maxHealth = 100;

            // Weapon type is dependent on the name length
            int nameLength = name.Length;

            if (nameLength <= 3)                 // 0-3 chars
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
        /// Prints information about this Enemy.
        /// </summary>
        public void PrintEnemy()
        {
            // Print individual data about this Enemy
            Console.WriteLine($"The enemy's name is {name} who has {currentHealth}/{maxHealth} hp.");
            Console.WriteLine($"It wields {enemyWeapon}");

            // Iterate through all of its items
            Console.WriteLine($"{name} has these items in its pack: ");
            for(int i = 0; i < heldItems.Length; i++)
            {
                Console.WriteLine(heldItems[i]);
            }
        }


        /// <summary>
        /// Harm the enemy by a specified amount of hit points.
        /// </summary>
        /// <param name="damage">Hit points of damage</param>
        public void TakeDamage(int damage)
        {
            // How can we break this method? By passing in negative damage!
            // How can we prevent against that?
            // 1. Take the absolute value of damage so its always positive
            // 2. Check if its negative and don't reduce by that amount
            currentHealth -= Math.Abs(damage);
        }


        /// <summary>
        /// Generate an attack for another Enemy
        /// </summary>
        /// <returns>Integer hit points of attack</returns>
        public int Attack()
        {
            int damage = 0;
            
            // Damage is dependent on the weapon held
            if(enemyWeapon == Weapon.Sword)         // Sword -> 10 damage
            {
                damage = 10;
            }
            else if (enemyWeapon == Weapon.Axe)     // Axe -> 15 damage
            {
                damage = 15;
            }
            else                                    // Dagger -> 7 damage
            {
                damage = 7;
            }

            // If health is below 80%, damage is reduced by a certain amount.
            // Full to 80% health --> 100% damage
            // 50 - 79% health --> 70% damage
            // 0 to 49% health --> 50% damage
            if (currentHealth >= 50 && currentHealth <= 79)
            {
                damage = (int)(damage * 0.7);
            }
            else if(currentHealth > 0 && currentHealth <= 49)
            {
                damage = (int)(damage * 0.5);
            }

            // 100% health? Possible bonus attack!
            if (currentHealth == 100)
            {
                damage += generator.Next(0, 6);
            }

            return damage;
        }

        /// <summary>
        /// Heal the enemy back to full health
        /// </summary>
        public void HealToFullHealth()
        {
            currentHealth = maxHealth;
        }
    }
}
