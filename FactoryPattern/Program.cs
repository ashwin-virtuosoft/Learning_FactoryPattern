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
            int choice=0;
            Console.WriteLine("Enter your Payment method");

            while (choice!=5)
            {
                Console.WriteLine("\n 1. Credit Card \n2. PayPal \n3. Google Pay\n");
                choice = int.Parse(Console.ReadLine());

           
                switch (choice)
                {
                    case 1:
                        CreditCard();
                        break;
                    case 2:
                        PayPal();
                        break;
                    case 3:
                        GooglePay();
                        break;
                    case 4:
                        Console.WriteLine("existing");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
            }


            void CreditCard()
            {
                IPayment payment = PaymentFactory.Create(PaymentMethod.CreditCard);
                payment.Pay(1200.00);
            }

            void PayPal()
            {   
                    IPayment payment = PaymentFactory.Create(PaymentMethod.PayPal);
                    payment.Pay(1400.00);
            }

            void GooglePay()
            {
                IPayment payment = PaymentFactory.Create(PaymentMethod.GooglePay);
                payment.Pay(1000.00);
            }

        }
    }
}
