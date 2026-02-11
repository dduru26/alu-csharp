using System;
using System.Collections.Generic;

/// <summary>
/// LList class for LinkedList operations
/// </summary>
class LList
{
    /// <summary>
    /// Returns the sum of all the data of a LinkedList
    /// </summary>
    /// <param name="myLList">The LinkedList to sum</param>
    /// <returns>The sum of all data in the LinkedList</returns>
    public static int Sum(LinkedList<int> myLList)
    {
        int sum = 0;

        foreach (int item in myLList)
        {
            sum += item;
        }

        return sum;
    }
}
