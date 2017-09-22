namespace StrategyPattern
{
    using System;

    public class SwordBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("You got Slashed!");
        }
    }
}