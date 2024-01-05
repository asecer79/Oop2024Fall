namespace w13
{
    //Concurrency

    class Program
    {
        static async Task Main(string[] args)
        {
            var cancellationTokenSource = new CancellationTokenSource();
            var token = cancellationTokenSource.Token;

            var task = DoSomethingAsync(token);

            // Simulate some other work
            Thread.Sleep(2000);

            // Request cancellation
            cancellationTokenSource.Cancel();

            try
            {
                // Wait for the task to complete
                await task;
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Operation was cancelled.");
            }
        }

        static async Task DoSomethingAsync(CancellationToken cancellationToken)
        {
            // Simulate a task that takes a while to complete
            for (int i = 0; i < 10; i++)
            {
                // Check if cancellation was requested
                cancellationToken.ThrowIfCancellationRequested();

                // Simulate work
                Console.WriteLine($"Working... {i}");
                await Task.Delay(1000); // Waiting for 1 second

                // Alternatively, you can pass the cancellationToken to the Delay method
                // await Task.Delay(1000, cancellationToken);
            }
        }
    }
    //class Program
        //{
        //    static async Task Main(string[] args)
        //    {
        //        //Console.WriteLine("Start-- ThreadId:" + Thread.CurrentThread.ManagedThreadId);

        //        //await M1("M1");
        //        //await M1("M2");
        //        //await M1("M3");

        //        ////Thread th = new Thread(M1);
        //        ////Thread th2 = new Thread(M1);
        //        ////th.Start();
        //        ////th2.Start();

        //        //Console.WriteLine("End-- ThreadId:" + Thread.CurrentThread.ManagedThreadId);



        //         SendMoney();
        //         SendSms();

        //        Console.ReadLine();
        //    }


        //    static async Task M1(string s)
        //    {
        //        await Task.Run(() =>
        //         {
        //             for (int i = 0; i < 10; i++)
        //             {
        //                 Console.WriteLine($"{s}-- ThreadId:" + Thread.CurrentThread.ManagedThreadId);
        //                 Thread.Sleep(500);
        //             }
        //         });

        //    }


        //    //signalization

        //    static AutoResetEvent _operationSignal = new AutoResetEvent(false);


        //    static async Task<bool> SendMoney()
        //    {
        //        await Task.Run(() =>
        //        {

        //            _operationSignal.Reset();

        //            //.....
        //            Console.WriteLine("1-Money withdrawn from account OK, waiting security check!"); //
        //            Console.WriteLine("2-Security check sms sent to the owner OK");

        //            _operationSignal.WaitOne();


        //            //******
        //            Console.WriteLine("5-Money sent to another account is OK");

        //            //
        //            Console.WriteLine("6-Confirmation sms has been sent to the both client.");

        //        });


        //        return true;
        //    }

        //    static async Task<bool> SendSms()
        //    {
        //        await Task.Run(() =>
        //        {
        //            Thread.Sleep(5000);

        //            //.....
        //            Console.WriteLine("3-Security check sms has been sent to the owner. Response awaiting!");
        //            Thread.Sleep(2000);
        //            Console.WriteLine("4-Verification OK!");

        //            _operationSignal.Set();

        //        });


        //        return true;
        //    }
        //}
    }

