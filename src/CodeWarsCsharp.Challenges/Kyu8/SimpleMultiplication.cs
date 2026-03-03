using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class SimpleMultiplication
{  
    public static int Multiply(int x)
    {
        if (x % 2 == 0)
        {
            return x * 8;
        }

        else
        {
            return x * 9;
        }
    }
}
