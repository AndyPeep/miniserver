using Minihttp.HTTP.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minihttp.HTTP.Headers
{
    class HttpHeaderCollection : IHttpHeaderCollection
    {
        private readonly Dictionary<string, HttpHeader> headers;

        public HttpHeaderCollection()
        {
            this.headers = new Dictionary<string, HttpHeader>();
        }

        public void AddHeader(HttpHeader header)
        {
            CoreValidator.ThrowIfNull(header, nameof(header));
            if (!ContainsHeader(header.Key)) 
            {
                this.headers.Add(header.Key, null)
            }

            this.headers[header.Key] = header;
        }

        public bool ContainsHeader(string key)
        {
            CoreValidator.ThrowIfNullOrEmpty(key, nameof(key));
            return this.headers.ContainsKey(key);
        }

        public HttpHeader GetHeader(string key)
        {
            if (!ContainsHeader(key)) 
            {
                return null;
            }

            return this.headers[key];
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var keyValuePair in this.headers)
            {
                sb.AppendLine($"{keyValuePair.Value}");
            }

            return sb.ToString();
        }
    }
}
