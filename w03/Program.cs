namespace w03
{
    #region Control Flows

    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        //Conditional statements
    //        //if

    //        int a = 2;
    //        int b = 3;

    //        if (a > b && a == 2)
    //        {
    //            if (a == 2)
    //            {
    //                if (1 == 1)
    //                {


    //                }
    //            }
    //            //executed
    //        }
    //        else if (b < 6)
    //        {
    //            //executed
    //        }
    //        else
    //        {
    //            //executed
    //        }


    //        //switch
    //        int weekDay = 7; //   1<= ...<=7
    //        switch (weekDay)
    //        {
    //            case 1:
    //                Console.WriteLine("Monday");
    //                //...
    //                break;
    //            case 2:
    //                Console.WriteLine("Tuesday");
    //                //...
    //                break;
    //            case 3:
    //                Console.WriteLine("Wednesday");
    //                break;
    //            case 4:
    //                Console.WriteLine("Thursday");
    //                break;
    //            case 5:
    //                Console.WriteLine("Friday");
    //                break;
    //            case 6:
    //                Console.WriteLine("Saturday");
    //                break;
    //            case 7:
    //                Console.WriteLine("Sunday");
    //                break;
    //            default:
    //                Console.WriteLine("Error");
    //                break;

    //        }

    //        //conditional if
    //        int gender = 1;
    //        var res = (gender == 0) ? "Lady" : "Man";
    //        //if (gender==0)
    //        //{
    //        //    res = "Lady";
    //        //}
    //        //else
    //        //{
    //        //    res = "Man";
    //        //}


    //        //Loops/Iterations/repetition

    //        //01-for loop
    //        for (int i = 0; i < 2; i++)
    //        {
    //            //operations...
    //            Console.WriteLine(i);
    //        }

    //        //02-while loop
    //        int ni = 1;
    //        while (ni <= 5)
    //        {
    //            //operations...
    //            ni++;
    //        }

    //        //03-do while loop
    //        ni = 1;
    //        do
    //        {
    //            //operations...
    //            ni++;

    //        } while (ni <= 1);


    //        //04-foreach loop
    //        int[] arr = { 1, 2, 3, 59, 65 };
    //        foreach (var item in arr)  //foreach uses iterators of collections
    //        {
    //            Console.WriteLine(item);
    //        }
    //        //for (int i = 0; i < arr.Length; i++)
    //        //{
    //        //    Console.WriteLine(arr[i]);
    //        //}



    //        //05-go to loop
    //        int gt = 1;
    //    comeHereP1: //labeled loop
    //        Console.WriteLine(gt);
    //        gt++;
    //        if (gt <= 5)
    //            goto comeHereP1;

    //        //for (int i = 1; i <= 5; i++)
    //        //{
    //        //    Console.WriteLine(i);
    //        //}


    //        //06-recursive functions as a loop

    //        Console.WriteLine(Sum(10));
    //        int n = 10;
    //        int sum = 0;
    //        for (int i = 1; i <= ni; i++)
    //        {
    //            sum += i;
    //        }


    //        //07-Infinite loops

    //        //for (; ; )
    //        //{
    //        //    if (messageRecevided == true)
    //        //        break;

    //        //    Console.WriteLine("infinite times, will be executed");
    //        //}

    //        //while (true)
    //        //{
    //        //    if (messageRecevided == true)
    //        //        break;
    //        //    Console.WriteLine("infinite times, will be executed");
    //        //}

    //        for (int i = 0; i < 2; i++)
    //        {
    //            for (int j = 0; j < 5; j++)
    //            {
    //                break; //continue
    //            }

    //            for (int j = 0; j < 5; j++)
    //            {
    //                break; //continue
    //            }

    //            break;//continue
    //        }

    //    }

    //    static int Sum(int n) // 1 + 2 + ....+ n = ?...
    //    {
    //        if (n == 1)
    //            return 1;

    //        return n + Sum(n - 1);
    //    }


    //}

    #endregion

    #region String

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int a = 5; //value type / mutable
    //        a = 6;

    //        Object b = 1; //reference type/ mutable
    //        b = "Aydın";

    //        string c = "Aydın"; // reference type / Immutable

    //        //c[1] = 'b'; err
    //        //c = "Abdın";

    //        c = "Memnune";


    //        //string interpolation
    //        var v = a + " : " + b + c;
    //        Console.WriteLine(v);

    //        v = $"{a} : {b}{c}"; //interpolator $
    //        Console.WriteLine(v);

    //    }
    //}

    #endregion


    #region Method Definition
    class Program
    {
        static void Main(string[] args)
        {
            //Method1();//err
            //Method1(5); //err
            Method1(5, 6);//must be provided its params

            Method2();//optional
            Method2(5);//optional
            Method2(5, 6);//optional

            //Method3();//err
            // Method3(5);//err
            Method3(5, 6);//hybrid call
            Method3(5, 6, 7);//hybrid call

            //named param calls //if method has many more parameters
            Method1(x: 1, y: 2);
            Method1(y: 2, x: 1);
            Method3(z: 1, x: 2, y: 3);
            Method3(z: 1, y: 3);


            //
            //overloaded methods call
            DoJob();
            DoJob(5);
            DoJob(5,"aydın");
        }

        //method overloading, key part is signature
        static void DoJob()
        {
            //code lines
        }

        static void DoJob(int a)
        {
            //code lines
        }

        static void DoJob(int a,string b)
        {
            //code lines
        }

        static void DoJob(string b, int a)
        {
            //code lines
        }



        //parameters
        //mandatory params
        static void Method1(int x, int y)
        {
            //do some jobs...
        }

        //optional params
        static void Method2(int x = 0, int y = 0)
        {
            //do some jobs...
        }

        //hybrid params/some of mandatory, some of optional
        static void Method3(int y, int z, int x = 0)
        {
            //do some jobs...
        }







        //Methods with their signature and return type
        //01- void void => no return type and no params
        static void M1()
        {
            //do operations here.
            //no need a return keyword.
        }

        //02- void params => no return type and with params
        static void M2(int a, string b, bool c)
        {
            //do operations here.
            //no need a return keyword.
        }

        //03- type void => has return type and without params
        static int M3()
        {
            //do operations here.
            //must have a return keyword.
            return 1 + 6;
        }

        //04- type type => has return type and with params
        static int M4(int a, int b)
        {
            //do operations here.
            //must have a return keyword.
            return 1 + 6;
        }



    }




    #endregion



}


