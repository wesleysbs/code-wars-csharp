using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class JennysSecretMessage
{
    public static string Greet(string name)
    {
        if (name == "Johnny")
        {
            return "Hello, my love!";
        }
        else
        {
            return $"Hello, {name}!";
        }
    }
}