using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class GetTheMeanOfAnArray
{
    public static int GetAverage(int[] marks)
    {
        int sum = 0;

        foreach (int i in marks)
        {
            sum += i;
        }
        return sum / marks.Length;
    }
}
