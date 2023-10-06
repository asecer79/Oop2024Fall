using System.Runtime.InteropServices;

namespace w01 //packace, library, coverage code and object location
{
     class Program
    {
        //starting or entry point method/function
        private static int _avAlue = 1;

        static void Main(string[] args)
        {
            //..Aydin
            int b = 1 + 3;
            Console.WriteLine("Hello world!!!");//printf in c



            #region Data Types

            #region Value Types /Primitive Types
            #region Predefined Types

            int a1 = 5;
            float f1 = 5.5f;
            double d1 = 6.5;
            bool b2 = false;
            char c1 = 'a';


            #endregion

            #region User Defined Types

            //structs and enum types:
            //see example 1
            #endregion
            #endregion

            #region Pointer Types - not used so much

            int* p1 = &b;


            #endregion

            #endregion
        }
    }



    //Example 1: User Defined Complex Primitive types/value types
    struct MyData
    {
         int p1 = 1;
         //..

         double d1;
         public MyData()
         {
         }
    }

    enum DayNames
    {
        Monday,
        Tuesday, 
        Wednesday,
        Friday, 
        Sunday,
    }
}







// Tokens:
// 01- keywords
// 02- identifiers, mus be obey the rules of variable definitions
// 03- symbols
// 04- operators
// 05- Literals
//       numerical
//       string



