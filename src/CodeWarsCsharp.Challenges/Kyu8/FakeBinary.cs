using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class FakeBinary
{
    public static string FakeBin(string digits)
    {
        string newString = "";

        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] >= '5')
            {
                newString += '1';
            }

            else
            {
                newString += '0';
            }
        }
        return newString;
    }
}