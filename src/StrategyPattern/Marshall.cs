namespace StrategyPattern
{
    using System;

    public class Marshall : Character
    {
        public Marshall()
            : base((string) nameof(Marshall))
        {
        }

        public override void Fight()
        {
            this.Weapon.UseWeapon();
        }
    }
}