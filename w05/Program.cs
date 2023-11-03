//inside/same assembly/
namespace w05
{
    //...
    class Program//same assembly and different/other class
    {
        static void Main1(string[] args)
        {
            A a1 = new A();


            //public
            a1.x2 = 1; // is reachable
            a1.m2();   // is reachable

            //private
            // a1.x1 = 1;//err. is not reachable
            // a1.m1();//err. is not reachable

            //protected
            //a1.x3 = 1;//err. is not reachable
            //a1.m3();//err. is not reachable

            //internal
            a1.x4 = 1;// is reachable
            a1.m4();// is reachable

            //protected internal
            a1.x5 = 1;// is reachable
            a1.m5();// is reachable
        }
    }
    //Encapsulation
    //01-public => can be seen everywhere
    //02-private => can be seen only in classes
    //03-protected => can be seen the members only inside of subclasses, used in derived classes
    //04-internal => can only be seen in same assembly.
    //05-protected internal => can only be seen in same assembly and in subclasses.

    //without keywords => behave like private, sometime behave like internal

    //classes,Interfaces, structs and enums may be internal, public and without keyword
    public class A
    {
        public A()
        {
            //private
            x1 = 5; //within class itself it is reachable
            m1();//within class itself, it is reachable

            //public
            x2 = 5; //within class itself it is reachable
            m2();//within class itself, it is reachable

            //protected
            x3 = 5; //within class itself it is reachable
            m3();//within class itself, it is reachable

            //internal
            x4 = 5; //within class itself it is reachable
            m4();//within class itself, it is reachable

            //protected internal
            x5 = 5; //within class itself it is reachable
            m5();//within class itself, it is reachable
        }

        #region without keywords
        //int x1 = 1;//without keywords
        //void m1()//without keywords
        //{

        //}
        #endregion

        #region 01-Public Members
        public int x2 = 1;//public keywords
        public void m2()//public keywords
        {

        }

        #endregion

        #region 02-Private Members
        private int x1 = 1;
        private void m1()
        {

        }

        #endregion

        #region 03-Protected Members
        protected int x3 = 1;
        protected void m3()
        {

        }

        #endregion

        #region 04-Internal Members
        internal int x4 = 1;
        internal void m4()
        {

        }

        #endregion

        #region 05-Protected + Internal Members
        protected internal int x5 = 1;
        protected internal void m5()
        {

        }

        #endregion
    }

    class B : A//same assembly and other derived/subclass/child class
    {
        public B()
        {
            //public members of A class are reachable
            x2 = 1;
            m2();

            //private members of A class are not reachable
            //x1 = 1; err
            //mb1(); err

            // protected members of A class are reachable
            x3 = 1;
            m3();

            //internal members of A class are reachable
            x4 = 1;
            m4();

            //protected internal members of A class are reachable
            x5 = 1;
            m5();
        }

        private int b1 = 1;
        private void mb1(int x) { }
    }
}

////another namespace/assembly
//namespace w111
//{
//    class Test
//    {
//        Program 
//    }
//    //...
//}

