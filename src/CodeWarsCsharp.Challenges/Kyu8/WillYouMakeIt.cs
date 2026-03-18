using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class WillYouMakeIt
{
    public static bool ZeroFuel(double distanceToPump, double mpg, double fuelLeft)
    {
        return mpg * fuelLeft >= distanceToPump;
    }
}
