using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w07.ExtensionMethods
{
    enum MyEnum
    {

    }

    interface IInterface
    {

    }

    public class Complex
    {
        public Complex(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double X { get; set; }
        public double Y { get; set; }


        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.X + c2.X, c1.Y + c2.Y);
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.X - c2.X, c1.Y - c2.Y);
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex(c1.X * c2.X - c1.Y * c2.Y, c1.X * c2.Y + c1.Y * c2.X);
        }

        public static Complex operator /(Complex c1, Complex c2)
        {
            double divisor = c2.X * c2.X + c2.Y * c2.Y;
            return new Complex((c1.X * c2.X + c1.Y * c2.Y) / divisor, (c1.Y * c2.X - c1.X * c2.Y) / divisor);
        }

        public static bool operator == (Complex c1, Complex c2)
        {
            return c1.X == c2.X && c1.Y == c2.Y;
        }

        public static bool operator != (Complex c1, Complex c2)
        {
            return c1.X != c2.X || c1.Y != c2.Y;
        }

        public static implicit operator string (Complex c)
        {
            return $"{c.X}+{c.Y}i";
        }

        public static explicit operator Complex (string s)
        {
            try
            {
                s = s.Trim();
                if (s.StartsWith("(") && s.EndsWith(")"))
                {
                    s = s[1..^1]; // Remove the parentheses
                    var parts = s.Split(',');
                    if (parts.Length == 2)
                    {
                        double real = double.Parse(parts[0].Trim());
                        double imaginary = double.Parse(parts[1].Trim());
                        return new Complex(real, imaginary);
                    }
                }
                throw new FormatException("String is not in the correct format.");
            }
            catch (Exception ex)
            {
                throw new InvalidCastException("Conversion from string to Complex failed.", ex);
            }
        }

        public override string ToString()
        {
            string formatted = "";

            if (X == 0 && Y == 0)
            {
                return $"0";
            }
            if (X == 0 && Y < 0)
            {
                if (Y == -1)
                {
                    return $"-i";
                }

                return $"{Y}i";

            }
            if (X == 0 && Y > 0)
            {
                if (Y == 1)
                {
                    return $"i";
                }

                return $"{Y}i";
            }

            if (X < 0 && Y == 0)
            {
                return $"{X}";
            }
            if (X < 0 && Y < 0)
            {
                if (Y == -1)
                {
                    return $"{X}-i";
                }
                return $"{X}{Y}i";
            }
            if (X < 0 && Y > 0)
            {
                return $"{X}+{Y}i";
            }

            if (X > 0 && Y == 0)
            {
                return $"{X}";
            }
            if (X > 0 && Y < 0)
            {
                if (Y == -1)
                {
                    return $"{X}-i";
                }
                return $"{X}{Y}i";
            }
            if (X > 0 && Y > 0)
            {
                if (Y == 1)
                {
                    return $"{X}+i";
                }
                return $"{X}+{Y}i";
            }

            return formatted;
        }
    }
}
