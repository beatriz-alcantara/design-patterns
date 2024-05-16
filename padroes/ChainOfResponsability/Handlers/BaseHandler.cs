namespace ChainOfResponsability.Handlers
{
    public class BaseHandler : IHandler
    {
        protected static IEnumerable<Product> products = new List<Product>
        {
            new Product("Mesa", 3, 1500),
            new Product("Monitor", 0, 700)
        };

        private IHandler? NextHandler { get; set; } = null;

        public BaseHandler(IHandler? nextHandler = null)
        {
            NextHandler = nextHandler;
        }

        public virtual void Handle(Request request)
        {
            if (NextHandler == null)
            {
                Console.WriteLine("Não há próximo passo");
                return;
            }

            NextHandler.Handle(request);
        }

        public void SetNextHandler(IHandler nextHandler) => NextHandler = nextHandler;
    }

    public class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal UnitaryPrice { get; set; }

        public Product(string name, int quantity, decimal unitaryPrice)
        {
            Name = name;
            Quantity = quantity;
            UnitaryPrice = unitaryPrice;
        }
    }
}
