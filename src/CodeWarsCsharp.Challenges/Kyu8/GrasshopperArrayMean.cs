using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class GrasshopperArrayMean
{
    public static int FindAverage(int[] marks)
    {
        int sum = 0;
        foreach (int mark in marks)
        {
            sum += mark;
        }
        return sum / marks.Length;
    }
}
