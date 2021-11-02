using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrationPoC.ErrorHandling
{
    public class _UnauthorizedException : Exception
    {

        public _UnauthorizedException()
        {
        }

        public _UnauthorizedException(string message)
            : base(message)
        {
        }

        public _UnauthorizedException(string message, Exception inner)
            : base(message, inner)
        {
        }

    }
}
