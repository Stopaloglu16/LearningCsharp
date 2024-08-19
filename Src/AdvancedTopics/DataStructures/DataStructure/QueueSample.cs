namespace DataStructures.DataStructure;

internal class QueueSample
{

    public static void GetSample()
    {
        Queue<string> numbers = new Queue<string>();
        numbers.Enqueue("one");
        numbers.Enqueue("two");
        numbers.Enqueue("three");
        numbers.Enqueue("four");
        numbers.Enqueue("five");

        // A queue can be enumerated without disturbing its contents.
        foreach (string number in numbers)
        {
            Console.WriteLine(number);
        }

        //Dequeue Returns the first elemtent and remove it
        Console.WriteLine("\nDequeuing '{0}'", numbers.Dequeue());
        Console.WriteLine("Peek at next item to dequeue: {0}", numbers.Peek());
        Console.WriteLine("Dequeuing '{0}'", numbers.Dequeue());
    }
}
