using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class DoYouSpeakEnglish
{
    public static bool SpeakEnglish(string sentence)
    {
         return sentence.Contains("english", StringComparison.OrdinalIgnoreCase);
    }
}

