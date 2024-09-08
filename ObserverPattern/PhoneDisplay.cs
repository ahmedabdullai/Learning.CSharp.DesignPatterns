﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class PhoneDisplay : IObserver
    {
        private string _name;

        public PhoneDisplay(string name)
        {
            _name = name;
        }

        public void Update(float temperature)
        {
            Console.WriteLine($"{_name} display updated: Current Temperature = {temperature}°C");
        }
    }
}
