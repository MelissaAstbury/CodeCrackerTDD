namespace CodeCracker
{
    public class CodeCrackerGenerator
    {
        public CodeCrackerGenerator()
        {

        }

        public string DecryptMessage(string character)
        {
            if (character == "!")
            {
                return "a";
            }
            return "b";
        }
    }
}
