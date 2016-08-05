using System;
using System.Threading;

namespace Singleton
{
    public class Worker
    {
        private readonly string _workerName;

        public Worker(string workerName)
        {
            _workerName = workerName;
        }

        public void DoWork()
        {
            for (var i = 0; i < 10; i++)
            {
                IdentifierMaker instance = IdentifierMaker.GetInstance();
                Thread.Sleep(3000);
                var identifier = instance.GetIdentifier();
                var message = string.Format("{0} getting identifier #{1}", _workerName, identifier);
                Console.WriteLine(message);
            }
        }
    }
}
