using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    internal class Program
    {

        struct Person
        {
            public string Name;
            public int Health;
            public int Strength;
            public int Dexterity;
            public int Intelligence;

            public void Print()
            {
                Console.WriteLine();
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Health: " + Health);
                Console.WriteLine("Strength: " + Strength);
                Console.WriteLine("Dexterity: " + Dexterity);
                Console.WriteLine("Intelligence: " + Intelligence);
                Console.WriteLine();
            }
        }

        static Person Rogue;
        static Person Fighter;
        static Person Mage;        

        static void Main(string[] args)
        {
            Rogue.Name = "Roger The Rogue";
            Rogue.Health = 7;
            Rogue.Strength = 4;
            Rogue.Dexterity = 10;
            Rogue.Intelligence = 7;

            Fighter.Name = "Fred The Fighter";
            Fighter.Health = 10;
            Fighter.Strength = 10;
            Fighter.Dexterity = 6;
            Fighter.Intelligence = 4;

            Mage.Name = "Margueritte The Mage";
            Mage.Health = 5;
            Mage.Strength = 4;
            Mage.Dexterity = 7;
            Mage.Intelligence = 10;

            Console.WriteLine("Structs");
            Console.WriteLine();
            Rogue.Print();
            Fighter.Print();
            Mage.Print();
            Console.WriteLine();
            Console.WriteLine("Press Any Button To Close");
            Console.ReadKey(true);
        }
    }
}
