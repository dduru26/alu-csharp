using System;

/// <summary>Generic queue.</summary>
public class Queue<T>
{
    /// <summary>A node in the queue.</summary>
    public class Node
    {
        /// <summary>The node's value.</summary>
        public T value = default(T);

        /// <summary>The next node.</summary>
        public Node next = null;

        /// <summary>Creates a node with the given value.</summary>
        public Node(T value)
        {
            this.value = value;
        }
    }

    /// <summary>The first node.</summary>
    public Node head;

    /// <summary>The last node.</summary>
    public Node tail;

    /// <summary>The number of nodes.</summary>
    public int count;

    /// <summary>Returns the queue's type.</summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>Adds a new node to the end of the queue.</summary>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }

        count++;
    }

    /// <summary>Returns the number of nodes in the queue.</summary>
    public int Count()
    {
        return count;
    }
}
