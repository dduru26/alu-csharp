using System;
using System.Collections.Generic;

/// <summary>
/// LList class for LinkedList operations
/// </summary>
class LList
{
    /// <summary>
    /// Returns the value of the nth node of a LinkedList
    /// </summary>
    /// <param name="myLList">The LinkedList to search</param>
    /// <param name="n">The index of the node</param>
    /// <returns>The value of the node at index n or 0 if not found</returns>
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int index = 0;

        foreach (int item in myLList)
        {
            if (index == n)
            {
                return item;
            }
            index++;
        }

        return 0;
    }
}
