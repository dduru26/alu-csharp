using System;
using System.Collections.Generic;

/// <summary>
/// LList class for LinkedList operations
/// </summary>
class LList
{
    /// <summary>
    /// Finds a value in a LinkedList and returns its index position
    /// </summary>
    /// <param name="myLList">The LinkedList to search</param>
    /// <param name="value">The value to find</param>
    /// <returns>The index position of the first occurrence or -1 if not found</returns>
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int index = 0;

        foreach (int item in myLList)
        {
            if (item == value)
            {
                return index;
            }
            index++;
        }

        return -1;
    }
}
