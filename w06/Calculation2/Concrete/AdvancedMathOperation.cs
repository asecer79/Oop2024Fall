using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using w06.Calculation.Abstract;
using w06.Calculation2.Abstract;

namespace w06.Calculation2.Concrete
{
    internal class AdvancedMathOperation:BasicMathOperation,IBasicMath,ITrigonometry//mixed usage, 1st is inheritance , followings are implementations
    {
        public override double Add(double a, double b)
        {
            throw new NotImplementedException();
        }

        public override double Subtract(double a, double b)
        {
            throw new NotImplementedException();
        }

        // The Multiply method can remain as inherited from the base class
        public double Sin(double angle)
        {
            throw new NotImplementedException();
        }

        public double Cos(double angle)
        {
            throw new NotImplementedException();
        }

        public double Tan(double angle)
        {
            throw new NotImplementedException();
        }

        public int Add(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Subtract(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Multiply(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Divide(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
