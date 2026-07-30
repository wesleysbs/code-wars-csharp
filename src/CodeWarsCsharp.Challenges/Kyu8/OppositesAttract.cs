using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class OppositesAttract
{
    public static bool LoveFunc(int flower1, int flower2)
    {
        return flower1 % 2 != flower2 % 2;
    }
}