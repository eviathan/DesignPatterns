namespace StrategyPattern
{
    public interface IPowerUp
    {
        float Duration { get; }

        PlayerConfig Apply(PlayerConfig config);
    }
}