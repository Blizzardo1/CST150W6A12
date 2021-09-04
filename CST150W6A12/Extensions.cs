using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CST150W6A12
{
    internal static class Extensions
    {
        private static readonly string _nonAlphanumeric = "[^a-zA-Z]";
        public static string TrimSpecialCharacters(this string s) => Regex.Replace(s, _nonAlphanumeric, "");
    }
}
