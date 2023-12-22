using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w12
{
    //Concurrency is to control(guaranty) everything is ok when they are undergone by any parallel operation.


    public class BankAccountNotThreadSafe //not thread safe
    {

        public BankAccountNotThreadSafe(decimal initialBalance, string accountNumber)
        {
            Balance = initialBalance;
            AccountNumber = accountNumber;
        }

        private string AccountNumber { get; set; }

        private decimal Balance { get; set; }

        public void Withdraw(decimal amount)
        {
            Thread.Sleep(10);
                Balance = Balance - amount; //
        }

        public void Deposit(decimal amount)
        {
            Thread.Sleep(5);
        }

        public decimal GetBalance()
        {
            return Balance;
        }
    }


    public class BankAccountByLock //Concurrent class by lock//thread safe class
    {

        public BankAccountByLock(decimal initialBalance, string accountNumber)
        {
            Balance = initialBalance;
            AccountNumber = accountNumber;
        }

        private string AccountNumber { get; set; }

        private decimal Balance { get; set; }

        private object objToWait="";
        public void Withdraw(decimal amount)
        {
            lock (objToWait)
            {
                //synchronized scope
                Thread.Sleep(10);
                Balance = Balance - amount; //
            }
        }

        public void Deposit(decimal amount)
        {
            lock (objToWait)
            {
                //synchronized scope
                Thread.Sleep(5);
                Balance = Balance + amount;
            }
        }

        public decimal GetBalance()
        {
            return Balance;
        }
    }


    public class BankAccountByMutex //Concurrent class by mutex//thread safe class
    {
        Mutex mutex = new Mutex();

        public BankAccountByMutex(decimal initialBalance, string accountNumber)
        {
            Balance = initialBalance;
            AccountNumber = accountNumber;
        }

        private string AccountNumber { get; set; }

        private decimal Balance { get; set; }

        public void Withdraw(decimal amount)
        {

                //synchronized scope
                mutex.WaitOne();
                Thread.Sleep(10);
                Balance = Balance - amount; //
                mutex.ReleaseMutex();
           
        }

        public void Deposit(decimal amount)
        {
        
                //synchronized scope
                mutex.WaitOne();
                Thread.Sleep(5);
                Balance = Balance + amount;
                mutex.ReleaseMutex();
       
        }

        public decimal GetBalance()
        {
            return Balance;
        }
    }


    public class BankAccountBySemaphore //Concurrent class by semaphore//thread safe class
    {
        private Semaphore _semaphore = new Semaphore(1,1);  //if Semaphore(1,1)=Mutex, Semaphore(2,2) !=Mutex


        public BankAccountBySemaphore(decimal initialBalance, string accountNumber)
        {
            Balance = initialBalance;
            AccountNumber = accountNumber;
        }

        private string AccountNumber { get; set; }

        private decimal Balance { get; set; }

        public void Withdraw(decimal amount)
        {

            //synchronized scope
            _semaphore.WaitOne();
            Thread.Sleep(10);
            Balance = Balance - amount; //
            _semaphore.Release();

        }

        public void Deposit(decimal amount)
        {

            //synchronized scope
            _semaphore.WaitOne();
            Thread.Sleep(5);
            Balance = Balance + amount;
            _semaphore.Release();

        }

        public decimal GetBalance()
        {
            return Balance;
        }
    }
}
