using System;
using System.Collections.Generic;

/// <summary>
/// LList class for LinkedList operations
/// </summary>
class LList
{
    /// <summary>
    /// Adds a node to the beginning of a LinkedList
    /// </summary>
    /// <param name="myLList">The LinkedList to add to</param>
    /// <param name="n">The value to add</param>
    /// <returns>The newly added node</returns>
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        return myLList.AddFirst(n);
    }
}
