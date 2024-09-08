using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class ChocolateDecorator : CoffeeDecorator
    {
        public ChocolateDecorator(ICoffee coffee) : base(coffee) { }

        public override double GetCost()
        {
            return _coffee.GetCost() + 2.0;
        }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + ", Chocolate";
        }
    }
}
