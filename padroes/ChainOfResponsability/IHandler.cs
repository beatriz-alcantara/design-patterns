namespace ChainOfResponsability
{
    public interface IHandler
    {
        void SetNextHandler(IHandler nextHandler);
        void Handle(Request request);
    }
}
