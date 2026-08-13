using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class AbbreviateATwoWordName
{
    public static string AbbrevName(string name)
    {
        string[] words = name.Split(' ');

        return $"{words[0][0].ToString().ToUpper()}.{words[1][0].ToString().ToUpper()}";
    }
}