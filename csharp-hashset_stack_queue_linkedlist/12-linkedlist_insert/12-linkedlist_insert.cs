using System;
using System.Collections.Generic;

/// <summary>
/// LList class for LinkedList operations
/// </summary>
class LList
{
    /// <summary>
    /// Inserts a new node in the correct position in an ordered LinkedList
    /// </summary>
    /// <param name="myLList">The ordered LinkedList</param>
    /// <param name="n">The value to insert</param>
    /// <returns>The newly created node</returns>
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        // If list is empty or value should go at the beginning
        if (myLList.Count == 0 || n <= myLList.First.Value)
        {
            return myLList.AddFirst(n);
        }

        // Find the correct position to insert
        LinkedListNode<int> current = myLList.First;
        
        while (current != null)
        {
            // If we found a node with a greater value, insert before it
            if (current.Value > n)
            {
                return myLList.AddBefore(current, n);
            }
            current = current.Next;
        }

        // If we reach here, the value should go at the end
        return myLList.AddLast(n);
    }
}
