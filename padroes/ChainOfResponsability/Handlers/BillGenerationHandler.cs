namespace ChainOfResponsability.Handlers
{
    public class BillGenerationHandler : BaseHandler
    {
        public BillGenerationHandler(IHandler nextHandler) : base(nextHandler)
        {
        }

        public override void Handle(Request request)
        {
            Console.WriteLine("Fatura gerada");
            base.Handle(request);
        }
    }
}
