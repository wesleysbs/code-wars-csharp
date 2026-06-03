using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8.TotalPoints;

public static class Kata
{
    public static int TotalPoints(string[] games)
    {
        int points = 0;

        foreach (string game in games)
        {
            string[] score = game.Split(':');

            int x = int.Parse(score[0]);
            int y = int.Parse(score[1]);

            if (x > y)
                points += 3;
            else if (x == y)
                points += 1;
        }
        return points;
    }
}
