using System;
using System.Threading;

namespace Singleton
{
    internal sealed class IdentifierMaker
    {
        private static readonly Lazy<IdentifierMaker> Instance = new Lazy<IdentifierMaker>(
                                                                         () => new IdentifierMaker());

        private int _lastIdentifier;

        private IdentifierMaker()
        {
           _lastIdentifier = 0;
        }

        public static IdentifierMaker GetInstance()
        {
            return Instance.Value;
        }

        public int GetIdentifier()
        {
            return Interlocked.Increment(ref _lastIdentifier);
        }
    }
}
