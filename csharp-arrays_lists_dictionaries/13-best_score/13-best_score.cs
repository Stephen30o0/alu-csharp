using System;
using System.Collections.Generic;

public class Dictionary
{
    public static string BestScore(Dictionary<string, int> myDict)
    {
        if (myDict.Count == 0)
            return "None";

        int maxScore = int.MinValue;
        string bestStudent = "";

        foreach (var kvp in myDict)
        {
            if (kvp.Value > maxScore)
            {
                maxScore = kvp.Value;
                bestStudent = kvp.Key;
            }
        }

        return bestStudent;
    }
}
