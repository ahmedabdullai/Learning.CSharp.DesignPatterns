using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Lights
    {
        public void Dim(int level) => Console.WriteLine($"Lights dimmed to {level}%");
        public void On() => Console.WriteLine("Lights are on");
        public void Off() => Console.WriteLine("Lights are off");
    }
}
