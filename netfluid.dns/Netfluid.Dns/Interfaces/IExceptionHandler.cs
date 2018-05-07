using System;

namespace Netfluid.Dns.Interfaces
{
    public interface IExceptionHandler
    {
        void OnError(Exception ex);
    }
}
