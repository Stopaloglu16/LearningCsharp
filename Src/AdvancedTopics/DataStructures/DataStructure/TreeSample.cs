using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DataStructure;

internal class TreeSample
{

    public static void GetSample()
    {
        TreeNode root = new TreeNode(21);
        root.Left = new TreeNode(14);
        root.Right = new TreeNode(28);

        root.Left.Left = new TreeNode(11);

        Console.WriteLine(root.Left.Value); //14
        Console.WriteLine(root.Left.Left.Value); //11
    }

    class TreeNode
    {
        public int Value;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}
