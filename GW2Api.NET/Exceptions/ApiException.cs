using System;

namespace GW2Api.NET.Exceptions
{
    public class ApiException : Exception
    {
        public ApiException(string msg) : base(msg) { }
    }
}
