using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class BankTransferPayment : IPaymentStrategy
    {
        private string _accountNumber;

        public BankTransferPayment(string accountNumber)
        {
            _accountNumber = accountNumber;
        }

        public void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount:C} using Bank Transfer (Account Number: {_accountNumber}).");
        }
    }
}
