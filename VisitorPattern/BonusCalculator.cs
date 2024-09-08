using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class BonusCalculator : IVisitor
    {
        public void Visit(Engineer engineer)
        {
            double bonus = engineer.Salary * 0.10;
            Console.WriteLine($"{engineer.Name} (Engineer) bonus: {bonus}");
        }

        public void Visit(Manager manager)
        {
            double bonus = manager.Salary * 0.15;
            Console.WriteLine($"{manager.Name} (Manager) bonus: {bonus}");
        }
    }
}
