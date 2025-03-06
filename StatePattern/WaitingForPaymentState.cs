using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class WaitingForPaymentState : IPaymentState
    {
        public void SelectService(PaymentContext context, string service)
        {
            Console.WriteLine("Услуга уже выбрана. Введите данные для оплаты.");
        }

        public void EnterPaymentDetails(PaymentContext context, string details)
        {
            Console.WriteLine($"Данные оплаты введены: {details}");
            context.PaymentDetails = details;
            context.SetState(new ConfirmingPaymentState());
        }

        public void ConfirmPayment(PaymentContext context)
        {
            Console.WriteLine("Сначала нужно ввести данные для оплаты.");
        }

        public override string ToString() => "Ожидание оплаты";
    }
}