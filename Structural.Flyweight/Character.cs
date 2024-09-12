using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Character : ICharacter
    {
        private char _symbol;
        private string _color;

        public Character(char symbol, string color)
        {
            _symbol = symbol;
            _color = color;
        }

        public void Display(int size)
        {
            Console.WriteLine($"Character: {_symbol}, Color: {_color}, Size: {size}");
        }
    }

}
