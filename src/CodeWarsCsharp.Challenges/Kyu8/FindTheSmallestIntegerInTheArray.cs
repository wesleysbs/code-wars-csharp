using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public static class FindTheSmallestIntegerInTheArray
{
    public static int FindSmallestInt(int[] args)
    {
        int smallestInt = args[0];

        foreach (int i in args)
        {
            if (i<smallestInt)
                smallestInt = i;
}

        return smallestInt;
    }
}
