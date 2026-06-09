using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class Dinglemouse
{

    public static int[] humanYearsCatYearsDogYears(int humanYears)
    {
        int catYears = 0;
        int dogYears = 0;

        if (humanYears >= 1)
        {
            catYears += 15;
            dogYears += 15;
        }

        if (humanYears >= 2)
        {
            catYears += 9;
            dogYears += 9;
        }

        if (humanYears > 2)
        {
            catYears += (humanYears - 2) * 4;
            dogYears += (humanYears - 2) * 5;
        }

        return new int[] { humanYears, catYears, dogYears };
    }
}
