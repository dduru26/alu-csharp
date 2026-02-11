using System;
using System.Collections.Generic;

/// <summary>
/// LList class for LinkedList operations
/// </summary>
class LList
{
    /// <summary>
    /// Returns the number of elements in a LinkedList
    /// </summary>
    /// <param name="myLList">The LinkedList to count</param>
    /// <returns>The number of elements</returns>
    public static int Length(LinkedList<int> myLList)
    {
        int count = 0;

        foreach (int item in myLList)
        {
            count++;
        }

        return count;
    }
}
