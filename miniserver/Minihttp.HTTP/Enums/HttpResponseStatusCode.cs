using System;
using System.Collections.Generic;
using System.Text;

namespace Minihttp.HTTP.Enums
{
    enum HttpResponseStatusCode
    {
        Ok = 200,
        Created = 201,
        Found = 302,
        SeeOther = 303,
        BadReguest = 400,
        Unauthorized = 401,
        Forbiden = 403,
        NotFound = 404,
        InternalServerError = 500,
    }
}
