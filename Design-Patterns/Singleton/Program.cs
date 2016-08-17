using System;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker1 = new Worker("Worker#1");
            var worker2 = new Worker("Worker#2");
            var worker3 = new Worker("Worker#3");
            var worker4 = new Worker("Worker#4");

            var workerThread1 = new Thread(worker1.DoWork);
            var workerThread2 = new Thread(worker2.DoWork);
            var workerThread3 = new Thread(worker3.DoWork);
            var workerThread4 = new Thread(worker4.DoWork);

            workerThread1.Start();
            workerThread2.Start();
            workerThread3.Start();
            workerThread4.Start();

            Console.ReadKey();
        }
    }
}
