using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class SelectingServiceState : IPaymentState
    {
        public void SelectService(PaymentContext context, string service)
        {
            Console.WriteLine($"Услуга \"{service}\" выбрана.");
            context.Service = service;
            context.SetState(new WaitingForPaymentState());
        }

        public void EnterPaymentDetails(PaymentContext context, string details)
        {
            Console.WriteLine("Сначала нужно выбрать услугу.");
        }

        public void ConfirmPayment(PaymentContext context)
        {
            Console.WriteLine("Нельзя подтвердить оплату без выбора услуги.");
        }

        public override string ToString() => "Выбор услуги";
    }
}
