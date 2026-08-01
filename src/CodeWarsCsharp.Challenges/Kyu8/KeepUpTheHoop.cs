using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class KeepUpTheHoop
{
    public static string HoopCount(int n)
    {
        return n >= 10 ? "Great, now move on to tricks" : "Keep at it until you get it";
    }
}