using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
       HashSet<int> uniqueElements = new HashSet<int>(myList);
       int sum = 0;

       foreach (int element in uniqueElements)
       {
           sum += element;
       }
         return sum; 
    }
}