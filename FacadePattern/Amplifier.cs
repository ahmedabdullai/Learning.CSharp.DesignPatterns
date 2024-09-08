using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Amplifier
    {
        public void On() => Console.WriteLine("Amplifier is on");
        public void Off() => Console.WriteLine("Amplifier is off");
        public void SetVolume(int level) => Console.WriteLine($"Amplifier volume set to {level}");
    }
}
