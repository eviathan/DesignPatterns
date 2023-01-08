namespace StrategyPattern.Strategies
{
    public interface IWeaponStrategy
    {
        void Attack(IAttackable target);
    }
}