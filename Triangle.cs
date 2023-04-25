using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_4
{
    internal class Triangle : IShape, IColour
    {
        double total;


        void IShape.calcarea()
        {
            total = (0.5 * 8) * 10;
            Console.WriteLine("The area of the triangle is" + total);

        }
        void IColour.theshape()
        {
            Console.WriteLine("The triangle is blue");

        }

    }
}
