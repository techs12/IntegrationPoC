using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrationPoC.ErrorHandling
{
    public class _NotFoundException : Exception
    {

        public _NotFoundException()
        {
        }

        public _NotFoundException(string message)
            : base(message)
        {
        }

        public _NotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }

    }
}