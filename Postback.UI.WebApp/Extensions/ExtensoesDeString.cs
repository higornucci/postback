using System.Linq;

namespace Postback.UI.WebApp.Extensions
{
    public static class ExtensoesDeString
    {
        public static string ToHashTag(this string str)
        {
            var palavras = str.Split(' ').ToList();

            if (palavras.Any())
            {
                palavras = palavras.Select(UppercaseFirst).ToList();
            }

            return string.Join("", palavras);
        }

        static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1).ToLower();
        }
    }
}