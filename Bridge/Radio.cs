using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Radio : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Radio is turned on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Radio is turned off.");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"Radio volume set to {volume}.");
        }
    }
}