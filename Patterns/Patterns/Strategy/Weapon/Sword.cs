using System;

namespace Patterns.Strategy.Weapon
{
    public class Sword: IWeaponType
    {
        public void MakeDamage()
        {
            Console.WriteLine("Удар мечем");
        }
    }
}