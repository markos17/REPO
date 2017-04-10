using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook
{
    class Dimension
    {
        public void ReturnDimension(int inputShape, out int height, out int width, out int depth)
        {
            height = 1;
            width = 2;
            depth = 3;
            height += width;

        }
    }
}
