using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class GooglePayPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"SuucessFully Paid ${amount} to merchant using Google Pay");
        }
    }
}
