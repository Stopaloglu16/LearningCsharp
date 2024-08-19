namespace DataStructures.DataStructure;

internal class StackSample
{
    public static void GetSample()
    {
        Stack<string> numbers = new Stack<string>();
        numbers.Push("one"); //Insert element
        numbers.Push("two");
        numbers.Push("three");
        numbers.Push("four");
        numbers.Push("five");


        foreach (string number in numbers)
        {
            Console.WriteLine(number);
            //five
            //four
            //...
        }

        //Pop Returns the last elemtent and remove it
        Console.WriteLine("\nPopping '{0}'", numbers.Pop());

        //Peek Check next item without removing
        Console.WriteLine("Peek at next item to destack: {0}", numbers.Peek());
        Console.WriteLine("Popping '{0}'", numbers.Pop());

    }
}
