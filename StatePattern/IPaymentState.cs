using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal interface IPaymentState
    {
        void SelectService(PaymentContext context, string service);
        void EnterPaymentDetails(PaymentContext context, string details);
        void ConfirmPayment(PaymentContext context);
    }
}
