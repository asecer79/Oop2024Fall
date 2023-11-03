using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w05
{
    class Program2
    {
        static void Main(string[] args)
        {

        }
    }


    class AA
    {
        //without access modifiers
        int a0 = 1;
        void m0(int x) { }

        //private members
        private int a1 = 1;
        private void m1(int x) { }

        //public members
        public int a2 = 1;
        public void m2(int x) { }

        //protected members
        protected int a3 = 1;
        protected void m3(int x) { }

        //internal members
        internal int a4 = 1;
        internal void m4(int x) { }

        //protected internal members
        protected internal int a5 = 1;
        protected internal void m5(int x) { }
    }

    //class derived/subclass/child : baseclass/superclass/parentclass (in java  : => extends)
    class SubAA : AA //single inheritance
    {
        public SubAA()
        {
            // a0 = 1;//err cannot be inherited, without keyword
            // a1 = 1;//err cannot be inherited, private  

            #region Inherited members from AA (base class)
            //public
            a2 = 1;
            m2(1);

            //protected
            a3 = 1;
            m3(1);

            //internal
            a4 = 1;
            m4(1);

            //protected internal
            a5 = 1;
            m5(1);
            #endregion
        }

        //without access modifiers
        int sub_a0 = 1;
        void sub_m0(int x) { }

        //private members
        private int sub_a1 = 1;
        private void sub_m1(int x) { }

        //private members
        public int sub_a2 = 1;
        public void sub_m2(int x) { }

        //protected members
        protected int sub_a3 = 1;
        protected void sub_m3(int x) { }

        //internal members
        internal int sub_a4 = 1;
        internal void sub_m4(int x) { }

        //protected internal members
        protected internal int sub_a5 = 1;
        protected internal void sub_m5(int x) { }
    }

    //SubAA and SubBB called as siblings classes, AA here called as base class
    class SubBB : AA //single inheritance
    {
        public SubBB()
        {
            // a0 = 1;//err cannot be inherited, without keyword
            // a1 = 1;//err cannot be inherited, private  

            #region Inherited members from AA (base class)
            //public
            a2 = 1;
            m2(1);

            //protected
            a3 = 1;
            m3(1);

            //internal
            a4 = 1;
            m4(1);

            //protected internal
            a5 = 1;
            m5(1);
            #endregion
        }

        //without access modifiers
        int sub_b0 = 1;
        void sub_bm0(int x) { }

        //private members
        private int sub_b1 = 1;
        private void sub_bm1(int x) { }

        //private members
        public int sub_b2 = 1;
        public void sub_bm2(int x) { }

        //protected members
        protected int sub_b3 = 1;
        protected void sub_bm3(int x) { }

        //internal members
        internal int sub_b4 = 1;
        internal void sub_bm4(int x) { }

        //protected internal members
        protected internal int sub_b5 = 1;
        protected internal void sub_bm5(int x) { }
    }

    //SubCC is also descendant class of AA
    //SubCC is subclass/derived class of SubAA/ SubAA is subclass/derived class of AA
    class SubCC : SubAA
    {
        public SubCC()
        {
            // a0 = 1;//err cannot be inherited, without keyword
            // a1 = 1;//err cannot be inherited, private  

            #region Inherited members from AA and SubAA (base class)
            //public
            a2 = 1;
            m2(1);

            //protected
            a3 = 1;
            m3(1);

            //internal
            a4 = 1;
            m4(1);

            //protected internal
            a5 = 1;
            m5(1);
            #endregion
        }
    }

}
