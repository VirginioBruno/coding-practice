using System.Linq;

namespace Challenges
{
    public static class StringExtensions
    {
        public static string ToLexicographicOrder(this string[] values)
        {
            var n = values.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (string.Compare(values[i] + values[j], values[j] + values[i], StringComparison.Ordinal) > 0)
                    {
                        var temp = values[i];
                        values[i] = values[j];
                        values[j] = temp;
                    }
                }
            }

            return string.Concat(values);
        }

        public static string SuperReduce(this string s)
        {
            var result = s;

            while (ExistsDuplicatedChar(result))
            {
                var array = result.ToCharArray();

                for (int i = 0; i < array.Length - 1; i++)
                {
                    var letter = array[i].ToString();
                    var nextLetter = array[i + 1].ToString();

                    if (nextLetter == letter && result.Contains(letter + nextLetter, StringComparison.Ordinal))
                        result = result.Remove(result.IndexOf(letter + nextLetter, StringComparison.Ordinal), 2);
                }
            }

            return string.IsNullOrEmpty(result) ? "Empty String" : result;
        }

        private static bool ExistsDuplicatedChar(string text)
        {
            var array = text.ToCharArray().Distinct().ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                var letter = array[i].ToString();

                if (text.Contains(letter + letter, StringComparison.Ordinal))
                    return true;
            }

            return false;
        }
    }
}
