using Minihttp.HTTP.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minihttp.HTTP.Headers
{
    class HttpHeader
    {
        public HttpHeader(string key, string value)
        {
            CoreValidator.ThrowIfNullOrEmpty(key, nameof(key));
            CoreValidator.ThrowIfNullOrEmpty(value, nameof(value));
            this.Key = key;
            this.Value = value;
        }
        public string Key { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return $"{this.key}: {this.Value}";
        }
    }
}
