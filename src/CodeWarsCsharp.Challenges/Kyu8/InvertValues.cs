using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class Invert
{
    public static int[] InvertValues(int[] input)
    {
        int[] result = new int[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            result[i] = -input[i];
        }
        return result;
    }
}