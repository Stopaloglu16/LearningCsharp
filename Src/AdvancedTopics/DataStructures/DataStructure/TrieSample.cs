namespace DataStructures.DataStructure;

internal class TrieSample
{
    public static void GetSample()
    {
        Trie trie = new Trie();

        trie.Insert("apple");
        trie.Insert("app");

        Console.WriteLine(trie.Search("apple"));  // Output: True
        Console.WriteLine(trie.Search("app"));    // Output: True
        Console.WriteLine(trie.StartsWith("ap")); // Output: True
        Console.WriteLine(trie.Search("apricot")); // Output: False
    }

}


class TrieNode
{
    public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
    public bool IsEndOfWord = false;
}

class Trie
{
    private TrieNode root;

    public Trie()
    {
        root = new TrieNode();
    }

    // Insert a word into the Trie
    public void Insert(string word)
    {
        TrieNode node = root;

        foreach (char ch in word)
        {
            if (!node.Children.ContainsKey(ch))
            {
                node.Children[ch] = new TrieNode();
            }
            node = node.Children[ch];
        }
        node.IsEndOfWord = true;
    }

    // Search for a word in the Trie
    public bool Search(string word)
    {
        TrieNode node = root;

        foreach (char ch in word)
        {
            if (!node.Children.ContainsKey(ch))
            {
                return false;
            }
            node = node.Children[ch];
        }
        return node.IsEndOfWord;
    }

    // Check if there is any word in the Trie that starts with the given prefix
    public bool StartsWith(string prefix)
    {
        TrieNode node = root;

        foreach (char ch in prefix)
        {
            if (!node.Children.ContainsKey(ch))
            {
                return false;
            }
            node = node.Children[ch];
        }
        return true;
    }
}

