using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8.Pillars;

public class Kata
{
    public static int Pillars(int numPill, int dist, int width)
    {
        if (numPill == 1)
            return 0;
        int espacos = (numPill - 1) * dist * 100;
        int middlePillarsWidth = (numPill - 2) * width;
        return espacos + middlePillarsWidth;
    }
}