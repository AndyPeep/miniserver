using Minihttp.HTTP.Enums;
using Minihttp.HTTP.Headers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minihttp.HTTP.Responses
{
    class HttpResponse : IHttpResponse
    {
        public HttpHeader() 
        {

        }

        public HttpResponse(HttpResponseStatusCode statusCode)
        {

        }

        public HttpResponseStatusCode Response StatusCode { get; private set;}

        public IHttpHeaderCollection Response Headers { get; private set;}

        public byte[] Content { get; private set; };

        public void AddHeder(HttpHeader header)
        {
            throw new NotImplementedException();
        }

        public byte[] IGetBytes()
        {
            throw new NotImplementedException();
        }
    }
}
