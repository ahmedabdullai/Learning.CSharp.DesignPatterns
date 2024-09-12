using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class CharacterFactory
    {
        private Dictionary<string, ICharacter> _characters = new Dictionary<string, ICharacter>();

        public ICharacter GetCharacter(char symbol, string color)
        {
            string key = symbol + color;

            if (!_characters.ContainsKey(key))
            {
                _characters[key] = new Character(symbol, color);
            }

            return _characters[key];
        }
    }

}
