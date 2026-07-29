using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class HowOldWillIBeIn2099
{
    public static string CalculateAge(int birth, int yearTo)
    {
        int age = Math.Abs(yearTo - birth);
        string yearWord = age == 1 ? "year" : "years";

        if (birth > yearTo)
        {
            return $"You will be born in {age} {yearWord}.";
        }

        else if (birth == yearTo)
        {
            return $"You were born this very year!";
        }

        else
        {
            return $"You are {age} {yearWord} old.";
        }  
    }
}