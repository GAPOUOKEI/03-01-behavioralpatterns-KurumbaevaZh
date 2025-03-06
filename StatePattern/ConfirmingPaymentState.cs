using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class ConfirmingPaymentState : IPaymentState
    {
        public void SelectService(PaymentContext context, string service)
        {
            Console.WriteLine("Оплата уже в процессе, изменить услугу нельзя.");
        }

        public void EnterPaymentDetails(PaymentContext context, string details)
        {
            Console.WriteLine("Оплата уже в процессе, изменить данные нельзя.");
        }

        public void ConfirmPayment(PaymentContext context)
        {
            Console.WriteLine("Оплата успешно завершена!");
            Console.WriteLine($"Квитанция: Услуга \"{context.Service}\", Оплачено с {context.PaymentDetails}");
            context.SetState(new SelectingServiceState());
        }

        public override string ToString() => "Подтверждение оплаты";

    }
}
