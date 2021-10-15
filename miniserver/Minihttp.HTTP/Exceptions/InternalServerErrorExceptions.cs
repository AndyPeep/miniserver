using System;
using System.Collections.Generic;
using System.Text;

namespace Minihttp.HTTP.Exceptions
{
    class InternalServerErrorExceptions : Exception
    {
        private const string defaultMessageException = "The Server has encountered an error";
        public InternalServerErrorExceptions() : base(defaultMessageException)
        {
            
        }

        public InternalServerErrorExceptions(string message) : base(message) 
        {

        }
    }
}
