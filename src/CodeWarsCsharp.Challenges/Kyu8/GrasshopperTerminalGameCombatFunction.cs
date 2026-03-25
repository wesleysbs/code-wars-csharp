using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class Game
{

    public static float Combat(float health, float damage)
    {
        return Math.Max(0f, health - damage);
    }
}