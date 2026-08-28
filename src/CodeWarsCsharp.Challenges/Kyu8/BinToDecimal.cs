using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class BinToDecimal
{
    public static int BinToDec(string s)
    {
        return Convert.ToInt32(s, 2);
    }
}