using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

    public class CubeChecker
    {
        public bool IsCube(double volume, double side)
        {
            if (volume <= 0 || side <= 0)
            {
                return false;
            }
            return volume == side * side * side;
        }
    }

