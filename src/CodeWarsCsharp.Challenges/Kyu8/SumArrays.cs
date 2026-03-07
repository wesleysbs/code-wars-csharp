using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class SumArrays
{
    public static double SumArray(double[] array)
    {
        if (array == null) return 0;
        double sum = 0.0;
        foreach (double v in array)
        {
            sum += v;
        }
        return sum;
    }
}
