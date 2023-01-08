using System;
using StrategyPattern.Strategies;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();
            var enemy = new Enemy();
            
            player.Weapon = new PistolWeaponStrategy();

            player.Attack(enemy);
            player.Attack(enemy);

            player.Weapon = new ShotgunWeaponStrategy();
            player.Attack(enemy);
            player.Attack(enemy);
        }
    }
}
