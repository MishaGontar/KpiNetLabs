using System;

namespace ConsoleApplication1.lab1;

public static class Program
{
    private static void Main(string[] args)
    {
        Queue<int> queue = new Queue<int>();

        queue.ItemAddedToFront += Queue_ItemAddedToFront;
        queue.ItemEnqueued += Queue_ItemEnqueued;
        queue.ItemDequeued += Queue_ItemDequeued;
        queue.Cleared += Queue_Cleared;

        queue.AddToFront(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.AddToFront(101);
        foreach (int item in queue)
        {
            Console.WriteLine($"Element is {item}");
        }

        queue.Dequeue();
        queue.Clear();
    }

    private static void Queue_ItemAddedToFront(object sender, int e)
    {
        Console.WriteLine($"Елемент {e} додано на початок черги.");
    }

    private static void Queue_ItemEnqueued(object sender, int e)
    {
        Console.WriteLine($"Елемент {e} додано в кінець черги.");
    }

    private static void Queue_ItemDequeued(object sender, int e)
    {
        Console.WriteLine($"Елемент {e} вилучено з черги.");
    }

    private static void Queue_Cleared(object sender, EventArgs e)
    {
        Console.WriteLine("Черга очищена.");
    }
}