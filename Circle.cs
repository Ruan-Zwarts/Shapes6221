using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_4
{
    internal class Circle : IShape, IColour
    {
            double total;


            void IShape.calcarea()
            {
                total = 3.14 * 10;
                Console.WriteLine("The area of the circle is" + total);

            }
            void IColour.theshape()
            {
                Console.WriteLine("The circle is brown");

            }
        }

    }

