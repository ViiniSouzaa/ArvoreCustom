using ArvoreCustom.Models;

namespace ArvoreCustom.Services;

public class TreeBuilder
{
    public Node? BuildTree(int[] arr)
    {
        if (arr == null || arr.Length == 0) return null;

        // Raiz = maior valor
        int maxIndex = Array.IndexOf(arr, arr.Max());
        var root = new Node(arr[maxIndex]);

        // Galho esquerdo = valores à esquerda, ordem decrescente
        var leftSide = arr.Take(maxIndex).OrderByDescending(x => x).ToList();
        root.Left = BuildChain(leftSide);

        // Galho direito = valores à direita, ordem decrescente
        var rightSide = arr.Skip(maxIndex + 1).OrderByDescending(x => x).ToList();
        root.Right = BuildChain(rightSide);

        return root;
    }

    private Node? BuildChain(List<int> values)
    {
        if (values.Count == 0) return null;

        var head = new Node(values[0]);
        var cur = head;
        for (int i = 1; i < values.Count; i++)
        {
            cur.Left = new Node(values[i]);
            cur = cur.Left;
        }
        return head;
    }

    public void PrintTree(Node? root, string indent = "", bool isLeft = true)
    {
        if (root == null) return;

        Console.WriteLine(indent + root.Value);

        if (root.Left != null || root.Right != null)
        {
            if (root.Left != null)
            {
                Console.Write(indent + "/ ");
                PrintTree(root.Left, indent + "  ", true);
            }
            if (root.Right != null)
            {
                Console.Write(indent + "\\ ");
                PrintTree(root.Right, indent + "  ", false);
            }
        }
    }
}
