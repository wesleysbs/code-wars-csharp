using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class LostWithoutAMap
{
        public static int[] Maps(int[] x)
        {
            int[] newArray = new int[x.Length];

            for (int i = 0; i < x.Length; i++)
            {
                newArray[i] = x[i] * 2;
            }
            return newArray;
        }
    }
