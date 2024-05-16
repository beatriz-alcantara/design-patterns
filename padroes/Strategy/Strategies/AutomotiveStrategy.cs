namespace Strategy.Strategies
{
    public class AutomotiveStrategy : IStrategyRouter
    {
        public void BuildRoute(string source, string destination) =>
            Console.WriteLine($"Building an automotive route from {source} to {destination}");
    }
}
