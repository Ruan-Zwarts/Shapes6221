using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_4
{
    internal class Square : IShape, IColour
    {
        double total;


        void IShape.calcarea()
        {
            total = (21 * 11) * 30;
            Console.WriteLine("The area of the square is" + total);

        }
        void IColour.theshape()
        {
            Console.WriteLine("The square is blue");

        }

    }
}
