namespace Factory_Pattern.Models.Commerce
{
    public class Payment
    {
        public decimal Amount { get; set; }
        public PaymentProvider PaymentProvider { get; set; }
    }
}