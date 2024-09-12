using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    // Third-party class with a different interface
    public class Rectangle
    {
        public void DrawRectangle()
        {
            Console.WriteLine("Drawing a Rectangle.");
        }
    }

}
