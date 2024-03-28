using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class PaymentFactory
    {
        public static IPayment Create(PaymentMethod paymentMethod)
        {
            switch(paymentMethod)
            {
                case PaymentMethod.CreditCard: return new CreditCardPayment();
                case PaymentMethod.GooglePay: return new GooglePayPayment();
                case PaymentMethod.PayPal: return new PayPalPayment();

                default:
                    throw new NotSupportedException("Not Supported");
            }
        }
    }
}
