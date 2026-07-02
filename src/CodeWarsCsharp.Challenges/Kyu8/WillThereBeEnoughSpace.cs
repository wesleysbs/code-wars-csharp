using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class WillThereBeEnoughSpace
{
    public static int Enough(int cap, int on, int wait)
    {
        return on + wait <= cap ? 0 : on + wait - cap;
    }
}