using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class CapitalizationAndMutability
{
    public static string CapitalizeWord(string word)
    {
        return char.ToUpper(word[0]) + word.Substring(1);
    }
}