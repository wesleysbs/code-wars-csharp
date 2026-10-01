using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class AlanPartridgeIIAppleTurnover
{
    public static string Apple(object n)
    {
        int number = Convert.ToInt32(n);
        int x = number * number;

        return x > 1000 ? "It's hotter than the sun!!" : "Help yourself to a honeycomb Yorkie for the glovebox.";
    }
}