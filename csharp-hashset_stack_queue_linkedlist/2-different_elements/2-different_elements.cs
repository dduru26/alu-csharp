using System;
using System.Collections.Generic;

/// <summary>
/// List class
/// </summary>
class List
{
    /// <summary>
    /// Returns a sorted list of all elements present in one or the other list but not both
    /// </summary>
    /// <param name="list1">First list</param>
    /// <param name="list2">Second list</param>
    /// <returns>A new sorted list of elements present in one list or the other but not both</returns>
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> set2 = new HashSet<int>(list2);
        HashSet<int> differentSet = new HashSet<int>();

        // Add elements that are in list1 but not in list2
        foreach (int num in set1)
        {
            if (!set2.Contains(num))
            {
                differentSet.Add(num);
            }
        }

        // Add elements that are in list2 but not in list1
        foreach (int num in set2)
        {
            if (!set1.Contains(num))
            {
                differentSet.Add(num);
            }
        }

        // Convert to list and sort
        List<int> result = new List<int>(differentSet);
        result.Sort();

        return result;
    }
}
