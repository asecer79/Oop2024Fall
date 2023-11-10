using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w06
{
    //polymorphism
    //valid for regular classes
    //valid for abstract classes also
    //valid for interfaces.
    class A
    {
        public virtual void m1()
        {
            Console.WriteLine("A.m1()");
        }
    }

    class B:A
    {
        public override void m1()
        {
            Console.WriteLine("B.m1()");
        }

    }

    class C:A
    {
        public override void m1()
        {
            Console.WriteLine("C.m1()");
        }
    }
}
