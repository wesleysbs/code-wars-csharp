using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class SeatsInTheater
{
    public static int Seats(int nCols, int nRows, int col, int row)
    {
        return (nRows - row) * (nCols - col + 1);
    }
}