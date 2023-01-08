using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Enemy : IAttackable
    {
        public int Health { get; set; } = 100;
    }
}