using System;

namespace StrategyPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var sword = new SwordBehavior();
            var slap = new SlapBehavior();

            var marshall = new Marshall();
            var barney = new Barney();

            Console.WriteLine("Slapbet round 1!");

            Console.WriteLine("Barney annoys Marshall!");

            Console.WriteLine("Marshall prepares his hand!");
            marshall.SetWeapon(slap);

            marshall.Fight();

            Console.WriteLine("Barney is slapped in the face!");
            Console.WriteLine("Barney equips a sword!");

            barney.SetWeapon(sword);
            barney.Fight();

            Console.WriteLine("Marshall equips a Sword too!");
            marshall.SetWeapon(sword);
            marshall.Fight();

            Console.WriteLine("They duel.");

            Console.ReadLine();
        }
    }
}