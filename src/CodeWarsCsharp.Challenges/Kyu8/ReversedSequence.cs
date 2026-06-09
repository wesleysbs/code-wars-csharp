using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8.ReversedSequence;

public static class Kata
{
    public static int[] ReverseSeq(int n)
    {
        int[] result = new int[n];

        for (int i = 0; i < n; i++)
        {
            result[i] = n - i;
        }
        return result;
    }
}
