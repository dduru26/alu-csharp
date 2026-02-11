using System;
using System.Collections.Generic;

/// <summary>
/// List class
/// </summary>
class List
{
    /// <summary>
    /// Returns a sorted list of common elements in two lists
    /// </summary>
    /// <param name="list1">First list</param>
    /// <param name="list2">Second list</param>
    /// <returns>A new sorted list of common elements</returns>
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> commonSet = new HashSet<int>();

        // Find common elements
        foreach (int num in list2)
        {
            if (set1.Contains(num))
            {
                commonSet.Add(num);
            }
        }

        // Convert to list and sort
        List<int> result = new List<int>(commonSet);
        result.Sort();

        return result;
    }
}
