using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class DefineACardSuit
{
    public static string DefineSuit(string card)
    {
        char suit = card[card.Length - 1];

        switch (suit)
        {
            case '♣':
                return "clubs";

            case '♥':
                return "hearts";

            case '♠':
                return "spades";

            case '♦':
                return "diamonds";

            default:
                throw new ArgumentException("Invalid card suit");
        }
    }
}