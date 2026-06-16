using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class FindNearestSquareNumber
{
    public static int NearestSq(int n)
    {
        var root = Math.Sqrt(n);
        var nearestRoot = (int) Math.Round(root);
        return nearestRoot * nearestRoot;
    }
}