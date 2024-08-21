using System.Collections;
using System.Collections.Specialized;

namespace DataStructures.DataStructure;

internal class DictionarySample
{
    /// <summary>
    /// Normal dictionary Dictionary<,>
    /// </summary>
    public static void GetSample()
    {
        Dictionary<string, string> sample = new Dictionary<string, string>();

        sample.Add("A", "Success");

        var IsValid = sample.TryAdd("F", "Fail");

        var IsExist = sample.ContainsKey("??");
    }

    /// <summary>
    /// HybridDictionary
    /// </summary>
    public static void GetSample1()
    {
        HybridDictionary myHbd = new HybridDictionary(20, false);

        // Add some initial items
        myHbd.Add("item1", "value 1");
        myHbd.Add("item2", "value 2");

        myHbd.Remove("item2");

        myHbd.Clear();
    }

    /// <summary>
    /// OrderedDictionary
    /// </summary>
    public static void GetSample2()
    {
        OrderedDictionary theDict = new OrderedDictionary();

        // Add some keys and values in a particular order
        theDict.Add("item1", "value 1");
        theDict.Add("item2", "value 2");
        theDict.Add("item3", "value 3");
        theDict.Add("item5", "value 5");

        PrintDictionary(theDict);

        theDict.Remove("item3");
        theDict.Add("item4", "value 4");

        PrintDictionary(theDict);
    }

    static void PrintDictionary(OrderedDictionary theDict)
    {
        foreach (DictionaryEntry entry in theDict)
        {
            Console.WriteLine("Key = {0}, Value = {1}", entry.Key, entry.Value);
        }
        Console.WriteLine("---------------");
    }
}
