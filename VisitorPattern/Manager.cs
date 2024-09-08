using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class Manager : IEmployee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Manager(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
