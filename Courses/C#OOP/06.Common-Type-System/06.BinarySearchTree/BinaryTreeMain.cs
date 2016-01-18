namespace _06.BinarySearchTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class BinaryTreeMain
    {
        static void Main()
        {
            var binaryTree = new BinarySearchTree<int>();

            for (int i = 0; i < 20; i++)
            {
                binaryTree.Insert(i + 1);
            }

            Console.WriteLine("Initially: {0}", binaryTree);
            binaryTree.BalanceTree();

            Console.WriteLine("Balanced: {0}", binaryTree);
            Console.WriteLine("Traverse and print (DFS)");
            binaryTree.TraverseDFS();
        }
    }
}
