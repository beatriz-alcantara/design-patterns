namespace Strategy.Strategies
{
    public interface IStrategyRouter
    {
        void BuildRoute(string source, string destination);
    }
}
