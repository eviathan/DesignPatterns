using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public interface IAttackable
    {
        int Health { get; set; }
    }
}