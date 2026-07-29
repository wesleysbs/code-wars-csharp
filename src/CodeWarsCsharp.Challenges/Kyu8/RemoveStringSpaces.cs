using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class RemoveStringSpaces
{
    public static string NoSpace(string input)
    {
        return input.Replace(" ", string.Empty);
    }
}