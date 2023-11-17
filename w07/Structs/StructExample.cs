using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w07.Structs
{

    //They are value type
    //they are not class
    //cannot inherit from another struct
    //cannot inherit from a struct
    //cannot inherit from a class
    //cannot be inherited from a class
    //can implement interfaces


    //we need them especially when we are doing performance consuming operation.
    public struct StructExample:ITest
    {
        public StructExample()
        {
            
        }
        public StructExample(int a)
        {

        }
        //may have members
        public int a;
        public static int b = 1;

        public void m1()
        {
            //...
        }



        public void Foo()
        {
            throw new NotImplementedException();
        }
    }

    struct Struct2
    {
        
    }

    class A
    {
    }

    interface ITest
    {
        void Foo();
        
    }
}
