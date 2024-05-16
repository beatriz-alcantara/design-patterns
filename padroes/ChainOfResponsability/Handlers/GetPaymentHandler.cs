namespace ChainOfResponsability.Handlers
{
    public class GetPaymentHandler : BaseHandler
    {
        public GetPaymentHandler(IHandler? nextHandler = null) : base(nextHandler)
        {
        }

        public override void Handle(Request request)
        {
            Console.WriteLine("Pague o valor do produto:");

            var payment = decimal.Parse(Console.ReadLine());
            request.Payment = payment;
            base.Handle(request);
        }
    }
}
