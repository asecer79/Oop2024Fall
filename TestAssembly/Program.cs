using w05;
//outside/different assembly
namespace TestAssembly
{
    class Program//outside/different assembly and different class
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            //public
            a1.x2 = 1;// is reachable
            a1.m2();// is reachable

            //private
            // a1.x1 = 1;//err. is not reachable
            // a1.m1();//err. is not reachable

            //protected
            //a1.x3 = 1;//err. is not reachable
            //a1.m3();//err. is not reachable

            //internal
            //a1.x4 = 1;//err. is not reachable
            //a1.m4();//err. is not reachable

            //protected internal
           // a1.x5 = 1;//err. is not reachable
           // a1.m5();//err. is not reachable

        }
    }

    class C : A//outside/different assembly and derived/sub/children class
    {
        public C()
        {
            //public members of A class are reachable
            x2 = 1;
            m2();

            //private members of A class are not reachable
            // x1 = 1;// err
            // m1(); //err

            //protected members of A class are reachable
            x3 = 1;
            m3();

            //internal members of A class are not reachable
            //x4 = 1;// err
            //m4(); //err

            //protected internal members of A class are  reachable
            x5 = 1;
            m5();
        }

        private int c1 = 1;
        private void mc1(int x) { }
    }
}
