using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using w06.Calculation.Abstract;

namespace w06.Calculation.Concrete
{
    internal class MathOperation:IBasicMath,ITrigonometry,IAdvancedMath  //multiple implementations by interfaces
    {
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

        public double Power(double baseNumber, double exponent)
        {
            throw new NotImplementedException();
        }

        public double SquareRoot(double number)
        {
            throw new NotImplementedException();
        }
    }

    internal class MathOperation2:IAllInOneMath
    {
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

        public double Power(double baseNumber, double exponent)
        {
            throw new NotImplementedException();
        }

        public double SquareRoot(double number)
        {
            throw new NotImplementedException();
        }

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
    }
}
