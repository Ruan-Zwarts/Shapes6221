using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_4
{
    interface IShape 
    {
        void calcarea();
    }

    interface IColour
    {
        void theshape();
    }


    internal class Program
    {
        
        static void Main(string[] args)
        {

                Demo demoObj = new Demo();
                ((IShape)demoObj).calcarea();
                ((IColour)demoObj).theshape();
            
                
            Demo TriObj = new Demo();
            ((IShape)TriObj).calcarea();
            ((IColour)TriObj).theshape();
            

            Demo recObj = new Demo();
            ((IShape)recObj).calcarea();
            ((IColour)recObj).theshape();

            Demo cirObj = new Demo();
            ((IShape)cirObj).calcarea();
            ((IColour)cirObj).theshape();

            Demo sqrObj = new Demo();
            ((IShape)sqrObj).calcarea();
            ((IColour)sqrObj).theshape();

            Console.ReadKey();

        }
    }
}
