using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8.SameCase;

public class Kata
{
    public static int SameCase(char a, char b, int expected)
    {
        if (!char.IsLetter(a) || !char.IsLetter(b))
            return -1;

        if (char.IsUpper(a) == char.IsUpper(b))
            return 1;

        return 0;
    }
}
