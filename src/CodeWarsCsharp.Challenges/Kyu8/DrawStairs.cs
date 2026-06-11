using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8.DrawStairs;

public class Kata
{
    public static string DrawStairs(int n)
    {
        string result = "";

        for (int i = 0; i < n; i++)
        {
            result += new string(' ', i) + "I";

            if (i < n - 1)
            {
                result += "\n";
            }
        }

        return result;
    }
}