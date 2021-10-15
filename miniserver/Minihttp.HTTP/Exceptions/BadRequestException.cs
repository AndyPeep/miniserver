using System;
using System.Collections.Generic;
using System.Text;

namespace Minihttp.HTTP.Exceptions
{
    class BadRequestException : Exception
    {
        private const string exceptionDefaultMessege = "The Request was malformed or contains unsupported elements.";

        public BadRequestException()
            : base(exceptionDefaultMessege) { }
        public BadRequestException(string message) : base(message) { }
    }
}
