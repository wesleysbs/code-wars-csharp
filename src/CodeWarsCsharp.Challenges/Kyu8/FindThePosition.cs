using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class FindThePosition
{
    public static string Position(char alphabet)
    {
        int position = alphabet - 'a' + 1;
        return $"Position of alphabet: {position}";
    }
}