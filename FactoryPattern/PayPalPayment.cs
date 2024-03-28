using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class PayPalPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"SucessFully Paid ${amount} to merchant using Pay Pal Method");
        }
    }
}
