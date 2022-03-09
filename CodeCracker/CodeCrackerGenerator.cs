using System.Collections.Generic;
using System.Linq;

namespace CodeCracker
{
    public class CodeCrackerGenerator
    {
        public CodeCrackerGenerator()
        {

        }

        public string DecryptMessage(string character)
        {
            var dictionary = new Dictionary<string, string>()
            {
                {"!", "a"},
                {")", "b"},
                {"''", "c"},
                {"(", "d"},
                {"£", "e"},
                {"*", "f"},
                {"%", "g"},
                {"&", "h"},
                {">", "i"},
                {"<", "j"},
                {"@", "k"},
                {"a", "l"},
                {"b", "m"},
                {"c", "n"},
                {"d", "o"},
                {"e", "p"},
                {"f", "q"},
                {"g", "r"},
                {"h", "s"},
                {"i", "t"},
                {"j", "u"},
                {"k", "v"},
                {"l", "w"},
                {"m", "x"},
                {"n", "y"},
                {"o", "z"},
            };

            string result = "";

            if (dictionary.ContainsKey(character))
            {
                result = dictionary.FirstOrDefault(x => x.Key == character).Value;
            };
            return result;
        }
    }
}
