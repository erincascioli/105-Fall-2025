
// --------------------------------------------------------------------
// All new class files will contain using statements at the top of the file.
// Feel free to keep or remove.
// --------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_FieldsConstructors_Demo
{
    /// <summary>
    /// Weapon enumeration, a field of the RPGCharacter class.
    /// </summary>
    public enum Weapon
    {
        Spear,
        Axe,
        Bow,
        Fist
    }


    // --------------------------------------------------------------------
    // Every class must have an XML comment above it
    // --------------------------------------------------------------------
    /// <summary>
    /// This class represents a character in an RPG game.
    /// </summary>
    internal class RPGCharacter
    {
        // --------------------------------------------------------------------
        // Fields first - Declarations ONLY!!!
        // We will assign these values somewhere else
        // Declare all as PUBLIC for now.  (We'll talk about PRIVATE later!)
        // --------------------------------------------------------------------
        public Weapon charWeapon;
        public string charName;
        public int health;
        public int level;

        // --------------------------------------------------------------------
        // Properties second (next week!)
        // --------------------------------------------------------------------

        // --------------------------------------------------------------------
        // Constructors third
        // Default --> Assigns a value to every field of the class
        // Parameterized --> Allows parameterization of field values, or a combination
        //   of parameterized data and default data.
        // Include an XML comment above each constructor!
        // --------------------------------------------------------------------
        /// <summary>
        /// Default constructor that assigns default data to the RPGCharacter class
        /// </summary>
        public RPGCharacter()
        {
            charWeapon = Weapon.Fist;
            charName = "Bob";
            health = 100;
            level = 1;
        }

        /// <summary>
        /// Parameterized constructor of the RPG Character class, where the weapon, health
        /// and level have default data.
        /// </summary>
        /// <param name="charName">Player's name</param>
        public RPGCharacter(string charName)
        {
            this.charName = charName;
            this.charWeapon = Weapon.Fist;
            this.health = 100;
            this.level = 1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="charName">Player's name</param>
        /// <param name="charWeapon">Player's weapon</param>
        /// <param name="health">Player's initial health</param>
        /// <param name="level">Player's initial level</param>
        public RPGCharacter(string charName, Weapon charWeapon, int health, int level)
        {
            this.charName = charName;
            this.charWeapon = charWeapon;
            this.health = health;
            this.level = level;
        }


        // --------------------------------------------------------------------
        // Methods last
        // --------------------------------------------------------------------

    }
}
