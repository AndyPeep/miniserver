using Minihttp.HTTP.Enums;
using Minihttp.HTTP.Headers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minihttp.HTTP.Responses
{
    interface IHttpResponse
    {
        HttpResponseStatusCode StatusCode { get; }
        IHttpHeaderCollection Headers { get; }

        byte[] Content { get; }

        void AddHeder(HttpHeader header);

        byte [] GetBytes();
    }
}
