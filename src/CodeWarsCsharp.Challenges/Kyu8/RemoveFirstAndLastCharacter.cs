using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;
public class RemoveFirstAndLastCharacter
{
    public static string RemoveChar(string s)
    {
        return s.Substring(1, s.Length - 2);
    }
}