namespace ChainOfResponsability.Handlers
{
    public class SelectProduct : BaseHandler
    {
        public SelectProduct(IHandler? nextHandler = null) : base(nextHandler)
        {
        }

        public override void Handle(Request request)
        {
            Console.WriteLine("Informe qual produto você deseja: ");
            var productSelected = Console.ReadLine();
            request.Product = productSelected;
            base.Handle(request);
        }
    }
}
