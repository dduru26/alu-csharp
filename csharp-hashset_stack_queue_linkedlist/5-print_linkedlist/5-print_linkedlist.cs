using System;
using System.Collections.Generic;

/// <summary>
/// LList class for LinkedList operations
/// </summary>
class LList
{
    /// <summary>
    /// Creates and prints a LinkedList of integers
    /// </summary>
    /// <param name="size">The size of the LinkedList to create</param>
    /// <returns>The newly created LinkedList</returns>
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> llist = new LinkedList<int>();

        // If size is negative, return empty list
        if (size < 0)
        {
            return llist;
        }

        // Create and print the LinkedList
        for (int i = 0; i < size; i++)
        {
            llist.AddLast(i);
            Console.WriteLine(i);
        }

        return llist;
    }
}
