using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BDSA2020.Assignment02
{
    public static class Extensions
    {
        public static bool IsSecure(this Uri uri) => uri.ToString().Substring(0,5).Equals("https");

        public static int WordCount(this string str) {
            var pattern = @"[a-zA-Z]+";
            var match = Regex.Match(str, pattern);
            return match.Length;
        }
    }
}
