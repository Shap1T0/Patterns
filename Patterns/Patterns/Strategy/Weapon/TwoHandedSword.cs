using System;

namespace Patterns.Strategy.Weapon
{
    public class TwoHandedSword: IWeaponType
    {
        public void MakeDamage()
        {
            Console.WriteLine("Удар двуручным мечем");
        }
    }
}