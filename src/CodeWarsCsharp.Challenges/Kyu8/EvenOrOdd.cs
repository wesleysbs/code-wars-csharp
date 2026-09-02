using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class EvenOrOdd
{
    public static string CheckEvenOrOdd(int number)
    {
        return number % 2 == 0 ? "Even" : "Odd";
    }
}