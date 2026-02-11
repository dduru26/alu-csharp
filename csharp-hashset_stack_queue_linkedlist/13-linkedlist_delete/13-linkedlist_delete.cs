using System;
using System.Collections.Generic;

/// <summary>
/// LList class for LinkedList operations
/// </summary>
class LList
{
    /// <summary>
    /// Deletes the node at the given index position
    /// </summary>
    /// <param name="myLList">The LinkedList to modify</param>
    /// <param name="index">The index of the node to delete</param>
    public static void Delete(LinkedList<int> myLList, int index)
    {
        // Check if the list is empty or index is negative
        if (myLList.Count == 0 || index < 0)
        {
            return;
        }

        int currentIndex = 0;
        LinkedListNode<int> current = myLList.First;

        while (current != null)
        {
            if (currentIndex == index)
            {
                myLList.Remove(current);
                return;
            }
            currentIndex++;
            current = current.Next;
        }
    }
}
