using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Add : ICalculate
    {
        public void Calculate(int num1, int num2)
        {
            Console.WriteLine("a+b is {0}", num1 + num2);
        }
    }
}
