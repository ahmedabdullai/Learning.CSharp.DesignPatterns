using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class CalculateFactory
    {
        public static ICalculate GetCalculation(string type)
        {
            switch (type.ToLower())
            {
                case "add":
                    return new Add();
                case "subtract":
                    return new Subtract();
                case "multiply":
                    return new Multiply();
                case "divide":
                    return new Divide();
                default:
                    throw new ArgumentException("Invalid type", nameof(type));
            }
        }
    }
}
