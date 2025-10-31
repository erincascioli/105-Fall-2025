namespace OOP_Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RPGCharacter bob = new RPGCharacter();
            Console.WriteLine(bob.name);

            RPGCharacter bob2 = new RPGCharacter();
            Console.WriteLine(bob2.name);

            RPGCharacter bob3 = new RPGCharacter();
            Console.WriteLine(bob3.name);

            RPGCharacter jane = new RPGCharacter("Jane");
            Console.WriteLine(jane.name);

            // Kai - level 1 - health 1 - weapon - spear
            RPGCharacter kai = new RPGCharacter("Kai", 1, 1, Weapon.Spear);
            Console.WriteLine(kai.name + " " + kai.weapon);

            RPGCharacter erin = new RPGCharacter("Erin", 84, 2);
            Console.WriteLine(erin.name + " " + erin.weapon);
        }
    }
}
