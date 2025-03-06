using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class PaymentContext
    {
        private IPaymentState _currentState;
        public string Service { get; set; }
        public string PaymentDetails { get; set; }

        public PaymentContext()
        {
            _currentState = new SelectingServiceState();
        }

        public void SetState(IPaymentState newState)
        {
            Thread.Sleep(1500);
            _currentState = newState;
            Console.WriteLine($"Состояние изменено на: {_currentState}\n");
        }

        public void SelectService(string service) => _currentState.SelectService(this, service);
        public void EnterPaymentDetails(string details) => _currentState.EnterPaymentDetails(this, details);
        public void ConfirmPayment() => _currentState.ConfirmPayment(this);

    }
}
