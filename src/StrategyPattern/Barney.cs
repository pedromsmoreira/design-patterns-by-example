namespace StrategyPattern
{
    public class Barney : Character
    {
        public Barney()
            : base((string)nameof(Barney))
        {
        }

        public override void Fight()
        {
            this.Weapon.UseWeapon();
        }
    }
}