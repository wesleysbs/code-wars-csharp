using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class SumOfDifferencesInArray
{
    public static int SumOfDifferences(int[] arr)
    {
        if (arr.Length <= 1)
            return 0;

        return arr.Max() - arr.Min();
    }
}