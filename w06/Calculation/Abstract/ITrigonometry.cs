using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w06.Calculation.Abstract
{
    internal interface ITrigonometry
    {
        double Sin(double angle);
        double Cos(double angle);
        double Tan(double angle);
    }
}
