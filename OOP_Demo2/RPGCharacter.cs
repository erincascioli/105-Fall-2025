using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo2
{
    public enum Weapon
    {
        Fist,
        Axe,
        Sword,
        Spear,
        TinyScorpionOnAStick
    }

    /// <summary>
    /// Class that represents an RPG Character in a game.
    /// </summary>
    internal class RPGCharacter
    {
        // Fields
        public string name;
        public int health;
        public int level;
        public Weapon weapon;

        // Properties are usually defined next (We'll go over next week!)

        // Constructors are defined third
        /// <summary>
        /// 
        /// </summary>
        public RPGCharacter()
        {
            name = "Bob";
            health = 100;
            level = 1;
            weapon = Weapon.Fist;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public RPGCharacter(string name)
        {
            this.name = name;
            health = 100;
            level = 1;
            weapon = Weapon.Fist;
        }

        /// <summary>
        /// Constructor for an RPG character
        /// </summary>
        /// <param name="name">Player's name</param>
        /// <param name="health">Player's health</param>
        /// <param name="level">Player's level</param>
        /// <param name="weapon">Player's weapon (optionally set to Fist if left empty)</param>
        public RPGCharacter(
            string name, 
            int health, 
            int level, 
            Weapon weapon = Weapon.Fist)
        {
            this.name = name;
            this.health = health;
            this.level = level;
            this.weapon = weapon;
        }

        // Methods are usually defined last (Will go over on Friday!)

    }
}
