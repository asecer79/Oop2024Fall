

namespace w10
{

    class Program
    {
        //method pointer for appropriate signature of methods.

        public delegate void MyDelegate();

        public delegate int MathOperation(int x, int y);

        public delegate T MathGlobalOperation<T>(T x, T y); //generic delegate

        static void Main(string[] args)
        {
            //MyDelegate methods = MethodOne; //callback assignment
            //methods += MethodTwo;//binding callback method to delegate

            //methods();

            ////FIRST USAGE
            //MathOperation toplama = Add;
            //MathOperation cikarma = Subtract;
            //MathOperation carpma = Multiply;
            //MathOperation bolme = Divide;

            //Console.WriteLine(toplama(1,2));
            //Console.WriteLine(cikarma(1, 2));
            //Console.WriteLine(carpma(1, 2));
            //Console.WriteLine(bolme(10, 2));

            ////SECOND USAGE //MULTICAST DELEGATES
            //MathOperation mathOperations = Add;
            //mathOperations += Subtract;  //+=  binding event or delegate
            //mathOperations += Multiply;//binding
            //mathOperations += Divide;//binding
            //mathOperations -= Subtract; //unbinding op



            //mathOperations(3, 1);


            //SelectOperation(50,5,Multiply);
            //MathOperation m1 = Divide;
            //SelectOperation(50, 5, m1);
            //Console.WriteLine(GetOp(1)(60,12));

            // MathOperation m1 = Multiply;
            //// m1(1.1f, 2); //err

            ////generic delegate callback assignment
            // MathGlobalOperation<double> m2 = Multiply;
            // Console.WriteLine(m2(1.1f, 2));

            //Action type delegate/ with no input and no output
            //Action myAction = () =>
            //{
            //    //method body
            //};//lambda expression (=>)
            //Action myPrint = () =>
            //{
            //    Console.WriteLine("Anythging");
            //};

            //myPrint();

            ////Action type generic delegate/ with input and no output
            //Action<int, int> add = (x, y) =>
            //{
            //    Console.WriteLine(x + y);
            //};

            //add(1, 2);

            //Action<int, int> add2 = Topla;

            //Func generic delegate//with input param, and return output

            //Func<inputs..., output> 

            //Func<int, int, int> add3 = Add;

            //add3 += Divide;//multicast

            //Func<double, double, double> add4 = Add;

            //Func<int> f1 = () => 5;//simple lambda exp. //directly return any value in a single line, don't need return keyword

            //Func<int> f2 = () => //complex lambda exp.
            //{
            //    //elaborate ops.
            //    return 5;
            //};

            //Console.WriteLine(AdvancedMath<int>(Add, 2, 3));

            //Console.WriteLine(AdvancedMath<double>(Add, 2.3, 3));

            //Console.WriteLine(AdvancedMath(
            //    (int x, int y) =>
            //    {
            //        return x * y + 2;


            //    }, 10, 5));

            //Console.WriteLine(AdvancedMath((int x, int y) => {return x + y * 2 + 4; }, 10, 5));

            //Console.WriteLine(AdvancedMath((double x, double y) => { return x + y / 2 + 4; }, 10, 53));


            DatabaseHelper databaseHelper = new DatabaseHelper();
            //...some other ops.
            databaseHelper.BackupStarted += DatabaseHelper_BackupStarted;
            databaseHelper.BackupCompleted += DatabaseHelperOnBackupCompleted; //event binding/ subscribe
            databaseHelper.BackupCompleted += DatabaseHelperOnBackupCompleted2; //event binding/ subscribe
                                                                                //DatabaseHelperOnBackupCompleted = handler method, event handler method, callback, delegate
            databaseHelper.DatabaseShutDownCompleted += DatabaseHelper_DatabaseShutDownCompleted; ;

            databaseHelper.StartBackup();
            //backup 12.00
            databaseHelper.GetBackup();
            //....
            //15.00
            databaseHelper.GetBackup();

            databaseHelper.ShutDown();

        }

        private static void DatabaseHelper_DatabaseShutDownCompleted()
        {
            Console.WriteLine("Database Shut down completed, notification SMS has been sent to the Administrator");
        }

        private static void DatabaseHelper_BackupStarted()
        {
            Console.WriteLine("Database back up started, notification SMS has been sent to the Administrator");
        }

        private static void DatabaseHelperOnBackupCompleted2()
        {
            //this is subscription method and whenever event triggered, this method handler will be executed.
            //..extra ops......

            Console.WriteLine("Database backed up, notification SMS has been sent to the Administrator");
        }

        private static void DatabaseHelperOnBackupCompleted()
        {
            //this is subscription method and whenever event triggered, this method handler will be executed.
            //..extra ops......

            Console.WriteLine("Database backed up, notification email has been sent to the Administrator");
        }

        //generic method with generic input method
        static T AdvancedMath<T>(Func<T, T, T> f, T x, T y)
        {
            return f(x, y);
        }



        static void Topla(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        //THIRD USAGE
        static void SelectOperation(int x, int y, MathOperation op)//callback parameter
        {
            Console.WriteLine(op(x, y));
        }

        //FOURTH USAGE
        //callback return
        static MathOperation GetOp(int op)
        {
            if (op == 1)
            {
                return Add;
            }
            if (op == 2)
            {
                return Subtract;
            }

            if (op == 3)
            {
                return Multiply;
            }

            return Divide;
        }


        static int Add(int x, int y)
        {
            return x + y;
        }
        static int Subtract(int x, int y)
        {
            return x - y;
        }
        static int Multiply(int x, int y)
        {
            return x * y;
        }
        static int Divide(int x, int y)
        {
            if (y != 0)
                return x / y;
            else
            {
                Console.WriteLine("Division by 0 exception");
                return 0;
            }
        }
        static double Add(double x, double y)
        {
            return x + y;
        }
        static double Subtract(double x, double y)
        {
            return x - y;
        }
        static double Multiply(double x, double y)
        {
            return x * y;
        }
        static double Divide(double x, double y)
        {
            if (y != 0)
                return x / y;
            else
            {
                Console.WriteLine("Division by 0 exception");
                return 0;
            }
        }

        public static void MethodOne()
        {
            Console.WriteLine("MethodOne called.");
        }

        public static void MethodTwo()
        {
            Console.WriteLine("MethodTwo called.");
        }




    }


}

