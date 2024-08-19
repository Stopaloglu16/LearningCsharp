namespace DataStructures.DataStructure;

internal class LinkedListSample
{
    public static void GetSample()
    {
        string[] words = { "A1", "A2", "A3" };
        LinkedList<string> sentence = new LinkedList<string>(words);

        Display(sentence, "The linked list values:");

        sentence.AddFirst("A0");
        sentence.AddFirst("A");
        Display(sentence, "Added 2 first values:");

        sentence.RemoveFirst();
        Display(sentence, "Removed First:");


        sentence.AddLast("B1");
        //sentence.RemoveLast();
        Display(sentence, "Added Addlast B1:");

        Console.WriteLine($"sentence.First(): {sentence.First()} sentence.Last(): {sentence.Last()}");
        Console.WriteLine("sentence.Contains(\"jumps\") = {0}", sentence.Contains("jumps"));

        //var A1Ix = sentence.FindLast("A1");
        LinkedListNode<string> A1Ix = sentence.Find("A1");
        Console.WriteLine($"sentence.Find(A1): Previous: {A1Ix.Previous.Value} Current: {A1Ix.Value}  Next: {A1Ix.Next.Value}");


        sentence.AddBefore(A1Ix, "AA");
        sentence.Remove(A1Ix); //or sentence.Remove("A1");

        Display(sentence, "Added AA before A1, then removed A1");
    }

    private static void Display(LinkedList<string> words, string title)
    {
        Console.WriteLine(title);
        foreach (string word in words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }
}
