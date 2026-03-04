using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class SumOfPositive
{
    public static int PositiveSum(int[] arr)
    {
        int total = 0;

        if (arr == null) return 0;

        foreach (int n in arr)
        {
            if (n > 0) total += n;
        }
        return total;
    }
}
