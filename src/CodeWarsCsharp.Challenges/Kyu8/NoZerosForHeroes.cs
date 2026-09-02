using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class NoZerosForHeroes
{
    public static int NoBoringZeros(int n)
    {
        while (n % 10 == 0 && n != 0)
        {
            n /= 10;
        }
        return n;
    }
}