using System;
using System.Collections.Generic;
using System.Text;

namespace Search
{
    public static class StringExtensions
    {
        public static string Normalize(this string input)
        {
            var response = string.Empty;

            foreach (var c in input)
            {
                if (char.IsLetterOrDigit(c))
                {
                    response += c;
                }
            }

            return response;
        }
    }
}
