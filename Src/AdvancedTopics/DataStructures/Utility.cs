namespace DataStructures;

internal class Utility
{
    public static void PrintArray(string actionName, int[] array) =>
            Console.WriteLine("{0} [{1}]", actionName, string.Join(", ", array));

}
