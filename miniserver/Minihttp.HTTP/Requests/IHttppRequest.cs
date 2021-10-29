using Minihttp.HTTP.Common;
using Minihttp.HTTP.Enums;
using Minihttp.HTTP.Headers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minihttp.HTTP.Requests
{
    class HttpRequest : IHttpRequest
    {
        public HttpRequest(string requestString)
        {
            CoreValidator.ThrowIfNullOrEmpty(requestString, nameof(requestString));
            this.FormData = new Dictionary<string, object>();
            this.QueryData = new Dictionary<string, object>();
            this.Headers = new HttpHeaderCollection();

        }
        public string Path { get; }

        public string Url { get; }

        public Dictionary<string, object> FormData { get; }

        public Dictionary<string, object> QueryData { get; }

        public IHttpHeaderCollection Headers { get; }

        public HttPReguestMethod RequestMethod { get; }

        private bool IsValidRequestLine(string[] requestLine) { }

        private bool IsValidReguestLQueryString(string queryString, string[] queryParameters) { }

        private void ParseRequestMethod(string[] requestLine) { }

        private void ParseRequestUrl(string[] requestLine) { }

        private void ParseRequestPath() { }

        private void ParseHeaders(string[] requestContent) { }

        private void ParseCookies() { }

        private void ParseQueryParameters() { }

        private void ParseFormDataParameters(string fromData) { }

        private void ParseRequstParameters(string fromdata) { }

        private void ParseRequest(string requestString) { }
    }
}
