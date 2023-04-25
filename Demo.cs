using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_4
{
    internal class Demo: IShape,IColour 
    {
        double total;

        
        void IShape.calcarea() 
        {
            total = 6 * 12;
            Console.WriteLine("The area of the rectangle is" + total);
        
        }
        void IColour.theshape()
        {
            Console.WriteLine("The rectangle is blue");

        }



    }
}
