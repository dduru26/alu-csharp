using System;
using System.Collections.Generic;

public class Dictionary
{
   
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int count = 0;

        if (myDict == null)
            return count;

        foreach (var key in myDict.Keys)
        {
            count++;
        }

        return count;
    }
}