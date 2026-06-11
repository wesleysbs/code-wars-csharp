using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class GravityFlip
{
    public static int[] Flip(char dir, int[] arr)
    {
        Array.Sort(arr);
        if (dir == 'L')
            Array.Reverse(arr);
        return arr;
    }
}
