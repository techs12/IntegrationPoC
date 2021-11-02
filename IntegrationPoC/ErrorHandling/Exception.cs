using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrationPoC.ErrorHandling
{
    public class _Exception : Exception
    {
        public _Exception(string message)
     : base(message)
        {
        }

        public _Exception(string message, Exception inner)
            : base(message, inner)
        {
        }

    }
}

