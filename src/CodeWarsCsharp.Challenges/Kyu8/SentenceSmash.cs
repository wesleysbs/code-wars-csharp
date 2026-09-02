using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class SentenceSmash
{
    public static string Smash(string[] words)
    {
        string result = "";

        for (int i = 0; i < words.Length; i++)
        {
            result += words[i];

            if (i != words.Length - 1)
            {
                result += " ";
            }
        }
        return result;
    }
}