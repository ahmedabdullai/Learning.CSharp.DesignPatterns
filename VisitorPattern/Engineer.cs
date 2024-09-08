using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class Engineer : IEmployee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Engineer(string name, double salary)
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
