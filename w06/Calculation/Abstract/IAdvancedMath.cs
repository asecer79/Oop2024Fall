using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w06.Calculation.Abstract
{
    internal interface IAdvancedMath
    {
        double Power(double baseNumber, double exponent);
        double SquareRoot(double number);
    }
}
