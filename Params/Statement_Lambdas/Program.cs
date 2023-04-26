using System.Text.RegularExpressions;

delegate string StrMod(string s);

class UseStatementLambdas
{
    static void Main()
    {
        StrMod ReplaceSpaces = s =>
        {
            Console.WriteLine("Replacing spaces with hyphens.");
            return s.Replace(' ', '-');
        };

        StrMod RemoveSpaces = s =>
        {
            string temp = string.Empty;
            int i;

            Console.WriteLine("Removing spaces.");
            for (i = 0; i < s.Length; i++)
                if (s[i] != ' ')
                    temp += s[i];

            return temp;
        };

        StrMod ReverseString = s =>
        {
            string temp = string.Empty;
            int i, j;

            Console.WriteLine("Reversing string.");
            for (j = 0, i = s.Length - 1; i >= 0; i--, j++)
                temp += s[i];

            return temp;
        };

        string str;

        StrMod strOp = ReplaceSpaces;
        str = strOp("This is a test.");
        Console.WriteLine("Resulting string: " + str);
        Console.WriteLine();

        strOp = RemoveSpaces;
        str = strOp("This is a test.");
        Console.WriteLine("Resulting string: " + str);
        Console.WriteLine();

        strOp = ReverseString;
        str = strOp("This is a test.");
        Console.WriteLine("Resulting string: " + str);
    }
}
