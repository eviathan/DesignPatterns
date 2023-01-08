using System;
using StrategyPattern.Strategies;

namespace StrategyPattern
{
    public class Player : IAttackable
    {
        public int Health { get; set; } = 100;

        public IWeaponStrategy Weapon { get; set; }

        public void Attack(IAttackable target)
        {
            if(Weapon == null)
                return;
                
            Weapon.Attack(target);
            Console.WriteLine($"Target was attacked with {Weapon.GetType().Name} their health is now: {target.Health}");
        }
    }
}