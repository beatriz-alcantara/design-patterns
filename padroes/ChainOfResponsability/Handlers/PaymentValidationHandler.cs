namespace ChainOfResponsability.Handlers
{
    public class PaymentValidationHandler : BaseHandler
    {
        public PaymentValidationHandler(IHandler nextHandler) : base(nextHandler)
        {
        }

        public override void Handle(Request request)
        {
            var selectedProduct = products.First(p => p.Name == request.Product);
            if (selectedProduct.UnitaryPrice > request.Payment)
            {
                Console.WriteLine("Pagamento não suficiente");
                return;
            }
            Console.WriteLine("Pagamento feito com sucesso!!");
            selectedProduct.Quantity--;
            base.Handle(request);
        }
    }
}
