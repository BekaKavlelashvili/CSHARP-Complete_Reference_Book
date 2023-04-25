delegate void StrMod(ref string str);

class MulticastDemo
{
    static void ReplaceSpaces(ref string s)
    {
        Console.WriteLine("Replaces spaces with hyphens");
        s = s.Replace(' ', '-');
    }

    static void RemoveSpaces(ref string s)
    {
        string temp = string.Empty;
        int i;

        Console.WriteLine("Removing spaces");

        for (i = 0; i < s.Length; i++)
            if (s[i] != ' ')
                temp += s[i];

        s = temp;
    }

    static void Reverse(ref string s)
    {
        string temp = string.Empty;
        int i, j;

        Console.WriteLine("Reversing string");
        for (j = 0, i = s.Length - 1; i >= 0; i--, j++)
            temp += s[i];

        s = temp;
    }

    static void Main()
    {
        StrMod strOp;
        StrMod replaceSp = ReplaceSpaces;
        StrMod removeSp = RemoveSpaces;
        StrMod reverseStr = Reverse;
        string str = "This is a test.";

        strOp = replaceSp;
        strOp += reverseStr;

        strOp(ref str);
        Console.WriteLine("Resulting string: " + str);
        Console.WriteLine();

        strOp -= replaceSp;
        strOp += removeSp;

        str = "This is a test.";
        strOp(ref str);
        Console.WriteLine("Resulting string: " + str);
        Console.WriteLine();

    }
}