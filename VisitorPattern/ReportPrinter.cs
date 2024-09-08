using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class ReportPrinter : IVisitor
    {
        public void Visit(Engineer engineer)
        {
            Console.WriteLine($"Engineer: {engineer.Name}, Salary: {engineer.Salary}");
        }

        public void Visit(Manager manager)
        {
            Console.WriteLine($"Manager: {manager.Name}, Salary: {manager.Salary}");
        }
    }
}
