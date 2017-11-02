namespace StrategyPattern
{
    using System;

    public class SlapBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("You just got Slapped! In the face my friend.");
        }
    }
}