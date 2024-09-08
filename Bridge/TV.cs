using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class TV : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("TV is turned on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("TV is turned off.");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"TV volume set to {volume}.");
        }
    }
}
