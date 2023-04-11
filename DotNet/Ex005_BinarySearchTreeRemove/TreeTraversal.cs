using System.Text;

public static class TreeTraversal
{
  public static string InOrder<T>(this BinarySearchTree<T> tree)
  where T : IComparable
  {
    StringBuilder sb = new();
    Traversal(tree.Root, sb);
    return $"[{sb.ToString().Trim()}]";
  }

  private static void Traversal<T>(BinaryTreeNode<T> node,
                                StringBuilder sb)
  {
    if (node != null)
    {
      Traversal(node.Left, sb);
      sb.Append($"{node.Value} ");
      Traversal(node.Right, sb);
    }
  }
}