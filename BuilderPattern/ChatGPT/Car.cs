using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.ChatGPT
{
    internal class Car
    {
        // Properties of the Car
        public string Make { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public string Color { get; private set; }
        public string Engine { get; private set; }

        // Private constructor to enforce the use of the Builder
        private Car() { }

        // Builder class inside Car class
        public class Builder
        {
            private Car _car = new Car();

            public Builder SetMake(string make)
            {
                _car.Make = make;
                return this;
            }

            public Builder SetModel(string model)
            {
                _car.Model = model;
                return this;
            }

            public Builder SetYear(int year)
            {
                _car.Year = year;
                return this;
            }

            public Builder SetColor(string color)
            {
                _car.Color = color;
                return this;
            }

            public Builder SetEngine(string engine)
            {
                _car.Engine = engine;
                return this;
            }

            // Builds the Car object and returns it
            public Car Build()
            {
                return _car;
            }
        }
    }
}
