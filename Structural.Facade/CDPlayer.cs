using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class CDPlayer
    {
        public void On() => Console.WriteLine("CD Player is on");
        public void Off() => Console.WriteLine("CD Player is off");
        public void Play(string cd) => Console.WriteLine($"Playing {cd}");
        public void Stop() => Console.WriteLine("CD Player stopped");
    }
}
