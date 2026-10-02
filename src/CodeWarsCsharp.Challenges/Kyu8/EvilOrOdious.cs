using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class EvilOrOdious
{
    public static string Evil(int n)
    {
        string binary = Convert.ToString(n, 2);
        int count = 0;

        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[i] == '1')
                count++;
        }

        if (count % 2 == 0)
        {
            return "It's Evil!";
        }
        else
        {
            return "It's Odious!";
        }
    }
}