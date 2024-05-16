namespace ChainOfResponsability.Handlers
{
    public class SendProductHandler : BaseHandler
    {
        public SendProductHandler(IHandler? nextHandler = null) : base(nextHandler)
        {
        }

        public override void Handle(Request request)
        {
            Console.WriteLine($"Produto sendo preparado para ser enviado ao endereço {request.DeliveryAddress}");
            base.Handle(request);
        }
    }
}
