using System;
using System.Collections.Generic;

public class Dictionary
{

    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        if (myDict == null)
            return;

        List<string> keys = new List<string>();

        foreach (string key in myDict.Keys)
        {
            keys.Add(key);
        }

        keys.Sort();

        foreach (string key in keys)
        {
            Console.WriteLine("{0}: {1}", key, myDict[key]);
        }
    }
}