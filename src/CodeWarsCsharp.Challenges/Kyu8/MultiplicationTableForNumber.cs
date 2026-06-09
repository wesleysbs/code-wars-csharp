using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8.MultiplicationTableForNumber;

public class MultiplicationTableForNumberKata
{
    public static string MultiTable(int number)
    {
        string result = "";

        for (int i = 1; i <= 10; i++)
        {
            result += $"{i} * {number} = {i * number}";

            if (i < 10)
            {
                result += "\n";
            }
        }
        return result;
    }
}