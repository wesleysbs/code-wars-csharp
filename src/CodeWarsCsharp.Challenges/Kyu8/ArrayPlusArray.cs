using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class ArrayPlusArray
{
    public static int SumArrays(int[] arr1, int[] arr2)
    {
        int sum = 0;

        for (int i = 0; i < arr1.Length; i++)
        {
            sum += arr1[i];
        }

        for (int i = 0; i < arr2.Length; i++)
        {
            sum += arr2[i];
        }
        return sum;
    }
}
