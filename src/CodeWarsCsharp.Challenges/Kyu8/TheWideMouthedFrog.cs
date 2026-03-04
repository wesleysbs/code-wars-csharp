using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class TheWideMouthedFrog
{
    public static string MouthSize(string animal)
    {
        if (string.Equals(animal, "alligator", StringComparison.OrdinalIgnoreCase))
        {
            return "small";
        }
        else
        {
            return "wide";
        }
    }
}
