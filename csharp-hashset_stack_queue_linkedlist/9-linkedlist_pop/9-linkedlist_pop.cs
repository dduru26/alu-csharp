using System;
using System.Collections.Generic;

/// <summary>
/// LList class for LinkedList operations
/// </summary>
class LList
{
    /// <summary>
    /// Deletes the head node of a LinkedList and returns that node's data
    /// </summary>
    /// <param name="myLList">The LinkedList to pop from</param>
    /// <returns>The value of the head node or 0 if empty</returns>
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList.Count == 0)
        {
            return 0;
        }

        int value = myLList.First.Value;
        myLList.RemoveFirst();
        return value;
    }
}
