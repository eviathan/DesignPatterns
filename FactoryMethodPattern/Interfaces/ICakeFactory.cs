using FactoryMethodPattern.bin.Interfaces;
using FactoryMethodPattern.Enums;

namespace FactoryMethodPattern.Interfaces
{
    public interface ICakeFactory
    {
        public ICake Bake(CakeType type);
    }
}