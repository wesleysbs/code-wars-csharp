using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class ThinkfulLogicDrillsTrafficLight
{
    public static string UpdateLight(string current)
    {
        if (current == "green")
        {
            return "yellow";
        }

        else if (current == "yellow")
        {
            return "red";
        }

        else if (current == "red")
        {
            return "green";
        }
        return current;
    }
}
