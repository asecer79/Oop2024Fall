
using System.Runtime.InteropServices.JavaScript;

namespace w02
{
    #region Part 1

    /*

    //0-Scope Level overall assembly scope
    //can be defined classes, Interfaces, Enums, Structs
    //cannot be defined variables, methods of any kind.



    class Program
    {


        //1-Global scope Level
        //can be defined inner classes, methods, variables


        readonly int _count = 1; //almost similar with const but it may be changed only one time.
        // in java look like fixed keyword
        public Program()
        {
            _count = 15;
            //  _count = 16; is impossible because readonly can be assigned once. 
        }

        //3-Formal scope level
        static void Main(string[] args )
        {
            //2-Local Scope - Level
            //cannot be defined classes, Interfaces, enums, structs
            //any kind of variable, methods, bot not recommended, we use especially here, the methods as lambda functions/anonymous methods .



            var test = new Program();


            //variable definition

            //standard (strongly type) variable definition /evaluated in compile/interpration time
            int a = 5;
            // a = "Aydın"; //error, impossible because, a is not dynamic

            string name = "Aydın";
            bool b = false;
            //definition of var keyword /evaluated in compile/interpration time
            var a1 = 1;
            //a1 = "Aydın"; //error, impossible because, a is not dynamic
            var name2 = "Aydın";
            var b1 = true;



            //dynamic keyword (javascript, python and some other langs are fully dynamic lang.)
            // a = 5; name = "name";
            //C# is not dynamic programming language but supports dynamic object definition.
            dynamic a3 = 1;//evaluated in runtime
            a3 = "Aydın";
            a3 = true;



            //constant keyword
            const int ac = 15;
            //ac = 3; cannot be changed, cannot be null





            //overflow
            //lef size (bytes)   >=  right size (bytes)
            // int a11 = 1351354135413543154313543153431543153;



            //comments //single line comment

            /  * block comment
            
            bool bl = false;
            int cl = 1;
           
            *  /



        }
    }  */

    #endregion

    #region Part 2

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        /*
    //        //input and output
    //        int a = Convert.ToInt32(Console.ReadLine()); //scanf in C
    //        Console.WriteLine(a*a);  //printf in C
    //        */

    //        //implicit type conversion
    //        int a = 12;
    //        double b = a;

    //        //leftsize>=rightsize
    //        long c = a;
    //        c = 1254165465145646541;


    //        //explicit type conversion;

    //        //cast operations
    //        a = (int)c; //we may get overflow problem
    //        Console.WriteLine(a);


    //        decimal d = 12345678901234567891;
    //        //c = (long)d;  //err overflow 
    //        Console.WriteLine(c);



    //        //operators
    //        //01-Arithmetic ops  + - / *  % ----------->  produces numbers/return numbers
    //        var res = 1 + 5 * 9 + 1.5/2;

    //        //02-relational <, <=, >, >=, ==, !=      ----------->  produces boolean/return true or false
    //        var ro = 1 < 2; //--->true
    //        ro = 3 >= 5;
    //        ro = 1 == 1;
    //        ro = 1 != 3;

    //        //03-logical &&, ||, !      ----------->  produces boolean/return true or false
    //        ro = !((1 == 1) && (1<3) || (5>=100));


    //        //04-bitwise &, |, ~      ----------->  not used frequently


    //        //05-Assignment  =, +=, -=, *=, /=, %=     ----------->  

    //        res = 2;
    //        res += 2;  //res = res+2;
    //        res -= 2;  //res = res-2;
    //        res *= 2;  //res = res*2;
    //        res /= 2;  //res = res/2;


    //        //05-unary ops  ++, --, !     ----------->  used in numeric ops
    //        ++res;
    //        res++;
    //        --res;
    //        res--;

    //        bool bl = !false; //--> true

    //        //binary ops    operand1 operator  operand2 --> 1 + 2;
    //        //unary ops     operand operator,   operator operand1 --->  ++res, res++,  !bl,
    //        //ternary op : conditional if

    //        //05-ternary ops  ? :     -----------> returns any type of data

    //        var ahmetIsGood = true;
    //        var resText = (ahmetIsGood == true) ? "Ahmet is good" : "Ahmet is not good";
    //        Console.WriteLine(resText);

    //        //if (ahmetIsGood)
    //        //{
    //        //    Console.WriteLine("Ahmet is good");
    //        //}
    //        //else
    //        //{
    //        //    Console.WriteLine("Ahmet is not good");
    //        //}

    //        var res2 = 1 == 2 ? -1 : 0;





    //    }
    //}

    #endregion

    #region Part 3

    class Program
    {
        static void Main(string[] args)
        {
            int a = 45;

            Console.WriteLine(sizeof(int));

            Type t = typeof(int);

            Console.WriteLine(t == typeof(int));



            //arrays

            char[] name = { 'a', 'y', 'd', 'ı', 'n' };

            Console.WriteLine(name);



        }
    }

    #endregion
};


