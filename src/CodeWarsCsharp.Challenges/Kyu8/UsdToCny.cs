using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class UsdToCny
{
    public static string Usdcny(int usd)
    {
        return $"{(usd * 6.75).ToString("F2", CultureInfo.InvariantCulture)} Chinese Yuan";
    }
}