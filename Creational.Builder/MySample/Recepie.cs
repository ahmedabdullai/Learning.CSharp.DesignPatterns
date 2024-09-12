using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.MySample
{
    internal class Recepie
    {
        private List<string> ingredients = new List<string>();
        
        public Recepie AddIngredient(string ingredient)
        {
            ingredients.Add(ingredient);
            return this;
        }

        private Recepie()
        {
        }

        public void PrintRecepie()
        {
            Console.WriteLine("Recepie:");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine(ingredient);
            }
        }

        public class Builder
        {
            private Recepie recepie = new Recepie();

            public Builder AddIngredient(string ingredient)
            {
                recepie.AddIngredient(ingredient);
                return this;
            }

            public Recepie Build()
            {
                return recepie;
            }
        }
    }
}
