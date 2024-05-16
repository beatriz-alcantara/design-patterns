using Strategy.Strategies;

namespace Strategy
{
    public class Context
    {
        private IStrategyRouter RouteStrategy;

        public void SetStrategy(IStrategyRouter strategy) => RouteStrategy = strategy;

        public void Execute(string source, string destination) => RouteStrategy.BuildRoute(source, destination);
        public Context(IStrategyRouter strategy)
        {
            RouteStrategy = strategy;
        }

        public Context()
        {}
    }
}
