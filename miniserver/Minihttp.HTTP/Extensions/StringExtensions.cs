using System;
using System.Collections.Generic;
using System.Text;

namespace Minihttp.HTTP.Extensions
{
    class StringExtensions
    {
        public string Capitalize( string text)
        {
            StringBuilder sb = new StringBuilder(); 
            text[0].ToString().ToUpper() + text.Substring(1).ToLower());
            return sb.ToString();
        }
    }
}