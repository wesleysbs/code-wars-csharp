using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8.CenturyFromYear;

public static class Kata
{
    public static int CenturyFromYear (int year)
    {
        return (year + 99) / 100;
    }
}
