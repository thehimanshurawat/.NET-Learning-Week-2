using System;
using System.Collections.Generic;

// Step 1: Create a generic collection class
public class CustomCollection<T>
{
    private List<T> items = new List<T>();

    // Step 2: Method to add an item
    public void Add(T item)
    {
        items.Add(item);
    }

    // Step 3: Method to remove an item
    public bool Remove(T item)
    {
        return items.Remove(item);
    }

    // Step 4: Method to display all items
    public void Display()
    {
        Console.WriteLine("Collection items:");
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}

// Step 5: Main program execution
class Program
{
    static void Main()
    {
        // Create a collection for integers
        CustomCollection<int> intCollection = new CustomCollection<int>();
        intCollection.Add(10);
        intCollection.Add(20);
        intCollection.Add(30);
        intCollection.Display();
        intCollection.Remove(20);
        intCollection.Display();

        // Create a collection for strings
        CustomCollection<string> stringCollection = new CustomCollection<string>();
        stringCollection.Add("Hello");
        stringCollection.Add("World");
        stringCollection.Display();
    }
}
