using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Configuration2
    {
        public string Motherboard { get; }
        public string CPU { get; }
        public string GPU { get; }
        public string RAM { get; }
        public string Storage { get; }
        public string PowerSupply { get; }
        public string Case { get; }
        public string Monitor { get; }
        public string Keyboard { get; }
        public string Mouse { get; }

        private Configuration2(Builder builder)
        {
            Motherboard = builder.Motherboard;
            CPU = builder.CPU;
            GPU = builder.GPU;
            RAM = builder.RAM;
            Storage = builder.Storage;
            PowerSupply = builder.PowerSupply;
            Case = builder.Case;
            Monitor = builder.Monitor;
            Keyboard = builder.Keyboard;
            Mouse = builder.Mouse;
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

        public class Builder
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

            public Builder SetMotherboard(string motherboard)
            {
                Motherboard = motherboard;
                return this;
            }

            public Builder SetCPU(string cpu)
            {
                CPU = cpu;
                return this;
            }

            public Builder SetGPU(string gpu)
            {
                GPU = gpu;
                return this;
            }

            public Builder SetRAM(string ram)
            {
                RAM = ram;
                return this;
            }

            public Builder SetStorage(string storage)
            {
                Storage = storage;
                return this;
            }

            public Builder SetPowerSupply(string powerSupply)
            {
                PowerSupply = powerSupply;
                return this;
            }

            public Builder SetCase(string @case)
            {
                Case = @case;
                return this;
            }

            public Builder SetMonitor(string monitor)
            {
                Monitor = monitor;
                return this;
            }

            public Builder SetKeyboard(string keyboard)
            {
                Keyboard = keyboard;
                return this;
            }

            public Builder SetMouse(string mouse)
            {
                Mouse = mouse;
                return this;
            }

            public Configuration2 Build()
            {
                return new Configuration2(this);
            }
        }
    }
}
