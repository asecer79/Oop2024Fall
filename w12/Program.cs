
namespace w12
{
    class Program
    {
        static void Main(string[] args)
        {
            //ThreadPool.SetMinThreads(1, 2);
            //ThreadPool.SetMaxThreads(20, 4);
            ////....
            //for (int i = 0; i < 10; i++)
            //{
            //    ThreadPool.QueueUserWorkItem(Download!, i);
            //}



            //Console.ReadLine();



            //BankAccountNotThreadSafe account = new BankAccountNotThreadSafe(1000, "TR161561651616516516156");
            //BankAccountByLock account = new BankAccountByLock(1000,"TR161561651616516516156");
            //BankAccountByMutex account = new BankAccountByMutex(1000, "TR161561651616516516156");
           // BankAccountBySemaphore account = new BankAccountBySemaphore(1000, "TR161561651616516516156");

           // Console.WriteLine($"Initial balance: {account.GetBalance()} TL");

            //for (int i = 0; i < 100; i++) //transaction amount
            //{
            //    //parallel execution
            //    Thread th1 = new Thread(() =>
            //    {
            //        account.Deposit(100);
            //    });
            //    th1.Start();

            //    //parallel execution
            //    Thread th2 = new Thread(() =>
            //    {
            //        account.Withdraw(100);
            //    });
            //    th2.Start();
            //}

            //Thread.Sleep(15000);

            //Console.WriteLine($"Latest balance: {account.GetBalance()} TL" );



           

          //var task1= Task.Run(() =>
          //  {
          //      for (int i = 0; i < 100; i++)
          //      {
          //          Thread.Sleep(20);
          //          Console.WriteLine("Task1");
          //      }
          //  });


          //  var task2 = Task.Run(() =>
          //  {
          //      for (int i = 0; i < 100; i++)
          //      {
          //          Task.Delay(10);
          //          Console.WriteLine("Task2");
          //      }
          //  });


          //  Task.WaitAll(task2, task1);


          Parallel.For(1, 100, i =>
          {
              //....  each line of this scope executed as parallel.
              Task1(i);
              Task2(i);

          });

            Console.WriteLine("Finished");

          //  Console.ReadLine();

        }

        static void Task1(int i)
        {
            Thread.Sleep(100);
            Console.WriteLine("Task1 "+i);
        }

        static void Task2(int i)
        {
            Thread.Sleep(500);
            Console.WriteLine("Task2 " + i);
        }


        static void Download(object url)
        {
            Console.WriteLine($"{url}  - file downloaded");
            Thread.Sleep(2000);
        }


    }
}

