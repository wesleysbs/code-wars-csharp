using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class BasicMathematicalOperations
{
    public static double BasicOp(char operation, double value1, double value2)
    {
        switch (operation)
        {

            case '+':
                return value1 + value2;

            case '-':
                return value1 - value2;

            case '*':
                return value1 * value2;

            case '/':
                return value1 / value2;

            default:
                throw new ArgumentException("Choose a valid operator");
        }
    }
}