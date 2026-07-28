using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class DifferenceOfVolumesOfCuboids
{
    public static int FindDifference(int[] a, int[] b)
    {
        int volumeA = a[0] * a[1] * a[2];
        int volumeB = b[0] * b[1] * b[2];

        return Math.Abs(volumeA - volumeB);
    }
}