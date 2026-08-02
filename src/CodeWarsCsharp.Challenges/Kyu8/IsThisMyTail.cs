using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class IsThisMyTail
{
    public static bool CorrectTail(string body, string tail)
    {
        string sub = body.Substring(body.Length - (tail.Length));
        return sub == tail;
    }
}