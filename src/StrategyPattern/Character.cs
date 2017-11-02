namespace StrategyPattern
{
    using System;

    public abstract class Character
    {
        protected Character(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public IWeaponBehavior Weapon { get; private set; }

        public void SetWeapon(IWeaponBehavior weapon)
        {
            this.Weapon = weapon;
        }

        public abstract void Fight();
    }
}