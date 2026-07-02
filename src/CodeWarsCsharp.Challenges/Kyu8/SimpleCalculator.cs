using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class SimpleCalculator
{
    public static double Calculator(double a, double b, char op)
    {
        switch (op)
        {
            case '+':
                return a + b;

            case '-':
                return a - b;

            case '*':
                return a * b;

            case '/':
                return a / b;

            default:
                throw new ArgumentException("Invalid operator.");
        }
    }
}