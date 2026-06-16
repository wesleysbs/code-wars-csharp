using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class TheFeastOfManyBeasts
{
    public static bool Feast(string beast, string dish)
    {
        return beast[0] == dish[0] &&
               beast[beast.Length - 1] == dish[dish.Length - 1];
    }
}