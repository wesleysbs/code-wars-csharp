using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8.Hero;

public class Kata
{
    public static bool Hero(int bullets, int dragons)
    {
        int bulletsNecessary = dragons * 2;

        if (bullets >= bulletsNecessary)
        {
            return true;
        }
       else
        {
            return false;
        }
    }
}