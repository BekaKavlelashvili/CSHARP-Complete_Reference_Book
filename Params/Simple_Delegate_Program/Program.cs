using System.Globalization;
using System.Xml.Serialization;

delegate string StrMod(string str);

class DelegateTest
{
    static string ReplaceSpaces(string s)
    {
        Console.WriteLine("Replaces spaces with hyphens");
        return s.Replace(' ', '-');
    }

    static string RemoveSpaces(string s)
    {
        string temp = string.Empty;
        int i;

        Console.WriteLine("Removing spaces");

        for (i = 0; i < s.Length; i++)
            if (s[i] != ' ')
                temp += s[i];

        return temp;
    }

    static string Reverse(string s)
    {
        string temp = string.Empty;
        int i, j;

        Console.WriteLine("Reversing string");
        for (j = 0, i = s.Length - 1; i >= 0; i--, j++)
            temp += s[i];

        return temp;
    }

    static void Main()
    {
        //Method group conversion
        //StrMod strMod = ReplaceSpaces;

        //Refer to instance method
        //DelegateTest test = new DelegateTest();
        //StrMod strMod1 = test.Reverse; method not be static

        StrMod strMod = new StrMod(ReplaceSpaces);
        string str;

        str = strMod("This is a test.");
        Console.WriteLine("Resulting string: " + str);
        Console.WriteLine();

        strMod = new StrMod(RemoveSpaces);
        str = strMod("This is a test.");
        Console.WriteLine("Resulting string: " + str);
        Console.WriteLine();

        strMod = new StrMod(Reverse);
        str = strMod("This is a test.");
        Console.WriteLine("Resulting string: " + str);
        Console.WriteLine();
    }
}