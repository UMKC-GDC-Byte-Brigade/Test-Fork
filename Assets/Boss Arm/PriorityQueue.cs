// C# program to implement Priority Queue
// using Arrays

using System;
using System.Collections.Generic;

// Structure for the elements in the
// priority queue
public class item
{
    public Node value;
    public int priority;
};


public class PriorityQueue
{
    public List<item> pr;

    // Pointer to the last index
    public int size = -1;
    // Function to insert a new element
    // into priority queue
    public void enqueue(Node value, int priority)
    {
        // Increase the size
        size++;

        // Insert the element
        pr.Add(new item { value = value, priority = priority });
    }

    // Function to check the top element
    public int peek()
    {
        int highestPriority = int.MinValue;
        int ind = -1;

        // Check for the element with
        // highest priority
        for (int i = 0; i <= size; i++)
        {

            // If priority is same choose
            // the element with the
            // highest value
            if (highestPriority < pr[i].priority)
            {
                highestPriority = pr[i].priority;
                ind = i;
            }
        }

        // Return position of the element
        return ind;
    }

    // Function to remove the element with
    // the highest priority
    public void dequeue()
    {
        // Find the position of the element
        // with highest priority
        int ind = peek();

        // Shift the element one index before
        // from the position of the element
        // with highest priority is found
        for (int i = ind; i < size; i++)
        {
            pr[i] = pr[i + 1];
        }

        // Decrease the size of the
        // priority queue by one
        size--;
    }
}

//this code is contributed by phasing17