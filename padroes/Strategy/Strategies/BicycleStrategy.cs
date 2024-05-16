namespace Strategy.Strategies
{
    public class BicycleStrategy : IStrategyRouter
    {
        public void BuildRoute(string source, string destination) =>
            Console.WriteLine($"Building an cycling route from {source} to {destination}");
    }
}
