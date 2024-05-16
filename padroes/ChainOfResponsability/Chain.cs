using ChainOfResponsability.Handlers;

namespace ChainOfResponsability
{
    public class Chain
    {
        public IHandler FirstLink { get; set; }
        public Chain()
        {
            var sendProduct = new SendProductHandler();
            var billGenarator = new BillGenerationHandler(sendProduct);
            var getDeliveryAddress = new GetDeliveryAddress(billGenarator);
            var paymentValidation = new PaymentValidationHandler(getDeliveryAddress);
            var getPayment = new GetPaymentHandler(paymentValidation);
            var stockValidation = new StockValidationHandler(getPayment);
            FirstLink = new SelectProduct(stockValidation);
        }

        public void StartProcessChained()
        {
            var request = new Request();

            FirstLink.Handle(request);
        }
    }
}
