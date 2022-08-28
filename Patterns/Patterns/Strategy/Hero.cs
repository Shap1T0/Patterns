using Patterns.Strategy.Interface;

namespace Patterns.Strategy
{
    /// <summary>
    /// Стратегия - реализует систему алгоритмов инкапсулирует ее и делает взаимозаменяемыми
    /// </summary>
    public class Hero
    {
        protected int HeroHealth = 100;
        protected IWeaponType WeaponType;
        protected IArmorType ArmorType;


        public void SetWeaponType(IWeaponType weaponType)
        {
            WeaponType = weaponType;
        }

        public void SetArmorType(IArmorType armorType)
        {
            ArmorType = armorType;
        }

        public void Attack()
        {
            WeaponType.MakeDamage();
        }

        public void Block()
        {
            ArmorType.DamageBlock();
        }
    }
}