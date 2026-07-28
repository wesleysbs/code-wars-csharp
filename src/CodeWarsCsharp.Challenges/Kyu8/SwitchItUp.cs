using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class SwitchItUp
{
    public static string NumberToWord(int number)
    {
        switch(number)
        {
            case 0:
                return "Zero";

            case 1:
                return "One";

            case 2:
                return "Two";

            case 3:
                return "Three";

            case 4:
                return "Four";

            case 5:
                return "Five";

            case 6:
                return "Six";

            case 7:
                return "Seven";

            case 8:
                return "Eight";

            case 9:
                return "Nine";

            default:
                throw new ArgumentException("Number must be between 0 and 9.");
        }
    }
}