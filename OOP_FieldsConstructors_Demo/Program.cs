// Erin Cascioli
// 10/29/25
// Demo: OOP - Fields and constructors

namespace OOP_FieldsConstructors_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Make an object of type RPGCharacter with the default constructor
            RPGCharacter bob = new RPGCharacter();

            // Instantiate a RPGCharacter with the first parameterized constructor
            RPGCharacter jane = new RPGCharacter("Jane");

            // Instantiate a RPGCharacter with the second parameterized constructor
            RPGCharacter sam = new RPGCharacter("Sam", Weapon.Spear, 85, 4);

            // Access public data of any of these three objects
            Console.WriteLine(bob.charName + " wields a " + bob.charWeapon);
            Console.WriteLine(jane.charName + " wields a " +jane.charWeapon);
            Console.WriteLine(sam.charName + " wields a " + sam.charWeapon);
        }
    }
}
