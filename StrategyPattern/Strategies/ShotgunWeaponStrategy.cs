using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyPattern.Strategies
{
    public class ShotgunWeaponStrategy : IWeaponStrategy
    {
        public void Attack(IAttackable target)
        {
            target.Health -= 25;
        }
    }
}