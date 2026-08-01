using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class GetPlanetNameById
{
    public static string GetPlanetName(int id)
    {
        switch (id)
        {
            case 1:
                return "Mercury";

            case 2:
                return "Venus";

            case 3:
                return "Earth";

            case 4:
                return "Mars";

            case 5:
                return "Jupiter";

            case 6:
                return "Saturn";

            case 7:
                return "Uranus";

            case 8:
                return "Neptune";

            default:
                throw new ArgumentException("Choose a valid number");
        }
    }
}