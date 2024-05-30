using FactoryMethodPattern.bin.Interfaces;
using FactoryMethodPattern.Enums;
using FactoryMethodPattern.Interfaces;
using FactoryMethodPattern.Models;

namespace FactoryMethodPattern.Factories
{
    public class CakeFactory : ICakeFactory
    {
        private Dictionary<CakeType, int> _stock { get; set; } = new()
        {
            { CakeType.Battenberg, 10 },
            { CakeType.CarrotCake, 2 },
            { CakeType.Madeira, 3 },
            { CakeType.VictoriaSponge, 4 },
        };

        public ICake Bake(CakeType type)
        {
            if (TryGetCake(type, out var cake))
            {
                Console.WriteLine($"Baked a {type}. Stock is now: {_stock[type]}");
                return cake;
            }
            else
            {
                throw new ArgumentOutOfRangeException($"Could not get cake: {type}");
            }
        }

        private bool TryGetCake(CakeType type, out ICake cake)
        {
            cake = null!;

            if (_stock.TryGetValue(type, out var amount) && amount > 0)
            {
                switch (type)
                {
                    case CakeType.Battenberg:
                        cake = new Battenberg();
                        break;
                    case CakeType.CarrotCake:
                        cake = new CarrotCake();
                        break;
                    case CakeType.Madeira:
                        cake = new MadeiraCake();
                        break;
                }

                _stock[type] = _stock[type] - 1;
                return true;
            }

            return false;
        }
    }
}