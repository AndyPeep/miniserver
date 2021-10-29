using Minihttp.HTTP.Enums;
using Minihttp.HTTP.Headers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minihttp.HTTP.Requests
{
    interface IHttpRequest
    {
        string Path { get; }
        string Url { get; }
        Dictionary<string, object> FormData { get; }
        Dictionary<string, object> QueryData { get; }
        IHttpHeaderCollection Header { get; }
        HttPReguestMethod RequestMethod { get; }
    }
}
