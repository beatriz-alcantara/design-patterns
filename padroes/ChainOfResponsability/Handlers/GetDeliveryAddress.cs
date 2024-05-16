namespace ChainOfResponsability.Handlers
{
    public class GetDeliveryAddress : BaseHandler
    {
        public GetDeliveryAddress(IHandler? nextHandler = null) : base(nextHandler)
        {
        }

        public override void Handle(Request request)
        {
            Console.WriteLine("Informe o endereço de entrega:");

            var address = Console.ReadLine();
            request.DeliveryAddress = address;

            base.Handle(request);
        }
    }
}
