using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class RectangleAdapter : IShape
    {
        private readonly Rectangle _rectangle;

        public RectangleAdapter(Rectangle rectangle)
        {
            _rectangle = rectangle;
        }

        public void Draw()
        {
            _rectangle.DrawRectangle(); // Adapt the method
        }
    }

}
