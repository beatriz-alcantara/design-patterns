namespace ChainOfResponsability.Handlers
{
    public class StockValidationHandler : BaseHandler
    {
        public StockValidationHandler(IHandler nextHandler) : base(nextHandler)
        {
        }

        public override void Handle(Request request)
        {
            bool hasProductInStock = products.Any(p => p.Name == request.Product && p.Quantity > 0);
            if (hasProductInStock is false)
            {
                Console.WriteLine("Que pena. O produto que você selecionou não está mais em estoque");
                return;
            }
            
            Console.WriteLine("Que ótimo!! Temos seu produto em estoque");
            
            base.Handle(request);
        }
    }
}
