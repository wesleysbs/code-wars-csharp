using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class StringRepeat
{
    public static string RepeatStr(int n, string s)
    {
        string result = "";
        for (int i = 0; i < n; i++)
        {
            result += s;
        }
        return result;
    }
}