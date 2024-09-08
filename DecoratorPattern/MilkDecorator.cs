using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee) { }

        public override double GetCost()
        {
            return _coffee.GetCost() + 1.5;
        }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + ", Milk";
        }
    }
}
