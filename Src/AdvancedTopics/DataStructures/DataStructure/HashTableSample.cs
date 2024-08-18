namespace DataStructures.DataStructure;

internal class HashTableSample
{
    public static void GetSample()
    {
        Dictionary<string, int> ages = new Dictionary<string, int>();
        ages["Alice"] = 25;
        ages["Bob"] = 30;
        ages.Add("Jon", 45);
        ages.Add("Jon1", 27);

        ages.Remove("Jon1");
        
        Console.WriteLine("ContainsKey: {0}", ages.ContainsKey("Jon")); 
    }
}
