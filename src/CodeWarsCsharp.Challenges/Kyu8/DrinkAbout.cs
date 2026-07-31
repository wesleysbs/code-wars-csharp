using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class DrinkAbout
{
    public static string PeopleWithAgeDrink(int old)
    {
        if (old < 14)
        {
            return "drink toddy";
        }

        else if (old < 18)
        {
            return "drink coke";
        }

        else if (old < 21)
        {
            return "drink beer";
        }

        else
        {
            return "drink whisky";
        }
    }
}