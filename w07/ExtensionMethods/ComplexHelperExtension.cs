using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace w07.ExtensionMethods
{
    public static class ComplexHelperExtension
    {
        //Add
        //Minus
        //Product
        //Divide

        public static Complex Add(this Complex c1, Complex c2)
        {
            //a + bi + c + di = (a+c) + (b+d)i
            return new Complex(c1.X + c2.X, c1.Y + c2.Y);
        }

        public static Complex Minus(this Complex c1, Complex c2)
        {
            //a + bi - (c + di) = (a+c) - (b+d)i
            return new Complex(c1.X - c2.X, c1.Y - c2.Y);
        }

        public static Complex Product(this Complex c1, Complex c2)
        {
            //formula from your courses
            double realPart = c1.X * c2.X - c1.Y * c2.Y;
            double imaginaryPart = c1.X * c2.Y + c1.Y * c2.X;
            return new Complex(realPart, imaginaryPart);
        }

        public static Complex Divide(this Complex c1, Complex c2)
        {
            //formula from your courses
            double divisor = c2.X * c2.X + c2.Y * c2.Y;
            double realPart = (c1.X * c2.X + c1.Y * c2.Y) / divisor;
            double imaginaryPart = (c1.Y * c2.X - c1.X * c2.Y) / divisor;
            return new Complex(realPart, imaginaryPart);
        }


       
    }
}
