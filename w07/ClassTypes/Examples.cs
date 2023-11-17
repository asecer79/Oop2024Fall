using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w07.ClassTypes
{
    //Class Types

    //01-Regular Class
    //can be created by new keyword
    //can be inherited by another class
    class RegularClassExample
    {
        public int a = 1;
        public static int b;
        public void m(int x) { }

        //other members



    }

    //02-Abstract Class
    //cannot be created by new keyword
    //can be inherited by another class
    //may contain abstract members without body.
    //can behave like interfaces
    abstract class AbstractClassExample
    {
        int a = 1;
        public static int b;
        public void m(int x)
        {
            //concrete body
        }
        public abstract void p(int x);
    }

    //03-Static Class
    //can contain only static members
    //cannot be created by new keyword
    //cannot be inherited by other static or non-static classes
    //cannot inherit any other regular or static classes
    //impossible for implementation through interfaces
    static class StaticClassExample
    {
        public static int a = 1;
        public static void m1()
        {
            //....
        }
    }
    interface ITest
    {
        void M();
    }

    //04-Sealed Class
    //can be created by new keyword
    //can not be inherited by another class
    //the other pasts are the same with regular class
    sealed class SealedExample
    {
        public int a = 1;
        public static int b;
        public void m(int x) { }
        //other members
    }


    //05-partial classes
    //same with regular class
    //can be splitted in different parts with the same name using partial keyword. 
    public partial class PartialClassExample
    {
        //scope 1

        public int a = 1;
        public static int b;
        public void m(int x) { }


        //other members
    }
    public partial class PartialClassExample
    {
        //scope 2 = Scope 1

        public int a2 = 1;
        public static int b2n;
        public void m2(int x) { }

        public int a3 = 1;
        public static int b3;
        public void m3(int x) { }

        //other members
    }
    public partial class PartialClassExample
    {
        //scope 3 = Scope 2 = Scope 1

        //other members


        //other members
    }
}
