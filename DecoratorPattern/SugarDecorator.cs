using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee) { }

        public override double GetCost()
        {
            return _coffee.GetCost() + 0.5;
        }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + ", Sugar";
        }
    }
}
