using System;

/// <summary>Generic queue.</summary>
public class Queue<T>
{
    /// <summary>Returns the queue's type.</summary>
    public Type CheckType()
    {
        return typeof(T);
    }
}
