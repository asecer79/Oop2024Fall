using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using w06.Calculation2.Abstract;

namespace w06.Calculation2.Concrete
{
    internal class SimpleMathOperations:BasicMathOperation  //inheritance
    {
        public override double Add(double a, double b)
        {
            //...
            return a + b;
        }

        public override double Subtract(double a, double b)
        {

            return a - b;
        }
    }
}
