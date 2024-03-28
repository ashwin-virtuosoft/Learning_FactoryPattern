using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPayment payment = PaymentFactory.Create(PaymentMethod.GooglePay);
            payment.Pay(1000.00);
            Console.ReadKey();
        }
    }
}
