using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class SumTheStrings
{
    public static string StringsSum(string s1, string s2)
    {
        int a = string.IsNullOrEmpty(s1) ? 0 : int.Parse(s1);
        int b = string.IsNullOrEmpty(s2) ? 0 : int.Parse(s2);

        return (a + b).ToString();
    }
}