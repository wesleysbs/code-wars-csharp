using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class UsdToCny
{
    public static string Usdcny(int usd)
    {
        return $"{usd * 6.75:F2} Chinese Yuan";
    }
}