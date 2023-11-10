using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w06.Calculation2.Abstract
{
     //An abstract class in object-oriented programming, particularly in languages like C#, Java, and others, is a special type of class that cannot be instantiated directly. It's used to define a common base structure for other classes to extend from. 
     //abstract classes can be used as Interfaces
    public abstract class BasicMathOperation
    {

        //inside abstract class can be made everything as regular class.

        //in abstract class we have two category of members

        //01-Abstract members
        // Abstract method for addition
        public abstract double Add(double a, double b);
        // Abstract method for subtraction
        public abstract double Subtract(double a, double b);


        //02-Concrete members as regular class
        // Concrete implementation for multiplication
        public virtual double Multiply(double a, double b)
        {
            return a * b;
        }

    }
}
