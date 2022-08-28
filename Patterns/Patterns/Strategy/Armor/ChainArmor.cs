using System;
using Patterns.Strategy.Interface;

namespace Patterns.Strategy.Armor
{
    public class ChainArmor: IArmorType
    {
        public void DamageBlock()
        {
            Console.WriteLine("Кольчужная броня блокирует 50% урона");
        }
    }
}