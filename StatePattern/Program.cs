namespace StatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentContext payment = new PaymentContext();
            payment.SelectService("Интернет");
            Thread.Sleep(2000);
            payment.EnterPaymentDetails("Карта VISA ****1234");
            Thread.Sleep(2000);
            payment.ConfirmPayment();
            Thread.Sleep(2000);
            Console.WriteLine("\n Оплата завершена!\n");
        }
    }
}
