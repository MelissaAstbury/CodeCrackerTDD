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
                {"(", "d"}
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
