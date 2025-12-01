using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Demo
{
    public enum Weapon
    {
        Sword,
        Axe,
        Dagger
    }

    /// <summary>
    /// Enemy class represents a basic Enemy in a console or PC game.
    /// </summary>
    internal class Enemy
    {
        // --------------------------------------------------------------------
        // FIELDS of the class are now PRIVATE
        // --------------------------------------------------------------------
        private string name;
        private int currentHealth;
        private int maxHealth;
        private Weapon enemyWeapon;
        private string[] heldItems;
        private Random generator;

        // --------------------------------------------------------------------
        // PROPERTIES of the class
        // --------------------------------------------------------------------
        // Properies are lightweight "shortcuts" to writing methods.
        // They are expected by C# programmers!
        // --------------------------------------------------------------------


        // ** Name property:
        // Allows access to the name field from outside of this Enemy class
        // Get block --> "Passes back" the value inside of the name field
        //   to outside of this class
        public string Name
        {
            get { return name; }
        }


        // ** CurrentHealth property:
        // Set block --> Allows a field to be assigned a different value from outside of this class
        // Set blocks are commonly "limited", meaning changing the value only occurs when specific
        //   circumstances are met.
        public int CurrentHealth
        {
            get { return currentHealth; }
            set 
            { 
                // ONLY want to change the current health if it's less than max health AND greater/equal to 0
                // Limitation protects the data from being assigned to a value outside of the range.
                if(value <= maxHealth && value >= 0)
                {
                    currentHealth = value;
                }

                // Value outside of that range? The currentHealth field is NOT modified!
            }
        }


        // ** IsDeadYet property:
        // Some properties do not have a "backing field", meaning there is no explicit field defined in
        //   this class that's being returned or modified.
        // Properties without backing fields oftentimes perform a small calculation or use a Boolean
        //   expression, like this one:
        public bool IsDeadYet
        {
            // Return whether the enemy is dead yet, without the use of a DeadYet field.
            get { return currentHealth == 0; }
        }


        // Auto-property DO NOT USE THESE IN 105!!!
        //public int MyProperty { get; set; }


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
            if (currentHealth > 100)
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
            for (int i = 0; i < heldItems.Length; i++)
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
            if (enemyWeapon == Weapon.Sword)         // Sword -> 10 damage
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
            else if (currentHealth > 0 && currentHealth <= 49)
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
