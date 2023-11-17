using System.Threading.Channels;
using w07.ClassTypes;
using w07.ExtensionMethods;

namespace w07
{

    class Program
    {
        static void Main(string[] args)
        {
            //StaticClassExample staticClass = new StaticClassExample(); //error
            /*StaticClassExample.a = 1;
            StaticClassExample.m1();
            SealedExample sealedExample = new SealedExample();
            PartialClassExample _classExample = new PartialClassExample();


            string name = "Aydın SEÇER";
            int aa = 45;

            Console.WriteLine(name.CountEnglishCharacter());
            Console.WriteLine(name.CountNonEnglishCharacter());
            */

            Complex c1 = new Complex(1, 3);// c1 = 1 + i;

            Complex c2 = new Complex(1, 2);// c2 = 1 + 2i;

            Complex sum1 = c1.Add(c2);
            Complex min1 = c1.Minus(c2);
            Complex prod = c1.Product(c2);
            Complex div1 = c1.Divide(c2);
            // Console.WriteLine(c1); // 1 + i



            Complex complex1 = new Complex(0, 0);
            Complex complex2 = new Complex(0, -2);
            Complex complex3 = new Complex(0, 1);
            Complex complex4 = new Complex(-61, 0);
            Complex complex5 = new Complex(-51, -1);
            Complex complex6 = new Complex(-1, 1);
            Complex complex7 = new Complex(1, 0);
            Complex complex8 = new Complex(1, -1);
            Complex complex9 = new Complex(10, 11);

            Console.WriteLine(complex9);
            //Console.WriteLine(complex2);
            //Console.WriteLine(complex3);
            //Console.WriteLine(complex4);
            //Console.WriteLine(complex5);
            //Console.WriteLine(complex6);
            //Console.WriteLine(complex7);
            //Console.WriteLine(complex8);
            //Console.WriteLine(complex9);

            //  Console.WriteLine(complex9
            //    .Add(complex9)
            //    .Product(complex2)
            //    .Divide(complex5)
            //    .Divide(complex4)
            //    .Add(complex4)

            //);

            /*
            var complex = complex5 + complex9;
            Console.WriteLine($"({complex5}) + ({complex9}) = {complex}");

            complex = complex5 - complex9;
            Console.WriteLine($"({complex5}) - ({complex9}) = {complex}");

            complex = complex5 * complex9;
            Console.WriteLine($"({complex5}) x ({complex9}) = {complex}");

            complex = complex5 / complex9;
            Console.WriteLine($"({complex5}) / ({complex9}) = {complex}");

            */

            Complex A = new Complex(5, 9);
            Complex B = new Complex(5, 6);


            //implicit conversion
            string a = B;


            Console.WriteLine(A == B);

            //overloading cast operator
            // Complex C = (Complex)("number operaror imaginary");

            //explicit conversion
            Complex fromString = (Complex)"(1,2)"; // = 1 + 5i ;















        }
    }






}