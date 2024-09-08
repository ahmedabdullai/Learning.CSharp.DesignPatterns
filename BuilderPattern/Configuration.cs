using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Configuration
    {
        public string Motherboard { get; private set; }
        public string CPU { get; private set; }
        public string GPU { get; private set; }
        public string RAM { get; private set; }
        public string Storage { get; private set; }
        public string PowerSupply { get; private set; }
        public string Case { get; private set; }
        public string Monitor { get; private set; }
        public string Keyboard { get; private set; }
        public string Mouse { get; private set; }

        public Configuration SetMotherboard(string motherboard)
        {
            Motherboard = motherboard;
            return this;
        }

        public Configuration SetCpu(string cpu)
        {
            CPU = cpu;
            return this;
        }

        public Configuration SetGpu(string gpu)
        {
            GPU = gpu;
            return this;
        }

        public Configuration SetRam(string ram)
        {
            RAM = ram;
            return this;
        }

        public Configuration SetStorage(string storage)
        {
            Storage = storage;
            return this;
        }

        public Configuration SetPowerSupply(string powerSupply)
        {
            PowerSupply = powerSupply;
            return this;
        }

        public Configuration SetCase(string @case)
        {
            Case = @case;
            return this;
        }

        public Configuration SetMonitor(string monitor)
        {
            Monitor = monitor;
            return this;
        }

        public Configuration SetKeyboard(string keyboard)
        {
            Keyboard = keyboard;
            return this;
        }

        public Configuration SetMouse(string mouse)
        {
            Mouse = mouse;
            return this;
        }

        public void PrintConfiguration()
        {
            Console.WriteLine("Motherboard: " + Motherboard);
            Console.WriteLine("CPU: " + CPU);
            Console.WriteLine("GPU: " + GPU);
            Console.WriteLine("RAM: " + RAM);
            Console.WriteLine("Storage: " + Storage);
            Console.WriteLine("Power Supply: " + PowerSupply);
            Console.WriteLine("Case: " + Case);
            Console.WriteLine("Monitor: " + Monitor);
            Console.WriteLine("Keyboard: " + Keyboard);
            Console.WriteLine("Mouse: " + Mouse);
        }

        public Configuration Build()
        {
            return this;
        }
    }
}
