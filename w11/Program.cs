namespace w11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program starts");

            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " Main Thread"); //main thread, process default thread
            Thread.Sleep(1000);//gives delay

            Thread th1 = new Thread(DoWork1Long);
            th1.Name = "th1";

            Thread th2 = new Thread(DoWork2Long);
            th2.Name = "th2";

            Thread th3 = new Thread(DoWork3Short);

            th3.Name = "th3";

            th1.Start();
            th1.IsBackground = true;

            th2.Start();
            th2.IsBackground = true;

            th3.Start();
            th3.IsBackground = true;
            //th1.Join();
            //th2.Join();
            //th3.Join();


            Console.WriteLine("Program ends");

          //  Console.ReadLine();

        }


        static void DoWork1Long()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " :" + Thread.CurrentThread.Name); //another user defined thread

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(new Random().Next(0, 1000));
                Console.WriteLine("Work AAAAA-Long");
            }
        }

        static void DoWork2Long()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " :" + Thread.CurrentThread.Name); //another user defined thread
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(new Random().Next(0, 1000));
                Console.WriteLine("Work BBBBB-Long");
            }
        }

        static void DoWork3Short()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " :" + Thread.CurrentThread.Name); //another user defined thread
            for (int i = 0; i < 2; i++)
            {
                Thread.Sleep(new Random().Next(0, 1000));
                Console.WriteLine("Work CCCCC-Short");
            }
        }
    }
}

