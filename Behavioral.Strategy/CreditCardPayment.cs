using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class CreditCardPayment : IPaymentStrategy
    {
        private string _cardNumber;

        public CreditCardPayment(string cardNumber)
        {
            _cardNumber = cardNumber;
        }

        public void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount:C} using Credit Card (Card Number: {_cardNumber}).");
        }
    }
}
