using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class ContaminationString
{
    public static string Contamination(string text, string character)
    {
        if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(character))
            return "";

        return new string(character[0], text.Length);
    }
}