using System;

namespace Patterns.Strategy.Weapon
{
    public class Bow: IWeaponType
    {
        public void MakeDamage()
        {
            Console.WriteLine("Выстрел из лука");
        }
    }
}