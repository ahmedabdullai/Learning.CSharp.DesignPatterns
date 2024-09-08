using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Projector
    {
        public void On() => Console.WriteLine("Projector is on");
        public void Off() => Console.WriteLine("Projector is off");
        public void SetInput(string input) => Console.WriteLine($"Projector input set to {input}");
    }
}
